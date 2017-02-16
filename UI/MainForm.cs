using WifiSniffer.Data;
using WifiSniffer.Visualization;
using SharpPcap;
using SharpPcap.Packets;
using System;
using System.Collections.Concurrent;
using System.Security.Principal;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;


namespace WifiSniffer.UI
{
    internal enum ActionType
    {
        OpeningCaptureFile,
        Quitting,
        StartingNewCapture
    }

    internal partial class MainForm : BaseForm
    {
        #region Private Fields

        private PcapDevice device = null;
        private long packetsCount = 0;
        private bool capturedPacketsHaveBeenSaved = true;
        private ConcurrentDictionary<long, Packet> packetsDictionary =
            new ConcurrentDictionary<long, Packet>();

        #endregion


        #region Delegates

        private delegate void AddListViewItemDelegate(ListViewItem item, ListView listView);
        private delegate void UpdateTreeViewDelegate(Packet packet, TreeView treeView);
        private delegate void FillGridViewDelegate(Packet packet, DataGridView gridView);
        private delegate void ShowDisplayedPacketsCountDelegate(string itemName, string text, StatusStrip statusStrip);

        #endregion


        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion


        #region Event Handlers

        #region File

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCaptureFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (packetsDictionary.Count == 0)
            {
                MessageBox.Show("Currently there are no captured packets.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            SaveCapturedPacketsToFile();
        }

        #endregion

        #region Capture

        private void devicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChooseDeviceForm chooseDeviceForm = new ChooseDeviceForm(device))
            {
                chooseDeviceForm.ButtonStopPressed += new EventHandler(chooseDeviceForm_ButtonStopPressed);

                if (chooseDeviceForm.ShowDialog() == DialogResult.OK)
                {
                    device = chooseDeviceForm.Device;
                    StartCapture();
                }
            }
        }

        private void chooseDeviceForm_ButtonStopPressed(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        #endregion


        private void device_OnPacketArrival(object sender, PcapCaptureEventArgs e)
        {
            DisplayPacketData(e.Packet);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device != null)
            {
                if (device.Started)
                {
                    StopCapture();
                }

                if (!capturedPacketsHaveBeenSaved)
                {
                    DialogResult userWish = ShowDialogAskingUserToSaveCaptureData(ActionType.Quitting);

                    if (userWish == DialogResult.OK)
                    {
                        SaveCapturedPacketsToFile();
                    }
                    else if (userWish == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void listViewPackets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPackets.SelectedItems.Count == 0) return;

            int selectedIndex = Convert.ToInt32(listViewPackets.SelectedItems[0].Text);

            Packet packet = (Packet)packetsDictionary[selectedIndex];

            TreeViewVisualizer.UpdateTreeView(packet, treeViewPacketInfo);

            DataGridViewVisualizer.FillDataGridView((Packet)packetsDictionary[selectedIndex], dataGridViewPacketData);
        }

        private void listViewPackets_Resize(object sender, EventArgs e)
        {
            listViewPackets.Columns[listViewPackets.Columns.Count - 1].Width = -2;
        }

        #endregion


        #region Private Methods

        private void OpenCaptureFile()
        {
            if (!capturedPacketsHaveBeenSaved)
            {
                DialogResult userWish = ShowDialogAskingUserToSaveCaptureData(ActionType.OpeningCaptureFile);

                if (userWish == DialogResult.OK)
                {
                    SaveCapturedPacketsToFile();
                }
                else if (userWish == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Nullify the packets counter and clear the structures that keep
            // the captured packets info
            ClearDataStructures();

            capturedPacketsHaveBeenSaved = true;


            // Get an offline file pcap device
            PcapDevice offlineDevice = new PcapOfflineDevice(openCaptureFileDialog.FileName);

            try
            {
                Cursor = Cursors.WaitCursor;

                // Open the device for capturing 
                offlineDevice.Open();

                // Register our handler function to the "packet arrival" event
                offlineDevice.OnPacketArrival += new Pcap.PacketArrivalEvent(device_OnPacketArrival);

                // Start capture "INFINTE" number of packets 
                // This method will return when EOF reached. 
                offlineDevice.Capture(Pcap.INFINITE);

                // Set the MainForm text
                SetMainFormText(String.Format("{0} - Wi-Fi Sniffer", Path.GetFileName(openCaptureFileDialog.FileName)));

                // Set the status labels texts
                SetStatusLabelsTexts(String.Format("File: \"{0}\"", openCaptureFileDialog.FileName), packetsCount == 0 ? "| No packets" : String.Format("| Displayed packets: {0}", packetsCount));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the pcap device 
                offlineDevice.Close();

                Cursor = Cursors.Default;
            }
        }

        bool connect = false;
        private void WiFi_Hotspot(string ssid, string key, bool status)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.Verb = "runas";
            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                if (status)
                {
                    process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + key);
                    process.StandardInput.WriteLine("netsh wlan start hosted network");
//                    process.StandardInput.WriteLine("REG add 'HKLM\\SYSTEM\\CurrentControlSet\\services\\SharedAccess' /v Start /t REG_DWORD /d 2 /f");
                    process.StandardInput.Close();
                }
                else
                {
                    process.StandardInput.WriteLine("netsh wlan stop hostednetwork");
                    process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=disallow ssid=" + ssid);
                    process.StandardInput.Close();
                }
            }
        }

        public static bool IsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal p = new WindowsPrincipal(id);
            return p.IsInRole(WindowsBuiltInRole.Administrator);
        }


        private void StartCapture()
        {
            if (!capturedPacketsHaveBeenSaved)
            {
                DialogResult userWish = ShowDialogAskingUserToSaveCaptureData(ActionType.StartingNewCapture);

                if (userWish == DialogResult.OK)
                {
                    SaveCapturedPacketsToFile();
                }
                else if (userWish == DialogResult.Cancel)
                {
                    return;
                }
            }

            // Nullify the packets counter and clear the structures that keep
            // the captured packets info
            ClearDataStructures();

            try
            {
                Cursor = Cursors.WaitCursor;

                // Open the device for capturing 
                device.Open(true, 1000);

                // tcpdump filter to capture only TCP/IP packets

                // Register our handler function to the "packet arrival" event
                device.OnPacketArrival += new Pcap.PacketArrivalEvent(device_OnPacketArrival);

                // Start the capturing process
                device.StartCapture();

                // Enable the navigation buttons
//                SetNavigationButtonsEnabledState(true);

                // Set the MainForm text
                SetMainFormText(String.Format("Wi-Fi Sniffer Started on: {0}", device.Description));

                // Set the status labels texts
                SetStatusLabelsTexts("Packet Capturing Status", "| No packets");

                SetMenuItemsEnabledState(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select a Device to Capture on!! \n" +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

               device.Close();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void StopCapture()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                device.Close();

                if (packetsCount > 0)
                {
                    // There are captured packets and they haven't been saved.
                    capturedPacketsHaveBeenSaved = false;
                }
                else
                {
                    // No captured packets - nothing to save.
                    capturedPacketsHaveBeenSaved = true;
                }

                // Set the MainForm text
                SetMainFormText("Wi-Fi Sniffer");

                // Set the status labels texts
                SetStatusLabelsTexts("Load OR Capture Packets", packetsCount == 0 ? "| No packets" : String.Format("| Displayed packets: {0}", packetsCount));

                SetMenuItemsEnabledState(true);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void DisplayPacketData(Packet packet)
        {
            packetsCount++;
            packetsDictionary.AddOrUpdate(packetsCount, packet, (i, p) => p);

            ListViewItem packetItem;

            if (packet is ARPPacket)
            {
                ARPPacket arpPacket = (ARPPacket)packet;

                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.LightPink,
                    packetsCount.ToString(),
                    TreeViewVisualizer.GetHyphenatedHwAddress(arpPacket.ARPSenderHwAddress),
                    String.Empty,
                    String.Empty,
                    TreeViewVisualizer.GetHyphenatedHwAddress(arpPacket.ARPTargetHwAddress),
                    String.Empty,
                    String.Empty,
                    "ARP",
                    arpPacket.ToString());
            }
            else if (packet is ICMPPacket)
            {
                ICMPPacket icmpPacket = (ICMPPacket)packet;

                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.Thistle,
                    packetsCount.ToString(),
                    icmpPacket.SourceAddress.ToString(),
                    DnsTable.GetHostByAddress(icmpPacket.SourceAddress),
                    String.Empty,
                    icmpPacket.DestinationAddress.ToString(),
                    DnsTable.GetHostByAddress(icmpPacket.DestinationAddress),
                    String.Empty,
                    "ICMP",
                    icmpPacket.ToString());
            }
            else if (packet is TCPPacket)
            {
                TCPPacket tcpPacket = (TCPPacket)packet;

                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.LightSkyBlue,
                    packetsCount.ToString(),
                    tcpPacket.SourceAddress.ToString(),
                    DnsTable.GetHostByAddress(tcpPacket.SourceAddress),
                    tcpPacket.SourcePort.ToString(),
                    tcpPacket.DestinationAddress.ToString(),
                    DnsTable.GetHostByAddress(tcpPacket.DestinationAddress),
                    tcpPacket.DestinationPort.ToString(),
                    "TCP",
                    tcpPacket.ToString());
            }
            else if (packet is UDPPacket)
            {
                UDPPacket udpPacket = (UDPPacket)packet;

                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.LemonChiffon,
                    packetsCount.ToString(),
                    udpPacket.SourceAddress.ToString(),
                    DnsTable.GetHostByAddress(udpPacket.SourceAddress),
                    udpPacket.SourcePort.ToString(),
                    udpPacket.DestinationAddress.ToString(),
                    DnsTable.GetHostByAddress(udpPacket.DestinationAddress),
                    udpPacket.DestinationPort.ToString(),
                    "UDP",
                    udpPacket.ToString());
            }
            else
            {
                packetItem = ListViewVisualizer.GenerateListViewItem(
                    Color.Linen,
                    packetsCount.ToString(),
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    String.Empty,
                    "unknown",
                    String.Empty);
            }

            AddListViewItemDelegate addListViewItemDelegate = new AddListViewItemDelegate(ListViewVisualizer.AddListViewItem);
            listViewPackets.Invoke(addListViewItemDelegate, new object[] { packetItem, listViewPackets });

            ShowDisplayedPacketsCountDelegate showDisplayedPacketsDelegate = new ShowDisplayedPacketsCountDelegate(StatusStripVisualizer.SetLabelText);
            statusStrip.Invoke(showDisplayedPacketsDelegate, new object[] { toolStripStatusLabelPacketsInfo.Name, String.Format("| Displayed packets: {0}", packetsCount), statusStrip });

            if (packetsCount == 1)
            {
                UpdateTreeViewDelegate updateTreeViewDelegate = new UpdateTreeViewDelegate(TreeViewVisualizer.UpdateTreeView);
                treeViewPacketInfo.Invoke(updateTreeViewDelegate, new object[] { (Packet)packetsDictionary[1], treeViewPacketInfo });

                FillGridViewDelegate fillGridViewDelegate = new FillGridViewDelegate(DataGridViewVisualizer.FillDataGridView);
                dataGridViewPacketData.Invoke(fillGridViewDelegate, new object[] { (Packet)packetsDictionary[1], dataGridViewPacketData });
            }
        }

        private void ClearDataStructures()
        {
            if (packetsCount > 0)
            {
                packetsCount = 0;
                listViewPackets.Items.Clear();
                treeViewPacketInfo.Nodes.Clear();
                dataGridViewPacketData.Rows.Clear();
                packetsDictionary.Clear();
            }
        }

        private void SetMenuItemsEnabledState(bool enabled)
        {
            startToolStripMenuItem.Enabled = enabled;
            stopToolStripMenuItem.Enabled = !enabled;
            openFileToolStripMenuItem.Enabled = enabled;
            saveAsToolStripMenuItem.Enabled = enabled;
        }

        private void SaveCapturedPacketsToFile()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                device.Open();

                // Open or create a capture output file
                device.DumpOpen(saveFileDialog.FileName);

                foreach (Packet packet in packetsDictionary.Values)
                {
                    device.Dump(packet);
                }

                device.DumpFlush();

                // Set the flag packetsHaveBeenSaved to true - the displayed packets
                // have just been saved.
                capturedPacketsHaveBeenSaved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                device.DumpClose();
                device.Close();

                Cursor = Cursors.Default;
            }
        }

 
        private void SetStatusLabelsTexts(string state, string packetsInfo)
        {
            toolStripStatusLabelState.Text = state;

            if (toolStripStatusLabelPacketsInfo.Text != packetsInfo)
            {
                toolStripStatusLabelPacketsInfo.Text = packetsInfo;
            }
        }

        private void SetMainFormText(string text)
        {
            this.Text = text;
        }

        private DialogResult ShowDialogAskingUserToSaveCaptureData(ActionType action)
        {
            DialogResult answer;

            switch (action)
            {
                case ActionType.OpeningCaptureFile:
                    {
                        answer = MessageBox.Show(
                           "Do You want to Save Captured Data ?",
                            "Save Captured File",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                        break;
                    }
                case ActionType.Quitting:
                    {
                        answer = MessageBox.Show(
                          "Do You want to Save Captured Data ?",
                            "Save Captured File",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                        break;
                    }
                case ActionType.StartingNewCapture:
                    {
                        answer = MessageBox.Show(
                      "Do You want to Save Captured Data ?",
                            "Save Captured File",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);

                        break;
                    }
                default:
                    {
                        answer = DialogResult.Cancel;
                        break;
                    }
            }

            if (answer == DialogResult.Yes)
            {
                return saveFileDialog.ShowDialog();
            }
            else
            {
                return answer;
            }
        }

        #endregion

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);

        //    bool CursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

        //    if (this.WindowState == FormWindowState.Minimized && CursorNotInBar) {
        //        this.ShowInTaskbar = false;
        //        notifyIcon1.Visible = true;
        //        this.Hide();
        //    }
        //    else if (FormWindowState.Normal == this.WindowState)
        //    {
        //        notifyIcon1.Visible = false;
        //    }

        //}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                        string ssid = toolStripTextBox1.Text, key = toolStripTextBox2.Text;
            if (!connect)
            {
                if (toolStripTextBox1.Text == null || toolStripTextBox1.Text == "")
                {
                    MessageBox.Show("SSID cannot be left blank !",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (toolStripTextBox2.Text == null || toolStripTextBox2.Text == "")
                    {
                        MessageBox.Show("Key value cannot be left blank !",
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (key.Length >= 8)
                        {
                            WiFi_Hotspot(ssid, key, true);
                            toolStripTextBox1.Enabled = false;
                            toolStripTextBox2.Enabled = false;
                            toolStripButton1.Text = "Stop";
                            connect = true;
                        }
                        else
                        {
                            MessageBox.Show("Key should be more then or Equal to 8 Characters !",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                WiFi_Hotspot(null, null, false);
                toolStripTextBox1.Enabled = true;
                toolStripTextBox2.Enabled = true;
                toolStripButton1.Text = "Start";
                connect = false;
            }

        }
        public void RestartElevated()
        {

            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.UseShellExecute = true;

            startInfo.CreateNoWindow = true;

            startInfo.WorkingDirectory = Environment.CurrentDirectory;

            startInfo.FileName = System.Windows.Forms.Application.ExecutablePath;

            startInfo.Verb = "runas";

            try
            {

                Process p = Process.Start(startInfo);

            }

            catch
            {



            }



            System.Windows.Forms.Application.Exit();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                RestartElevated();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (device == null)
            {
                MessageBox.Show("Please Select a Device First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StartCapture();
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = true;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (device == null)
            {
                MessageBox.Show("No device has been set to Capturing Mode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StopCapture();
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = false;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ClearDataStructures();
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wi-Fi Sniffer is Free and Open Source Tool Which Provides Hosted Network utilities and Sniffing Data for Fun and Profit.\n\nAuthor: Muhammad Adeel\nTeam: Ali Tamoor, Fakhar Husnain\n\nContact: Chaudhary1337@gmail.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}