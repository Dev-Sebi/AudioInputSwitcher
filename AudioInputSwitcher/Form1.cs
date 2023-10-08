using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace AudioInputSwitcher
{
    public partial class Form1 : Form
    {
        private bool isInput1Active = true;
        private MMDevice input1Device;
        private MMDevice input2Device;
        private MMDeviceEnumerator enumerator;

        public Form1()
        {
            InitializeComponent();
            enumerator = new MMDeviceEnumerator();
            PopulateInputDevices(inputBox1);
            PopulateInputDevices(inputBox2);
            welcome.Text = "Welcome " + Environment.UserName;
            changeInputBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Subscribe to the SelectedIndexChanged event for changeInputBox.
            changeInputBox.SelectedIndexChanged += changeInputBox_SelectedIndexChanged;

            // Subscribe to the KeyPress event for changeInputBox.
            changeInputBox.KeyPress += changeInputBox_KeyPress;

            // Set inputBox1 as the default audio input device when the form loads.
            input1Device = GetDeviceByName(inputBox1.SelectedItem as string);
            if (input1Device != null)
            {
                SetDefaultAudioInputDevice(input1Device);
            }
        }

        private void PopulateInputDevices(ComboBox comboBox)
        {
            List<string> inputDevices = new List<string>();

            foreach (var device in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                inputDevices.Add(device.FriendlyName);
            }

            comboBox.DataSource = inputDevices;

            // Set the DropDownStyle property to DropDownList to make the ComboBox non-editable.
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set the ComboBox's SelectedItem to the default audio input device's FriendlyName.
            MMDevice defaultInputDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
            if (defaultInputDevice != null)
            {
                comboBox.SelectedItem = defaultInputDevice.FriendlyName;
            }
        }


        private void changeInputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = changeInputBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedItem))
            {
                if (isInput1Active)
                {
                    input1Device = GetDeviceByName(selectedItem);
                    if (input1Device != null)
                    {
                        SetDefaultAudioInputDevice(input1Device);
                        input1Active.Visible = true;
                        input2Active.Visible = false;
                        isInput1Active = true;
                    }
                }
                else
                {
                    input2Device = GetDeviceByName(selectedItem);
                    if (input2Device != null)
                    {
                        SetDefaultAudioInputDevice(input2Device);
                        input1Active.Visible = false;
                        input2Active.Visible = true;
                        isInput1Active = false;
                    }
                }
            }
        }

        private void changeInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is the desired character.
            char selectedChar = changeInputBox.Text[0]; // Assuming the selected character is the first character.

            if (e.KeyChar == selectedChar)
            {
                // Initialize the device to the appropriate input.
                MMDevice device = isInput1Active ? input1Device : input2Device;

                // Toggle the state.
                isInput1Active = !isInput1Active;

                // Update the default audio input device.
                if (device != null)
                {
                    SetDefaultAudioInputDevice(device);
                }

                // Toggle the visibility of active text.
                input1Active.Visible = isInput1Active;
                input2Active.Visible = !isInput1Active;

                // Prevent the character from being inserted into the ComboBox.
                e.Handled = true;
            }
        }


        private MMDevice GetDeviceByName(string friendlyName)
        {
            foreach (var device in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active))
            {
                if (device.FriendlyName == friendlyName)
                {
                    return device;
                }
            }
            return null; // Device not found.
        }

        private void SetDefaultAudioInputDevice(MMDevice device)
        {
             device.AudioEndpointVolume.MasterVolumeLevelScalar = 1.0f;
        }
    }
}
