using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidLibrary;

namespace JoystickMapper
{
    public partial class JoystickMapper : Form
    {
        private HidDevice[] m_deviceList;
        private HidDevice[] m_selectedDeviceList;
        public delegate void ReadHandlerDelegate(HidReport report);


        public JoystickMapper()
        {
            InitializeComponent();
        }

        private void FrmJoystickMapper_Load(object sender, EventArgs e)
        {
            RefreshDevices();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (lbDevices.SelectedIndex <= -1) return;

            var device = m_deviceList[lbDevices.SelectedIndex];

            device.OpenDevice();
            device.MonitorDeviceEvents = true;

            device.ReadReport(ReadProcess);
        }

        private void RefreshDevices()
        {
            m_deviceList = HidDevices.Enumerate().ToArray();
            //_deviceList = HidDevices.Enumerate(0x536, 0x207, 0x1c7).ToArray();
            lbDevices.DisplayMember = "Description";
            lbDevices.DataSource = m_deviceList;
            if (m_deviceList.Length > 0) m_selectedDeviceList[0] = m_deviceList[0];
        }

        private void ReadProcess(HidReport report)
        {
            BeginInvoke(new ReadHandlerDelegate(ReadHandler), new object[] { report });
        }

        private void ReadHandler(HidReport report)
        {
            //rtbReport.Clear();
            rtbReport.AppendText(String.Format("{0}{1}",  String.Join(" ", report.Data.Select(d => d.ToString("X2"))), Environment.NewLine));

            m_deviceList[lbDevices.SelectedIndex].ReadReport(ReadProcess);
        }
    }
}
