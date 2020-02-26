using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace MCU
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        readonly private Computer thisComputer = new Computer();
        public Home()
        {
            InitializeComponent();
            this.thisComputer.CPUEnabled = true;
            this.thisComputer.GPUEnabled = true;
            this.thisComputer.HDDEnabled = true;
            this.thisComputer.MainboardEnabled = true;
            this.thisComputer.RAMEnabled = true;
            this.thisComputer.Open();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            /*-------------------------------------Đọc thông số-------------------------------------*/
            String cpuName = "", gpuName = "";
            float cpuLoad = 0, cpuTemp = 0, cpuFan = 0, cpuFanLoad = 0;
            float gpuLoad = 0, gpuTemp = 0, gpuFan = 0, gpuFanLoad = 0;
            float ramLoad = 0, ramUse = 0, totalRam =0;
            foreach (var hardware in thisComputer.Hardware)
            {
                hardware.Update();
                /*---------------------------------CPU---------------------------------*/
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    cpuName = hardware.Name;
                    lblCPUName.Text = cpuName;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total") {
                            cpuLoad = sensor.Value.Value;
                            int load = (int)cpuLoad;
                            psCPULoad.Value = load;
                            lblCPULoad.Text = load.ToString();
                        }

                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Package") {
                            cpuTemp = sensor.Value.GetValueOrDefault();
                            int temp = (int)cpuTemp;
                            psCPUTemp.Value = temp;
                            lblCpuTemp.Text = temp.ToString();
                        }
                    }
                }

                /*---------------------------------RAM---------------------------------*/
                if (hardware.HardwareType == HardwareType.RAM)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load) {
                            ramLoad = sensor.Value.Value;
                            int load = (int)ramLoad;
                            psRamLoad.Value = load;
                            lblRamLoad.Text = load.ToString();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Used Memory")
                        {
                            ramUse = sensor.Value.GetValueOrDefault();
                            double ram = Math.Round(ramUse, 2);
                            lblRamUse.Text = ram.ToString();
                        }
                        if (sensor.SensorType == SensorType.Data && sensor.Name == "Available Memory")
                        {
                            float ramAva = sensor.Value.GetValueOrDefault();
                            float allRam = ramAva + ramUse;
                            double ram = Math.Round(allRam);
                            lblRamTotal.Text = ram.ToString()+" GB";
                        }

                    }
                }

                /*---------------------------------GPU---------------------------------*/
                if (hardware.HardwareType == HardwareType.GpuAti || hardware.HardwareType == HardwareType.GpuNvidia)
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

                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            gpuTemp = sensor.Value.GetValueOrDefault();
                            int temp = (int)gpuTemp;
                            psGPUTemp.Value = temp;
                            lblGPUTemp.Text = temp.ToString();
                        }
                        if (sensor.SensorType == SensorType.Fan && sensor.Name == "GPU Fan")
                        {
                            gpuFan = sensor.Value.GetValueOrDefault();
                            int fan = (int)gpuFan;
                            lblGPUFan.Text = fan.ToString();
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
        }
    }
}
