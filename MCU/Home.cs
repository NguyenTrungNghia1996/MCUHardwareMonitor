﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using LibreHardwareMonitor.Hardware;

namespace MCU
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        readonly private Computer thisComputer = new Computer();
        public TcpClient client = new TcpClient();
        NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
        string cpuName = "", gpuName = "", strNw = "";
        float cpuLoad = 0, cpuTemp = 0;
        float gpuLoad = 0, gpuTemp = 0, gpuFan = 0, gpuFanLoad = 0;
        float ramLoad = 0, ramUse = 0, totalRam = 0;
        float vmLoad = 0, vmUse = 0, vmTotal = 0;
        float upload = 0, download = 0;
        public Home()
        {

            InitializeComponent();
            timer.Interval = 1000;
            timer.Start();

            AddMenu();
            this.thisComputer.IsCpuEnabled = true;
            this.thisComputer.IsGpuEnabled = true;
            this.thisComputer.IsStorageEnabled = true;
            this.thisComputer.IsMotherboardEnabled = true;
            this.thisComputer.IsMemoryEnabled = true;
            this.thisComputer.IsNetworkEnabled = true;
            this.thisComputer.IsControllerEnabled = true;
            this.thisComputer.Open();
            /*AUTO*/
            if (ConfigurationManager.AppSettings["autoConnectWifi"].ToString().ToLower().Equals("true"))
            {
                swWifiAuto.Value = true;
            }
            else
            {
                swWifiAuto.Value = false;
            }
            if (ConfigurationManager.AppSettings["autoConnectWired"].ToString().ToLower().Equals("true"))
            {
                swWiredAuto.Value = true;
            }
            else
            {
                swWiredAuto.Value = false;
            }
            if (ConfigurationManager.AppSettings["state"].ToString().ToLower().Equals("true"))
            {
                base.WindowState = FormWindowState.Minimized;
                base.ShowInTaskbar = false;
                checkBox2.Checked = true;
            }
            else
            {
                base.WindowState = FormWindowState.Normal;
                base.ShowInTaskbar = true;
                checkBox2.Checked = false;
            }
            /*WIRED*/
            serialPort1.BaudRate = 115200;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Handshake = Handshake.None;
            serialPort1.RtsEnable = true;
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbbCom.Items.Add(port);
            }
            cbbCom.SelectedIndex = cbbCom.Items.IndexOf(ConfigurationManager.AppSettings["port"].ToString());
            if (swWiredAuto.Value == true)
            {
                if (cbbCom.Text != "")
                {
                    try
                    {
                        serialPort1.PortName = cbbCom.Text;
                        if (!serialPort1.IsOpen)
                        {
                            serialPort1.Open();
                            btnWired.Text = "Disconnect";
                            btnWired.ForeColor = Color.Red;
                            lblStatusWired.Text = "Connected";
                            lblStatusWired.ForeColor = Color.Green;
                            AppIcon.ShowBalloonTip(5000, "Kết nối thành công ", "Connection Successful", ToolTipIcon.Info);
                        }
                    }
                    catch
                    {
                        AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy Port", ToolTipIcon.Warning);
                        lblStatusWired.Text = "Disconnected";
                        lblStatusWired.ForeColor = Color.Red;
                    }
                }

            }
            /*WIFI*/
            string ip = ConfigurationManager.AppSettings["ip"].ToString();
            if (ip != "")
            {
                txtIP.Text = ip;
            }
            if (swWifiAuto.Value == true)
            {
                if (ip == "")
                {
                    AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không có địa chỉ IP để kết nối\r\nYêu cầu nhập địa chỉ IP của server", ToolTipIcon.Warning);
                }
                else
                {
                    client.ConnectAsync(ip, 80).Wait(3000);
                    if (client.Connected)
                    {
                        txtIP.Enabled = false;
                        btnConnectWIFI.Text = "Disconnect";
                        //btnConnectWIFI.BackColor = Color.Red;
                        lblStatusWifi.Text = "Connected";
                        lblStatusWifi.ForeColor = Color.Green;
                        AppIcon.ShowBalloonTip(5000, "Kết nối thành công ", "Connection Successful", ToolTipIcon.Info);
                    }
                    else
                    {
                        AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy server", ToolTipIcon.Warning);
                        client.Close();
                        lblStatusWifi.Text = "Disconnected";
                        lblStatusWifi.ForeColor = Color.Red;
                        client = new TcpClient();
                    }
                }
            }



        }
        private void AddMenu()
        {
            this.AppIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.AppIcon.ContextMenuStrip.Items.Add("Connect", null, this.OpenConnectForm);
            this.AppIcon.ContextMenuStrip.Items.Add("About", null, this.OpenAboutForm);
            this.AppIcon.ContextMenuStrip.Items.Add("Exit", null, this.Exit);
        }
        private void OpenConnectForm(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Normal;  // Mở cửa sổ Connect
            base.ShowInTaskbar = true;
            base.Visible = false;
            //base.Activate();
            base.Focus();
            base.Show();
        }

        private void OpenAboutForm(object sender, EventArgs e)      // Mở cửa sổ About
        {
            new About().Show();
        }
        private void Exit(object sender, EventArgs e)               // Thoát chương trình
        {
            Application.Exit();
            AppIcon.Dispose();
        }
        public class Infomation
        {
            public Processor CPU { get; set; }

            public Graphic GPU { get; set; }
            public Ram RAM { get; set; }
            public Net Net { get; set; }
        }

        public class Processor
        {
            public string Name { get; set; }
            public double Load { get; set; }
            public double Temp { get; set; }
        }

        public class Graphic
        {
            public string Name { get; set; }
            public double Load { get; set; }
            public double Temp { get; set; }
            public double Fan { get; set; }
            public double FanLoad { get; set; }
        }
        public class Ram
        {
            public double Total { get; set; }
            public double Use { get; set; }
            public double Load { get; set; }
        }
        public class Net
        {
            public string net { get; set; }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //string v = thisComputer.Hardware[5].HardwareType
            /*-------------------------------------Read Info-------------------------------------*/
            foreach (var hardware in thisComputer.Hardware)
            {
                hardware.Update();
                /*---------------------------------CPU---------------------------------*/
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    cpuName = hardware.Name;
                    lblCPUName.Text = cpuName;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            cpuLoad = sensor.Value.Value;
                            psCPULoad.Value = (int)Math.Round(cpuLoad);
                            lblCPULoad.Text = Math.Round(cpuLoad).ToString();
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Package")
                        {
                            cpuTemp = sensor.Value.GetValueOrDefault();
                            psCPUTemp.Value = (int)Math.Round(cpuTemp);
                            lblCpuTemp.Text = Math.Round(cpuTemp).ToString();
                        }
                    }
                }
                /*---------------------------------GPU---------------------------------*/
                if (hardware.HardwareType == HardwareType.GpuAmd || hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    gpuName = hardware.Name;
                    lblGPUName.Text = gpuName;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "GPU Core")
                        {
                            gpuLoad = sensor.Value.Value;
                            psGPULoad.Value = (int)Math.Round(gpuLoad);
                            lblGPULoad.Text = Math.Round(gpuLoad).ToString();
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "GPU Core")
                        {
                            gpuTemp = sensor.Value.GetValueOrDefault();
                            psGPUTemp.Value = (int)Math.Round(gpuTemp);
                            lblGPUTemp.Text = gpuTemp.ToString();
                        }
                        if (sensor.SensorType == SensorType.Fan && sensor.Name == "GPU Fan")
                        {
                            gpuFan = sensor.Value.GetValueOrDefault();
                            lblGPUFan.Text = Math.Round(gpuFan).ToString();
                        }
                        if (sensor.SensorType == SensorType.Control && sensor.Name == "GPU Fan")
                        {
                            gpuFanLoad = sensor.Value.GetValueOrDefault();
                            psGPUFanLoad.Value = (int)Math.Round(gpuFanLoad);
                        }

                    }

                }
                /*---------------------------------RAM---------------------------------*/
                if (hardware.HardwareType == HardwareType.Memory)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "Memory")
                        {
                            ramLoad = sensor.Value.Value;
                            psRamLoad.Value = (int)Math.Round(ramLoad);
                            lblRamLoad.Text = Math.Round(ramLoad).ToString();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Memory Used")
                        {
                            ramUse = sensor.Value.GetValueOrDefault();
                            lblRamUse.Text = Math.Round(ramUse, 2).ToString();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Memory Available")
                        {
                            float ramAva = sensor.Value.GetValueOrDefault();
                            lblRamFree.Text = Math.Round(ramAva, 2).ToString();
                            totalRam = ramAva + ramUse;
                            lblRamTotal.Text = Math.Round(totalRam).ToString() + " GB";
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "Virtual Memory")
                        {
                            vmLoad = sensor.Value.Value;
                            psVm.Value = (int)Math.Round(vmLoad);
                            lblVmLoad.Text = Math.Round(vmLoad).ToString();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Virtual Memory Used")
                        {
                            vmUse = sensor.Value.GetValueOrDefault();
                            lblVmUsed.Text = Math.Round(vmUse, 2).ToString();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Virtual Memory Available")
                        {
                            var vm = sensor.Value.GetValueOrDefault();
                            lblVmFree.Text = Math.Round(vm, 2).ToString();
                            vmTotal = vm + vmUse;
                            lblVmTotal.Text = Math.Round(vmTotal).ToString() + " GB";
                        }
                    }
                }

                if (hardware.Name == "Samsung SSD 960 EVO 250GB") {
                    string name = hardware.Name;
                }
                if (hardware.HardwareType == HardwareType.Network)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Throughput && sensor.Name == "Upload Speed")
                        {
                            upload = (sensor.Value.GetValueOrDefault()) * 8 / 1048576;
                        }
                        if (sensor.SensorType == SensorType.Throughput && sensor.Name == "Download Speed")
                        {
                            download = (sensor.Value.GetValueOrDefault()) * 8 / 1048576;
                        }
                        strNw = Math.Round(download, 2).ToString("F2") + "/" + Math.Round(upload, 2).ToString("F2");
                        if (strNw.Length > 10)
                        {
                            strNw = "Connecting...";
                        }
                        else
                        {
                            lblNet.Text = strNw + " Mbps";
                        }
                    }
                }

            }
            Processor dataCPU = new Processor
            {
                Name = cpuName,
                Load = Math.Round(cpuLoad, 1),
                Temp = Math.Round(cpuTemp, 1)
            };
            Graphic dataGPU = new Graphic
            {
                Name = gpuName,
                Load = Math.Round(gpuLoad, 1),
                Temp = Math.Round(gpuTemp, 1),
                FanLoad = Math.Round(gpuFan, 1),
                Fan = Math.Round(gpuFanLoad, 1)
            };
            Ram dataRam = new Ram
            {
                Total = Math.Round(totalRam),
                Use = Math.Round(ramUse, 1),
                Load = Math.Round(ramLoad, 1)
            };
            Net dataNet = new Net
            {
                net = strNw
            };
            Infomation info = new Infomation
            {
                CPU = dataCPU,
                GPU = dataGPU,
                RAM = dataRam,
                Net = dataNet
            };
            string obj = JsonConvert.SerializeObject(info);
            /*---------------------------------Send DATA---------------------------------*/
            if (lblStatusWifi.Text == "Connected")
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = Encoding.ASCII.GetBytes(obj + "\r\n");
                    stream.Write(data, 0, data.Length);
                }
                catch (Exception)
                {
                    AppIcon.ShowBalloonTip(5000, "Mất kêt nối", "Kiểm tra lại server", ToolTipIcon.Warning);
                    txtIP.Enabled = true;
                    timer.Enabled = false;
                    btnConnectWIFI.Text = "Connect";
                    lblStatusWifi.Text = "Disconnected";
                    lblStatusWifi.ForeColor = Color.Red;
                    client.Close();
                    client.Close();
                    client = new TcpClient();
                }
            }
            if (lblStatusWired.Text == "Connected")
            {
                byte[] data = Encoding.ASCII.GetBytes(obj + "\r\n");
                serialPort1.Write(obj + "\r\n");
            }
        }
        private void btnConnectWIFI_Click(object sender, EventArgs e)
        {
            if (btnConnectWIFI.Text == "Connect")
            {
                lblStatusWifi.Text = "Connecting...";
                lblStatusWifi.ForeColor = Color.Black;
                btnConnectWIFI.Enabled = false;

                try
                {
                    client.ConnectAsync(txtIP.Text, 80).Wait(5000);
                }
                catch
                {
                    AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Địa Chỉ IP không đúng !!", ToolTipIcon.Warning);
                    lblStatusWifi.Text = "Disconnected";
                    lblStatusWifi.ForeColor = Color.Red;
                }
                if (client.Connected)
                {
                    txtIP.Enabled = false;
                    btnConnectWIFI.Text = "Disconnect";
                    btnConnectWIFI.ForeColor = Color.Red;
                    lblStatusWifi.Text = "Connected";
                    lblStatusWifi.ForeColor = Color.Green;
                    AppIcon.ShowBalloonTip(5000, "Kết nối thành công ", "Connection Successful", ToolTipIcon.Info);
                    Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    _config.AppSettings.Settings["ip"].Value = txtIP.Text;
                    _config.Save();
                }
                else
                {
                    AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy server", ToolTipIcon.Warning);
                    lblStatusWifi.Text = "Disconnect";
                    lblStatusWifi.ForeColor = Color.Red;
                    client.Close();
                    client = new TcpClient();
                }
            }
            else
            {
                txtIP.Enabled = true;
                btnConnectWIFI.Text = "Connect";
                lblStatusWifi.Text = "Disconnect";
                lblStatusWifi.ForeColor = Color.Red;
                client.Close();
                client = new TcpClient();
            }
            btnConnectWIFI.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cbbCom.DataSource = SerialPort.GetPortNames();
        }

        private void AppIcon_DoubleClick(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Normal;
            base.ShowInTaskbar = true;
            base.Visible = false;
            base.Focus();
            base.Show();
        }

        private void btnWired_Click(object sender, EventArgs e)
        {
            try
            {

                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cbbCom.Text;
                    Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    _config.AppSettings.Settings["port"].Value = cbbCom.Text;
                    _config.Save();
                    serialPort1.Open();
                    btnWired.Text = "Disconnect";
                    btnWired.ForeColor = Color.Red;
                    lblStatusWired.Text = "Connected";
                    lblStatusWired.ForeColor = Color.Green;
                    AppIcon.ShowBalloonTip(5000, "Kết nối thành công ", "Connection Successful", ToolTipIcon.Info);
                }
                else
                {
                    serialPort1.Close();
                    btnWired.Text = "Connect";
                    btnWired.ForeColor = Color.Green;
                    lblStatusWired.Text = "Disconnect";
                    lblStatusWired.ForeColor = Color.Red;
                    AppIcon.ShowBalloonTip(5000, "Đã ngắt kết nối ", "Disconnected", ToolTipIcon.Warning);
                }
            }
            catch
            {
                AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy PORT", ToolTipIcon.Warning);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings["state"].Value = checkBox2.Checked.ToString();
            _config.Save();
            if (checkBox2.Checked)
            {
                AppIcon.ShowBalloonTip(500, "Sẽ chạy thu nhỏ ", "Will run minimized", ToolTipIcon.Info);
            }
            else
            {
                AppIcon.ShowBalloonTip(500, "Sẽ không chạy thu nhỏ ", "Will not run minimized", ToolTipIcon.Info);
            }
        }

        private void swWifiAuto_Click(object sender, EventArgs e)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings["autoConnectWifi"].Value = swWifiAuto.Value.ToString();
            _config.Save();
        }

        private void swWiredAuto_Click(object sender, EventArgs e)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings["autoConnectWired"].Value = swWiredAuto.Value.ToString();
            _config.Save();
        }
        private void Home_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                base.ShowInTaskbar = false;
                base.Visible = true;
                AppIcon.ShowBalloonTip(500, "Đang Chạy Thu Nhỏ !", "Minimize to tray!", ToolTipIcon.Info);
            }
            else
            {
                //this.Visible = true;
                //this.Show();
                // this.WindowState = FormWindowState.Normal;
                //this.Activate();
                // this.Focus();
                //this.ShowInTaskbar = true;
                base.WindowState = FormWindowState.Normal;
                base.ShowInTaskbar = true;
                base.Visible = false;
                base.Focus();
                base.Show();
            }
        }
    }
}
