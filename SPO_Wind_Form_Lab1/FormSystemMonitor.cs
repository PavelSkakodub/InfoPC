using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;
using MetroFramework.Forms;

namespace SPO_Wind_Form_Lab1
{
    public partial class FormSystemMonitor : MetroForm
    {
        private double cpu; private double ram;
        private double installedMemory;
        public FormSystemMonitor()
        {
            InitializeComponent();
        }
        private void FormSystemMonitor_Load_1(object sender, EventArgs e)
        {
            MEMORYSTATUSEX mEMORYSTATUSEX = new MEMORYSTATUSEX();

            if (GlobalMemoryStatusEx(mEMORYSTATUSEX))
            {
                installedMemory = mEMORYSTATUSEX.ullTotalPhys;
            }
            lblEstablishedV.Text = Math.Round(installedMemory / 1073741824, 1).ToString() + " Гб";
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cpu = pcCPU.NextValue();
            ram = pcRAM.NextValue();
            pbCPU.Value = (int)cpu;
            pbRAM.Value = (int)ram;
            lblCPUValue.Text = Math.Round(cpu, 1).ToString() + " %";
            lblRAMValue.Text = Math.Round(ram, 1).ToString() + " %";
            lblUseV.Text = Math.Round((ram / 100 * installedMemory) / 1073741824, 1).ToString() + " Гб";
            lblAvalibleV.Text = Math.Round((installedMemory - ram / 100 * installedMemory) / 1073741824, 1).ToString() + " Гб";
            chartCPURAM.Series["ЦП"].Points.AddY(cpu); chartCPURAM.Series["ОЗУ"].Points.AddY(ram);
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength; public uint dwMemoryLength; public ulong ullTotalPhys; public ulong ullAvailPhys; public ulong ullTotalPageFile; public ulong ullAvailPageFile; public ulong ullTotalVirtual; public ulong ullAvailVirtual; public ulong ullAvailExtendedVirtual;

            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }
        }
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);       
    }
}
