using System;
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
        long byteRec, byteSent, oldRec, oldSent;
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
            if (ConfigurationManager.AppSettings["startTray"].ToString().ToLower().Equals("true"))
            {
               checkBox1.Checked = true;
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
            serialPort1.BaudRate = 9600;
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
            public Ram RAM { get; set; }
            public Graphic GPU { get; set; }
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
            string cpuName = "", gpuName = "";
            float cpuLoad = 0, cpuTemp = 0;
            float gpuLoad = 0, gpuTemp = 0, gpuFan = 0, gpuFanLoad = 0;
            float ramLoad = 0, ramUse = 0, totalRam = 0, x, y;

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
                            int load = (int)cpuLoad;
                            psCPULoad.Value = load;
                            lblCPULoad.Text = load.ToString();
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Package")
                        {
                            cpuTemp = sensor.Value.GetValueOrDefault();
                            int temp = (int)cpuTemp;
                            psCPUTemp.Value = temp;
                            lblCpuTemp.Text = temp.ToString();
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
                            int load = (int)ramLoad;
                            psRamLoad.Value = load;
                            lblRamLoad.Text = load.ToString();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Memory Used")
                        {
                            ramUse = sensor.Value.GetValueOrDefault();
                            double ram = Math.Round(ramUse, 2);
                            lblRamUse.Text = ram.ToString();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Memory Available")
                        {
                            float ramAva = sensor.Value.GetValueOrDefault();
                            totalRam = ramAva + ramUse;
                            double ram = Math.Round(totalRam);
                            lblRamTotal.Text = ram.ToString() + " GB";
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
                            int load = (int)gpuLoad;
                            psGPULoad.Value = load;
                            lblGPULoad.Text = load.ToString();
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "GPU Core")
                        {
                            gpuTemp = sensor.Value.GetValueOrDefault();
                            psGPUTemp.Value = (int)gpuTemp;
                            lblGPUTemp.Text = gpuTemp.ToString();
                        }
                        if (sensor.SensorType == SensorType.Fan && sensor.Name == "GPU Fan")
                        {
                            gpuFan = sensor.Value.GetValueOrDefault();
                            lblGPUFan.Text = ((int)gpuFan).ToString();
                        }
                        if (sensor.SensorType == SensorType.Control && sensor.Name == "GPU Fan")
                        {
                            gpuFanLoad = sensor.Value.GetValueOrDefault();
                            int fanLoad = (int)gpuFanLoad;
                            psGPUFanLoad.Value = fanLoad;
                        }

                    }
                }
            }
            foreach (NetworkInterface inf in interfaces)
            {
                if (inf.OperationalStatus == OperationalStatus.Up &&
                    inf.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                    inf.NetworkInterfaceType != NetworkInterfaceType.Tunnel &&
                    inf.NetworkInterfaceType != NetworkInterfaceType.Unknown && !inf.IsReceiveOnly)
                {
                    byteRec = inf.GetIPv4Statistics().BytesReceived;
                    byteSent = inf.GetIPv4Statistics().BytesSent;
                }
            }
            x = byteRec - oldRec;
            y = byteSent - oldSent;
            oldRec = byteRec;
            oldSent = byteSent;
            string strNw = (x / 1048576).ToString("F2") + "/" + (y / 1048576).ToString("F2");
            if (strNw.Length > 10)
            {
                strNw = "Connecting...";
            }
            else
            {
                lblNet.Text = strNw + " Mb/s";
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
                serialPort1.Write(obj);
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
            base.WindowState = FormWindowState.Normal;  // Mở cửa sổ Connect
            base.ShowInTaskbar = true;
            base.Visible = false;
            base.Show();
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                this.Hide();
                AppIcon.ShowBalloonTip(500, "Đang Chạy Thu Nhỏ !", "Minimize to tray!", ToolTipIcon.Info);
            }
            else
            {
                //this.Visible = true;
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                this.Focus();
                this.ShowInTaskbar = true;
            }
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
                AppIcon.ShowBalloonTip(5000, "Lỗi kêt nối", "Không tìm thấy COM", ToolTipIcon.Warning);
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings["startTray"].Value = checkBox1.Checked.ToString();
            _config.Save();
            if (checkBox1.Checked)
            {
                AppIcon.ShowBalloonTip(500, "Sẽ chạy cùng Windows ", "Will run with Windows", ToolTipIcon.Info);
            }
            else
            {
                AppIcon.ShowBalloonTip(500, "Sẽ không chạy cùng Windows", "Will not run with Windows", ToolTipIcon.Info);
            }
        }
    }
}
