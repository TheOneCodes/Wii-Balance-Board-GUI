﻿//----------------------------------------------------------------------------------------------------------------------+
// Wii Balance Board Released by TheOneCode for all to use under Microsoft Public License.
//
//
// Based on a fork of WiiBalanceWalker Released by Richard Perry from GreyCube.com - Under the Microsoft Public License.
// (No longer available online as of 06/23/2019) https://web.archive.org/web/20171012162643/http://www.greycube.com/site/download.php?view.68
//
// Project platform set as x86 for the joystick option work as VJoy.DLL only available as native 32-bit.
//
// Uses the WiimoteLib DLL:           http://wiimotelib.codeplex.com/
// Uses the 32Feet.NET bluetooth DLL: http://32feet.codeplex.com/
// Used the VJoy joystick DLL:        http://headsoft.com.au/index.php?category=vjoy
//----------------------------------------------------------------------------------------------------------------------+

using System;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;
using VJoyLibrary;
using WiimoteLib;

namespace WiiBalanceWalker
{
    public partial class FormMain : Form
    {
        System.Timers.Timer infoUpdateTimer = new System.Timers.Timer() { Interval = 50,     Enabled = false };
        System.Timers.Timer joyResetTimer   = new System.Timers.Timer() { Interval = 240000, Enabled = false };

        ActionList actionList = new ActionList();
        Wiimote wiiDevice     = new Wiimote();
        DateTime jumpTime     = DateTime.UtcNow;
        VJoy joyDevice        = null;

        bool setCenterOffset = false;                                             

        float naCorners     = 0f;
        float oaTopLeft     = 0f;
        float oaTopRight    = 0f;
        float oaBottomLeft  = 0f;
        float oaBottomRight = 0f;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            // Setup a timer which controls the rate at which updates are processed.

            infoUpdateTimer.Elapsed += new ElapsedEventHandler(infoUpdateTimer_Elapsed);

            // Setup a timer which prevents a VJoy popup message.

            joyResetTimer.Elapsed += new ElapsedEventHandler(joyResetTimer_Elapsed);

            // Load trigger settings.

            numericUpDown_TLR.Value  = Properties.Settings.Default.TriggerLeftRight;
            numericUpDown_TFB.Value  = Properties.Settings.Default.TriggerForwardBackward;
            numericUpDown_TMLR.Value = Properties.Settings.Default.TriggerModifierLeftRight;
            numericUpDown_TMFB.Value = Properties.Settings.Default.TriggerModifierForwardBackward;

            // Link up form controls with action settings.

            actionList.Left          = new ActionItem("Left",          comboBox_AL,  numericUpDown_AL);
            actionList.Right         = new ActionItem("Right",         comboBox_AR,  numericUpDown_AR);
            actionList.Forward       = new ActionItem("Forward",       comboBox_AF,  numericUpDown_AF);
            actionList.Backward      = new ActionItem("Backward",      comboBox_AB,  numericUpDown_AB);
            actionList.Modifier      = new ActionItem("Modifier",      comboBox_AM,  numericUpDown_AM);
            actionList.Jump          = new ActionItem("Jump",          comboBox_AJ,  numericUpDown_AJ);
            actionList.DiagonalLeft  = new ActionItem("DiagonalLeft",  comboBox_ADL, numericUpDown_ADL);
            actionList.DiagonalRight = new ActionItem("DiagonalRight", comboBox_ADR, numericUpDown_ADR);

            // Load joystick preference.

            checkBox_EnableJoystick.Checked = Properties.Settings.Default.EnableJoystick;

            //Load Checkstate
            checkBox_DisableActions.Checked = Properties.Settings.Default.Disable;
            disableToolStripMenuItem.Checked = checkBox_DisableActions.Checked;
            disableToolStripMenuItem.Checked = Properties.Settings.Default.Disable;
        }

        private void numericUpDown_TLR_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TriggerLeftRight = (int)numericUpDown_TLR.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown_TFB_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TriggerForwardBackward = (int)numericUpDown_TFB.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown_TMLR_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TriggerModifierLeftRight = (int)numericUpDown_TMLR.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDown_TMFB_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TriggerModifierForwardBackward = (int)numericUpDown_TMFB.Value;
            Properties.Settings.Default.Save();
        }

        private void button_SetCenterOffset_Click(object sender, EventArgs e)
        {
            setCenterOffset = true;
            tray.BalloonTipTitle = "Center Ballance";
            tray.BalloonTipText = "Ballance has been zeroed";
            tray.ShowBalloonTip(1000);
        }

        private void button_ResetDefaults_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            tray.BalloonTipTitle = "Reset";
            tray.BalloonTipText = "Configuration has been reset to Default";
            tray.ShowBalloonTip(1000);
            this.Close();
        }

        private void button_BluetoothAddDevice_Click(object sender, EventArgs e)
        {
            var form = new FormBluetooth();
            form.ShowDialog(this);
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                // Find all connected Wii devices.

                var deviceCollection = new WiimoteCollection();
                deviceCollection.FindAllWiimotes();

                for (int i = 0; i < deviceCollection.Count; i++)
                {
                    wiiDevice = deviceCollection[i];

                    // Device type can only be found after connection, so prompt for multiple devices.

                    if (deviceCollection.Count > 1)
                    {
                        var devicePathId = new Regex("e_pid&.*?&(.*?)&").Match(wiiDevice.HIDDevicePath).Groups[1].Value.ToUpper();

                        var response = MessageBox.Show("Connect to HID " + devicePathId + " device " + (i + 1) + " of " + deviceCollection.Count + " ?", "Multiple Wii Devices Found", MessageBoxButtons.YesNoCancel);
                        if (response == DialogResult.Cancel) return;
                        if (response == DialogResult.No) continue;
                    }

                    // Setup update handlers.

                    wiiDevice.WiimoteChanged          += wiiDevice_WiimoteChanged;
                    wiiDevice.WiimoteExtensionChanged += wiiDevice_WiimoteExtensionChanged;

                    // Connect and send a request to verify it worked.

                    wiiDevice.Connect();
                    wiiDevice.SetReportType(InputReport.IRAccel, false); // FALSE = DEVICE ONLY SENDS UPDATES WHEN VALUES CHANGE!
                    wiiDevice.SetLEDs(true, false, false, false);

                    // Enable processing of updates.

                    infoUpdateTimer.Enabled = true;

                    // Prevent connect being pressed more than once.

                    button_Connect.Enabled = false;
                    button_BluetoothAddDevice.Enabled = false;
                    connectBoardToolStripMenuItem.Enabled = false;
                    pairBluetoothDevicesToolStripMenuItem.Enabled = false;
                    if (checkBox_DisableActions.Checked == false)
                    {
                        tray.BalloonTipTitle = "Ready";
                        tray.BalloonTipText = "Double click the tray icon to configure";
                        tray.ShowBalloonTip(5000);
                        WindowState = FormWindowState.Minimized;
                    }
                    break;
                }
            }
            catch (Exception ex)
            {
                tray.BalloonTipTitle = "Error";
                tray.BalloonTipText = ex.Message;
                tray.ShowBalloonTip(5000);
            }
        }

        private void wiiDevice_WiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            // Called every time there is a sensor update, values available using e.WiimoteState.
            // Use this for tracking and filtering rapid accelerometer and gyroscope sensor data.
            // The balance board values are basic, so can be accessed directly only when needed.
        }

        private void wiiDevice_WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs e)
        {
            // This is not needed for balance boards.
        }

        void infoUpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Pass event onto the form GUI thread.

            this.BeginInvoke(new Action(() => InfoUpdate()));
        }

        private void InfoUpdate()
        {
            if (wiiDevice.WiimoteState.ExtensionType != ExtensionType.BalanceBoard)
            {
                label_Status.Text = "DEVICE IS NOT A BALANCE BOARD";
                tray.BalloonTipTitle = "Error";
                tray.BalloonTipText = "Device is not a Wii Balance Board";
                tray.ShowBalloonTip(5000);
                return;
            }

            #region Nerdy maths
            // Get the current raw sensor KG values.

            var rwWeight      = wiiDevice.WiimoteState.BalanceBoardState.WeightKg;

            var rwTopLeft     = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopLeft;
            var rwTopRight    = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopRight;
            var rwBottomLeft  = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomLeft;
            var rwBottomRight = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomRight;
                        
            // Prevent negative values by tracking lowest possible value and making it a zero based offset.

            if (rwTopLeft     < naCorners) naCorners = rwTopLeft;
            if (rwTopRight    < naCorners) naCorners = rwTopRight;
            if (rwBottomLeft  < naCorners) naCorners = rwBottomLeft;
            if (rwBottomRight < naCorners) naCorners = rwBottomRight;

            // Negative total weight is reset to zero as jumping or lifting the board causes negative spikes, which would break 'in use' checks.

            var owWeight      = rwWeight < 0f ? 0f : rwWeight;

            var owTopLeft     = rwTopLeft     -= naCorners;
            var owTopRight    = rwTopRight    -= naCorners;
            var owBottomLeft  = rwBottomLeft  -= naCorners;
            var owBottomRight = rwBottomRight -= naCorners;

            // Get offset that would make current values the center of mass.

            if (setCenterOffset)
            {
                setCenterOffset = false;

                var rwHighest = Math.Max(Math.Max(rwTopLeft, rwTopRight), Math.Max(rwBottomLeft, rwBottomRight));

                oaTopLeft     = rwHighest - rwTopLeft;
                oaTopRight    = rwHighest - rwTopRight;
                oaBottomLeft  = rwHighest - rwBottomLeft;
                oaBottomRight = rwHighest - rwBottomRight;
            }

            // Keep values only when board is being used, otherwise offsets and small value jitters can trigger unwanted actions.

            if (owWeight > 0f)
            {
                owTopLeft     += oaTopLeft;
                owTopRight    += oaTopRight;
                owBottomLeft  += oaBottomLeft;
                owBottomRight += oaBottomRight;
            }
            else
            {
                owTopLeft     = 0;
                owTopRight    = 0;
                owBottomLeft  = 0;
                owBottomRight = 0;
            }

            // Calculate each weight ratio.

            var owrPercentage  = 100 / (owTopLeft + owTopRight + owBottomLeft + owBottomRight);
            var owrTopLeft     = owrPercentage * owTopLeft;
            var owrTopRight    = owrPercentage * owTopRight;
            var owrBottomLeft  = owrPercentage * owBottomLeft;
            var owrBottomRight = owrPercentage * owBottomRight;
            
            // Calculate balance ratio.

            var brX = owrBottomRight + owrTopRight;
            var brY = owrBottomRight + owrBottomLeft;

            if (panel_Config.Visible)
            {
                
            }

            // Diagonal ratio used for turning on the spot.

            var brDL = owrPercentage * (owBottomLeft + owTopRight);
            var brDR = owrPercentage * (owBottomRight + owTopLeft);
            var brDF = Math.Abs(brDL - brDR);
            
            // Convert sensor values into actions.

            var sendLeft          = false;
            var sendRight         = false;
            var sendForward       = false;
            var sendBackward      = false;
            var sendModifier      = false;
            var sendJump          = false;
            var sendDiagonalLeft  = false;
            var sendDiagonalRight = false;

            if (brX < (float)(50 - numericUpDown_TLR.Value)) sendLeft     = true;
            if (brX > (float)(50 + numericUpDown_TLR.Value)) sendRight    = true;
            if (brY < (float)(50 - numericUpDown_TFB.Value)) sendForward  = true;
            if (brY > (float)(50 + numericUpDown_TFB.Value)) sendBackward = true;

            if      (brX < (float)(50 - numericUpDown_TMLR.Value)) sendModifier = true;
            else if (brX > (float)(50 + numericUpDown_TMLR.Value)) sendModifier = true;
            else if (brY < (float)(50 - numericUpDown_TMFB.Value)) sendModifier = true;
            else if (brY > (float)(50 + numericUpDown_TMFB.Value)) sendModifier = true;

            // Detect jump but use a time limit to stop it being active while off the board.

            if (owWeight < 1f)
            {
                if (DateTime.UtcNow.Subtract(jumpTime).Seconds < 2) sendJump = true;
            }
            else
            {
                jumpTime = DateTime.UtcNow;
            }

            // Check for diagonal pressure only when no other movement actions are active.

            if (!sendLeft && !sendRight && !sendForward && !sendBackward && brDF > 15)
            {
                if (brDL > brDR) sendDiagonalLeft  = true;
                else             sendDiagonalRight = true;
            }
            
            // Send actions.

            if (!checkBox_DisableActions.Checked)
            {
                if (sendLeft) actionList.Left.Start(); else actionList.Left.Stop();
                if (sendRight) actionList.Right.Start(); else actionList.Right.Stop();
                if (sendForward) actionList.Forward.Start(); else actionList.Forward.Stop();
                if (sendBackward) actionList.Backward.Start(); else actionList.Backward.Stop();
                if (sendModifier) actionList.Modifier.Start(); else actionList.Modifier.Stop();
                if (sendJump) actionList.Jump.Start(); else actionList.Jump.Stop();
                if (sendDiagonalLeft) actionList.DiagonalLeft.Start(); else actionList.DiagonalLeft.Stop();
                if (sendDiagonalRight) actionList.DiagonalRight.Start(); else actionList.DiagonalRight.Stop();
            }

            // Update joystick emulator.

            if (checkBox_EnableJoystick.Checked)
            {
                // Uses Int16 ( -32767 to +32767 ) where 0 is the center. Multiplied by 2 because realistic usage is between the 30-70% ratio.

                var joyX = (brX * 655.34 + -32767.0) * 2.0;
                var joyY = (brY * 655.34 + -32767.0) * 2.0;

                // Limit values to Int16, you cannot just (cast) or Convert.ToIn16() as the value '+ - sign' may invert.

                if (joyX < short.MinValue) joyX = short.MinValue;
                if (joyY < short.MinValue) joyY = short.MinValue;

                if (joyX > short.MaxValue) joyX = short.MaxValue;
                if (joyY > short.MaxValue) joyY = short.MaxValue;

                // Set new values.

                joyDevice.SetXAxis(0, (short)joyX);
                joyDevice.SetYAxis(0, (short)joyY);
                joyDevice.Update(0);
            }

            #endregion Nerdy Maths

            if (panel_Config.Visible)
            {
                //Show raw weight in kilogrammes
                label_rwWT.Text = rwWeight.ToString("0.0") + "kg";
                label_rwTL.Text = rwTopLeft.ToString("0.0") + "kg";
                label_rwTR.Text = rwTopRight.ToString("0.0") + "kg";
                label_rwBL.Text = rwBottomLeft.ToString("0.0") + "kg";
                label_rwBR.Text = rwBottomRight.ToString("0.0") + "kg";

                //Display Offset values
                label_owWT.Text = owWeight.ToString("0.0");
                label_owTL.Text = owTopLeft.ToString("0.0") + "\r\n" + oaTopLeft.ToString("0.0");
                label_owTR.Text = owTopRight.ToString("0.0") + "\r\n" + oaTopRight.ToString("0.0");
                label_owBL.Text = owBottomLeft.ToString("0.0") + "\r\n" + oaBottomLeft.ToString("0.0");
                label_owBR.Text = owBottomRight.ToString("0.0") + "\r\n" + oaBottomRight.ToString("0.0");

                //Display weight ratio
                label_owrTL.Text = owrTopLeft.ToString("0.0");
                label_owrTR.Text = owrTopRight.ToString("0.0");
                label_owrBL.Text = owrBottomLeft.ToString("0.0");
                label_owrBR.Text = owrBottomRight.ToString("0.0");
                
                //Display balance
                label_brX.Text = brX.ToString("0.0");
                label_brY.Text = brY.ToString("0.0");

                //Show Diagonal ratios
                label_brDL.Text = brDL.ToString("0.0");
                label_brDR.Text = brDR.ToString("0.0");
                label_brDF.Text = brDF.ToString("0.0");

                //Display Output
                label_Status.Text = "Result: ";

                if (sendForward) label_Status.Text += "Forward";
                if (sendLeft) label_Status.Text += "Left";
                if (sendBackward) label_Status.Text += "Backward";
                if (sendRight) label_Status.Text += "Right";
                if (sendModifier) label_Status.Text += " + Modifier";
                if (sendJump) label_Status.Text += "Jump";
                if (sendDiagonalLeft) label_Status.Text += "Diagonal Left";
                if (sendDiagonalRight) label_Status.Text += "Diagonal Right";

                if (checkBox_DisableActions.Checked) label_Status.Text += " (DISABLED)";
            }

            //Change the icon color when Outputting
            if (sendForward | sendLeft | sendBackward | sendRight | sendDiagonalLeft | sendDiagonalRight)
            {
                Icon = Properties.Resources.Balance_Board_Green;
                tray.Icon = Properties.Resources.Balance_Board_Green;
            }
            else
            {
                Icon = Properties.Resources.Balance_Board;
                tray.Icon = Properties.Resources.Balance_Board;
            }
            
        }

        private void checkBox_EnableJoystick_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                joyDevice = new VJoy();
                joyDevice.Initialize();
                joyDevice.Reset();
                joyDevice.Update(0);
            }
            catch (Exception ex)
            {
                // VJoy.DLL missing from .EXE folder or project built as 'Any CPU' and DLL is 32-bit only.

                infoUpdateTimer.Enabled = false;
                tray.BalloonTipTitle = "VJoy Error";
                checkBox_EnableJoystick.Checked = false;
                tray.BalloonTipText = ex.Message;
                tray.ShowBalloonTip(5000);

            }

            joyResetTimer.Enabled = true;

            // Show reminder ( if not being changed by load settings ) and save settings.

            var isChecked = checkBox_EnableJoystick.Checked;
            if (isChecked)
            {
                if (Properties.Settings.Default.EnableJoystick == false)
                {
                    tray.BalloonTipTitle = "Reminder";
                    tray.BalloonTipText = "Actions still apply! Set 'Do Nothing' for any movement conflicts.\r\n\r\nRequires Headsoft VJoy driver to be installed.";
                    tray.ShowBalloonTip(5000);
                }
            }
            
            // Start joystick emulator.

            Properties.Settings.Default.EnableJoystick = checkBox_DisableActions.Checked;
            Properties.Settings.Default.Save();
        }

        void joyResetTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            joyDevice.Initialize();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop updates.

            infoUpdateTimer.Enabled = false;
            wiiDevice.Disconnect();

            // Prevent 'stuck' down keys from closing while doing an action.

            actionList.Left.Stop();
            actionList.Right.Stop();
            actionList.Forward.Stop();
            actionList.Backward.Stop();
            actionList.Modifier.Stop();
            actionList.Jump.Stop();
            actionList.DiagonalLeft.Stop();
            actionList.DiagonalRight.Stop();
        }

        private void LinkLabel_Show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (panel_Config.Visible)
            {
                panel_Config.Visible = false;
                Size = new System.Drawing.Size(302, 216);
                linkLabel_Show.Text = "Configure";

            }
            else
            {
                panel_Config.Visible = true;
                Size = new System.Drawing.Size(573, 463);
                linkLabel_Show.Text = "Hide Configure";

            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                tray.BalloonTipTitle = "Minimised to system tray";
                tray.BalloonTipText = "Wii Balance Board is working in the background, double click this icon to configure.";
                tray.ShowBalloonTip(1000);
            }
        }

        private void Tray_MouseDoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            panel_Config.Visible = true;
            Size = new System.Drawing.Size(573, 463);
            linkLabel_Show.Text = "Hide Configure";
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox_DisableActions.Checked)
            {
                checkBox_DisableActions.Checked = false;
                disableToolStripMenuItem.Checked = false;
            }
            else
            {
                checkBox_DisableActions.Checked = true;
                disableToolStripMenuItem.Checked = true;
            }
            Properties.Settings.Default.Disable = checkBox_DisableActions.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckBox_DisableActions_CheckedChanged(object sender, EventArgs e)
        {
            disableToolStripMenuItem.Checked = checkBox_DisableActions.Checked;
            Properties.Settings.Default.Disable = checkBox_DisableActions.Checked;
            Properties.Settings.Default.Save();
        }

        private void JoystickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (joystickToolStripMenuItem.Checked)
            {
                joystickToolStripMenuItem.Checked = false;
                checkBox_EnableJoystick.Checked = false;
            }
            else
            {
                joystickToolStripMenuItem.Checked = true;
                checkBox_EnableJoystick.Checked = true;
            }
            checkBox_EnableJoystick_CheckedChanged(sender, e);
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showAboutDialog(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.Show();
        }

        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void checkLicense(object sender, EventArgs e)
        {
            button_Connect_Click(sender, e);
        }
    }
}
