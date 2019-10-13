using System;
using System.Windows.Forms;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using WiimoteLib;

namespace WiiBalanceWalker
{
    public partial class FormBluetooth : Form
    {
        public FormBluetooth()
        {
            InitializeComponent();
        }

        private void button_DeviceSearch_Click(object sender, EventArgs e)
        {
            Enabled = false;

            try
            {
                using (var btClient = new BluetoothClient())
                {
                    // PROBLEM:
                    // false false true: finds only unknown devices, which excludes existing but broken device entries.
                    // false true  true: finds broken entries, but even if powered off, so pairing attempts then crash.
                    // WORK-AROUND:
                    // Remove existing entries first, then find powered on entries.
                    
                    var btIgnored = 0;

                    // Find remembered bluetooth devices.

                    label_Status.Text = "Resetting bluetooth devices";
                    label_Status.Refresh();

                    if (checkBox_RemoveExisting.Checked)
                    {
                        var btExistingList = btClient.DiscoverDevices(255, false, true, false);

                        foreach (var btItem in btExistingList)
                        {
                            if (!btItem.DeviceName.Contains("RVL-WBC")) continue;

                            BluetoothSecurity.RemoveDevice(btItem.DeviceAddress);
                            btItem.SetServiceState(BluetoothService.HumanInterfaceDevice, false);
                        }
                    }

                    // Find unknown bluetooth devices.

                    label_Status.Text = "Scanning for bluetooth devices";
                    label_Status.Refresh();

                    var btDiscoveredList = btClient.DiscoverDevices(255, false, false, true);

                    foreach (var btItem in btDiscoveredList)
                    {
                        // Just in-case any non Wii devices are waiting to be paired.

                        if (!btItem.DeviceName.Contains("RVL-WBC"))
                        {
                            btIgnored += 1;
                            continue;
                        }
                        else
                        {
                            label_Status.Text = "Pairing Wii Fit balance board";
                        }

                        label_Status.Refresh();
                                               
                        // Sync button requires host address, holding 1+2 buttons requires device address.

                        var btPin = AddressToWiiPin(BluetoothRadio.PrimaryRadio.LocalAddress.ToString());

                        // Pin needs to be added before doing the pair request.

                        new BluetoothWin32Authentication(btItem.DeviceAddress, btPin);

                        // Null forces legacy pin request instead of SSP authentication.

                        BluetoothSecurity.PairRequest(btItem.DeviceAddress, null);
                        

                        // Install as a HID device and allow some time for it to finish.

                        btItem.SetServiceState(BluetoothService.HumanInterfaceDevice, true);
                    }

                    // Allow slow computers to finish installation before connecting.

                    System.Threading.Thread.Sleep(4000);

                    // Connect and send a command, otherwise they sleep and the device disappears.

                    try
                    {
                        if (btDiscoveredList.Length > btIgnored)
                        {
                            var deviceCollection = new WiimoteCollection();
                            deviceCollection.FindAllWiimotes();

                            foreach (var wiiDevice in deviceCollection)
                            {
                                wiiDevice.Connect();
                                wiiDevice.SetLEDs(true, false, false, true);
                                wiiDevice.Disconnect();
                            }
                        }
                    }
                    catch (Exception) { }

                    // Status report.
                    if (btDiscoveredList.Length > 0)
                    {
                        if (btDiscoveredList.Length != 1)
                        {
                            label_Status.Text = "Paired with " + btDiscoveredList.Length + " new Balance Board";
                        }
                        else
                        {
                            label_Status.Text = "Paired with " + btDiscoveredList.Length + " new Balance Boards, unfortionately only one can be used";
                        }
                    }
                    else
                    {
                        label_Status.Text = "No new Balance Board found, are you already paired?";
                    }
                    label_Status.Refresh();
                }
            }
            catch (Exception ex)
            {
                label_Status.Text = ex.Message;
            }

            this.Enabled = true;
        }

        private string AddressToWiiPin(string bluetoothAddress)
        {
            if (bluetoothAddress.Length != 12) throw new Exception(bluetoothAddress + " is an invalid Bluetooth address");

            var bluetoothPin = "";
            for (int i = bluetoothAddress.Length - 2; i >= 0; i -= 2)
            {
                string hex = bluetoothAddress.Substring(i, 2);
                bluetoothPin += (char)Convert.ToInt32(hex, 16);
            }
            return bluetoothPin;
        }
    }
}
