namespace MCU
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuTab = new MetroFramework.Controls.MetroTabControl();
            this.tabMonitor = new MetroFramework.Controls.MetroTabPage();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCPUName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel23 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCpuTemp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCPULoad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGauge3 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.psCPUTemp = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.psCPULoad = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.lblRamTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRamLoad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRamUse = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel21 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.psRamLoad = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuGauge9 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblGPUName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel27 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGPULoad = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel25 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGPUTemp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGPUFan = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.psGPUFanLoad = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuGauge6 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.psGPUTemp = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.psGPULoad = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuTab.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTab
            // 
            this.menuTab.Controls.Add(this.tabMonitor);
            this.menuTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTab.Location = new System.Drawing.Point(20, 60);
            this.menuTab.Margin = new System.Windows.Forms.Padding(5);
            this.menuTab.Name = "menuTab";
            this.menuTab.SelectedIndex = 0;
            this.menuTab.Size = new System.Drawing.Size(595, 861);
            this.menuTab.TabIndex = 0;
            this.menuTab.UseSelectable = true;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.bunifuCards1);
            this.tabMonitor.Controls.Add(this.bunifuCards3);
            this.tabMonitor.Controls.Add(this.bunifuCards2);
            this.tabMonitor.HorizontalScrollbarBarColor = true;
            this.tabMonitor.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMonitor.HorizontalScrollbarSize = 10;
            this.tabMonitor.Location = new System.Drawing.Point(4, 38);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Size = new System.Drawing.Size(587, 819);
            this.tabMonitor.TabIndex = 0;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.VerticalScrollbarBarColor = true;
            this.tabMonitor.VerticalScrollbarHighlightOnWheel = false;
            this.tabMonitor.VerticalScrollbarSize = 10;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards1.BorderRadius = 4;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.MediumTurquoise;
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.lblCPUName);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel23);
            this.bunifuCards1.Controls.Add(this.lblCpuTemp);
            this.bunifuCards1.Controls.Add(this.lblCPULoad);
            this.bunifuCards1.Controls.Add(this.bunifuGauge3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.psCPUTemp);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.psCPULoad);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 50;
            this.bunifuCards1.Size = new System.Drawing.Size(349, 217);
            this.bunifuCards1.TabIndex = 7;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(285, 118);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(29, 25);
            this.bunifuCustomLabel2.TabIndex = 26;
            this.bunifuCustomLabel2.Text = "%";
            // 
            // lblCPUName
            // 
            this.lblCPUName.AutoSize = true;
            this.lblCPUName.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUName.Location = new System.Drawing.Point(54, 10);
            this.lblCPUName.Name = "lblCPUName";
            this.lblCPUName.Size = new System.Drawing.Size(0, 25);
            this.lblCPUName.TabIndex = 21;
            // 
            // bunifuCustomLabel23
            // 
            this.bunifuCustomLabel23.AutoSize = true;
            this.bunifuCustomLabel23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel23.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel23.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel23.Location = new System.Drawing.Point(119, 122);
            this.bunifuCustomLabel23.Name = "bunifuCustomLabel23";
            this.bunifuCustomLabel23.Size = new System.Drawing.Size(33, 25);
            this.bunifuCustomLabel23.TabIndex = 20;
            this.bunifuCustomLabel23.Text = "°C";
            // 
            // lblCpuTemp
            // 
            this.lblCpuTemp.AutoSize = true;
            this.lblCpuTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuTemp.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuTemp.ForeColor = System.Drawing.Color.Black;
            this.lblCpuTemp.Location = new System.Drawing.Point(57, 118);
            this.lblCpuTemp.Name = "lblCpuTemp";
            this.lblCpuTemp.Size = new System.Drawing.Size(65, 37);
            this.lblCpuTemp.TabIndex = 19;
            this.lblCpuTemp.Text = "100";
            // 
            // lblCPULoad
            // 
            this.lblCPULoad.AutoSize = true;
            this.lblCPULoad.BackColor = System.Drawing.Color.White;
            this.lblCPULoad.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPULoad.ForeColor = System.Drawing.Color.Black;
            this.lblCPULoad.Location = new System.Drawing.Point(223, 110);
            this.lblCPULoad.Name = "lblCPULoad";
            this.lblCPULoad.Size = new System.Drawing.Size(65, 37);
            this.lblCPULoad.TabIndex = 17;
            this.lblCPULoad.Text = "100";
            // 
            // bunifuGauge3
            // 
            this.bunifuGauge3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge3.BackgroundImage")));
            this.bunifuGauge3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuGauge3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge3.Location = new System.Drawing.Point(1098, 111);
            this.bunifuGauge3.Margin = new System.Windows.Forms.Padding(18);
            this.bunifuGauge3.Name = "bunifuGauge3";
            this.bunifuGauge3.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge3.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge3.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge3.Size = new System.Drawing.Size(630, 432);
            this.bunifuGauge3.TabIndex = 6;
            this.bunifuGauge3.Thickness = 10;
            this.bunifuGauge3.Value = 20;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(75, 89);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(49, 21);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "TEMP";
            // 
            // psCPUTemp
            // 
            this.psCPUTemp.animated = false;
            this.psCPUTemp.animationIterval = 5;
            this.psCPUTemp.animationSpeed = 300;
            this.psCPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.psCPUTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("psCPUTemp.BackgroundImage")));
            this.psCPUTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.psCPUTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.psCPUTemp.ForeColor = System.Drawing.Color.SeaGreen;
            this.psCPUTemp.LabelVisible = false;
            this.psCPUTemp.LineProgressThickness = 9;
            this.psCPUTemp.LineThickness = 15;
            this.psCPUTemp.Location = new System.Drawing.Point(16, 50);
            this.psCPUTemp.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.psCPUTemp.MaxValue = 100;
            this.psCPUTemp.Name = "psCPUTemp";
            this.psCPUTemp.ProgressBackColor = System.Drawing.Color.LightGray;
            this.psCPUTemp.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.psCPUTemp.Size = new System.Drawing.Size(158, 158);
            this.psCPUTemp.TabIndex = 4;
            this.psCPUTemp.Value = 0;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(237, 79);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(51, 21);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "LOAD";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 10);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(52, 25);
            this.bunifuCustomLabel5.TabIndex = 2;
            this.bunifuCustomLabel5.Text = "CPU:";
            // 
            // psCPULoad
            // 
            this.psCPULoad.animated = false;
            this.psCPULoad.animationIterval = 2;
            this.psCPULoad.animationSpeed = 300;
            this.psCPULoad.BackColor = System.Drawing.Color.Transparent;
            this.psCPULoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("psCPULoad.BackgroundImage")));
            this.psCPULoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.psCPULoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.psCPULoad.ForeColor = System.Drawing.Color.SeaGreen;
            this.psCPULoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.psCPULoad.LabelVisible = false;
            this.psCPULoad.LineProgressThickness = 9;
            this.psCPULoad.LineThickness = 15;
            this.psCPULoad.Location = new System.Drawing.Point(182, 50);
            this.psCPULoad.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.psCPULoad.MaxValue = 100;
            this.psCPULoad.Name = "psCPULoad";
            this.psCPULoad.ProgressBackColor = System.Drawing.Color.LightGray;
            this.psCPULoad.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.psCPULoad.Size = new System.Drawing.Size(158, 158);
            this.psCPULoad.TabIndex = 1;
            this.psCPULoad.Value = 0;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuCards3.BorderRadius = 4;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.MediumTurquoise;
            this.bunifuCards3.Controls.Add(this.lblRamTotal);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuCards3.Controls.Add(this.lblRamLoad);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards3.Controls.Add(this.lblRamUse);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel21);
            this.bunifuCards3.Controls.Add(this.psRamLoad);
            this.bunifuCards3.Controls.Add(this.bunifuGauge9);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel15);
            this.bunifuCards3.LeftSahddow = true;
            this.bunifuCards3.Location = new System.Drawing.Point(359, 3);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 50;
            this.bunifuCards3.Size = new System.Drawing.Size(228, 217);
            this.bunifuCards3.TabIndex = 5;
            // 
            // lblRamTotal
            // 
            this.lblRamTotal.AutoSize = true;
            this.lblRamTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblRamTotal.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamTotal.ForeColor = System.Drawing.Color.Black;
            this.lblRamTotal.Location = new System.Drawing.Point(54, 12);
            this.lblRamTotal.Name = "lblRamTotal";
            this.lblRamTotal.Size = new System.Drawing.Size(0, 25);
            this.lblRamTotal.TabIndex = 26;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(131, 110);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(29, 25);
            this.bunifuCustomLabel7.TabIndex = 25;
            this.bunifuCustomLabel7.Text = "%";
            // 
            // lblRamLoad
            // 
            this.lblRamLoad.AutoSize = true;
            this.lblRamLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblRamLoad.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamLoad.ForeColor = System.Drawing.Color.Black;
            this.lblRamLoad.Location = new System.Drawing.Point(73, 100);
            this.lblRamLoad.Name = "lblRamLoad";
            this.lblRamLoad.Size = new System.Drawing.Size(33, 37);
            this.lblRamLoad.TabIndex = 24;
            this.lblRamLoad.Text = "0";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(119, 147);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(32, 21);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "GB";
            // 
            // lblRamUse
            // 
            this.lblRamUse.AutoSize = true;
            this.lblRamUse.BackColor = System.Drawing.Color.Transparent;
            this.lblRamUse.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamUse.ForeColor = System.Drawing.Color.Gray;
            this.lblRamUse.Location = new System.Drawing.Point(64, 138);
            this.lblRamUse.Name = "lblRamUse";
            this.lblRamUse.Size = new System.Drawing.Size(63, 32);
            this.lblRamUse.TabIndex = 22;
            this.lblRamUse.Text = "0.00";
            // 
            // bunifuCustomLabel21
            // 
            this.bunifuCustomLabel21.AutoSize = true;
            this.bunifuCustomLabel21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel21.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel21.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel21.Location = new System.Drawing.Point(76, 79);
            this.bunifuCustomLabel21.Name = "bunifuCustomLabel21";
            this.bunifuCustomLabel21.Size = new System.Drawing.Size(51, 21);
            this.bunifuCustomLabel21.TabIndex = 8;
            this.bunifuCustomLabel21.Text = "LOAD";
            // 
            // psRamLoad
            // 
            this.psRamLoad.animated = false;
            this.psRamLoad.animationIterval = 5;
            this.psRamLoad.animationSpeed = 300;
            this.psRamLoad.BackColor = System.Drawing.Color.Transparent;
            this.psRamLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("psRamLoad.BackgroundImage")));
            this.psRamLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.psRamLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.psRamLoad.ForeColor = System.Drawing.Color.SeaGreen;
            this.psRamLoad.LabelVisible = false;
            this.psRamLoad.LineProgressThickness = 9;
            this.psRamLoad.LineThickness = 15;
            this.psRamLoad.Location = new System.Drawing.Point(28, 50);
            this.psRamLoad.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.psRamLoad.MaxValue = 100;
            this.psRamLoad.Name = "psRamLoad";
            this.psRamLoad.ProgressBackColor = System.Drawing.Color.LightGray;
            this.psRamLoad.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.psRamLoad.Size = new System.Drawing.Size(158, 158);
            this.psRamLoad.TabIndex = 7;
            this.psRamLoad.Value = 0;
            // 
            // bunifuGauge9
            // 
            this.bunifuGauge9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge9.BackgroundImage")));
            this.bunifuGauge9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuGauge9.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge9.Location = new System.Drawing.Point(1098, 111);
            this.bunifuGauge9.Margin = new System.Windows.Forms.Padding(18);
            this.bunifuGauge9.Name = "bunifuGauge9";
            this.bunifuGauge9.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge9.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge9.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge9.Size = new System.Drawing.Size(630, 432);
            this.bunifuGauge9.TabIndex = 6;
            this.bunifuGauge9.Thickness = 10;
            this.bunifuGauge9.Value = 20;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(3, 12);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(56, 25);
            this.bunifuCustomLabel15.TabIndex = 2;
            this.bunifuCustomLabel15.Text = "RAM:";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 4;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.MediumTurquoise;
            this.bunifuCards2.Controls.Add(this.lblGPUName);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel27);
            this.bunifuCards2.Controls.Add(this.lblGPULoad);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel25);
            this.bunifuCards2.Controls.Add(this.lblGPUTemp);
            this.bunifuCards2.Controls.Add(this.lblGPUFan);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel18);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards2.Controls.Add(this.psGPUFanLoad);
            this.bunifuCards2.Controls.Add(this.bunifuGauge6);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards2.Controls.Add(this.psGPUTemp);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel9);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel10);
            this.bunifuCards2.Controls.Add(this.psGPULoad);
            this.bunifuCards2.LeftSahddow = true;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 223);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 50;
            this.bunifuCards2.Size = new System.Drawing.Size(587, 217);
            this.bunifuCards2.TabIndex = 3;
            // 
            // lblGPUName
            // 
            this.lblGPUName.AutoSize = true;
            this.lblGPUName.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUName.Location = new System.Drawing.Point(54, 16);
            this.lblGPUName.Name = "lblGPUName";
            this.lblGPUName.Size = new System.Drawing.Size(0, 25);
            this.lblGPUName.TabIndex = 23;
            // 
            // bunifuCustomLabel27
            // 
            this.bunifuCustomLabel27.AutoSize = true;
            this.bunifuCustomLabel27.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel27.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel27.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel27.Location = new System.Drawing.Point(285, 128);
            this.bunifuCustomLabel27.Name = "bunifuCustomLabel27";
            this.bunifuCustomLabel27.Size = new System.Drawing.Size(29, 25);
            this.bunifuCustomLabel27.TabIndex = 22;
            this.bunifuCustomLabel27.Text = "%";
            // 
            // lblGPULoad
            // 
            this.lblGPULoad.AutoSize = true;
            this.lblGPULoad.BackColor = System.Drawing.Color.Transparent;
            this.lblGPULoad.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPULoad.ForeColor = System.Drawing.Color.Black;
            this.lblGPULoad.Location = new System.Drawing.Point(223, 116);
            this.lblGPULoad.Name = "lblGPULoad";
            this.lblGPULoad.Size = new System.Drawing.Size(65, 37);
            this.lblGPULoad.TabIndex = 21;
            this.lblGPULoad.Text = "100";
            // 
            // bunifuCustomLabel25
            // 
            this.bunifuCustomLabel25.AutoSize = true;
            this.bunifuCustomLabel25.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel25.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel25.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel25.Location = new System.Drawing.Point(119, 128);
            this.bunifuCustomLabel25.Name = "bunifuCustomLabel25";
            this.bunifuCustomLabel25.Size = new System.Drawing.Size(33, 25);
            this.bunifuCustomLabel25.TabIndex = 20;
            this.bunifuCustomLabel25.Text = "°C";
            // 
            // lblGPUTemp
            // 
            this.lblGPUTemp.AutoSize = true;
            this.lblGPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblGPUTemp.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUTemp.ForeColor = System.Drawing.Color.Black;
            this.lblGPUTemp.Location = new System.Drawing.Point(59, 116);
            this.lblGPUTemp.Name = "lblGPUTemp";
            this.lblGPUTemp.Size = new System.Drawing.Size(65, 37);
            this.lblGPUTemp.TabIndex = 19;
            this.lblGPUTemp.Text = "100";
            // 
            // lblGPUFan
            // 
            this.lblGPUFan.AutoSize = true;
            this.lblGPUFan.BackColor = System.Drawing.Color.Transparent;
            this.lblGPUFan.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPUFan.ForeColor = System.Drawing.Color.Black;
            this.lblGPUFan.Location = new System.Drawing.Point(411, 168);
            this.lblGPUFan.Name = "lblGPUFan";
            this.lblGPUFan.Size = new System.Drawing.Size(34, 40);
            this.lblGPUFan.TabIndex = 18;
            this.lblGPUFan.Text = "0";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(502, 187);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(43, 21);
            this.bunifuCustomLabel18.TabIndex = 17;
            this.bunifuCustomLabel18.Text = "RPM";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(458, 155);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(28, 13);
            this.bunifuCustomLabel6.TabIndex = 10;
            this.bunifuCustomLabel6.Text = "FAN";
            // 
            // psGPUFanLoad
            // 
            this.psGPUFanLoad.BackColor = System.Drawing.Color.Transparent;
            this.psGPUFanLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("psGPUFanLoad.BackgroundImage")));
            this.psGPUFanLoad.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.psGPUFanLoad.Location = new System.Drawing.Point(377, 32);
            this.psGPUFanLoad.Margin = new System.Windows.Forms.Padding(6);
            this.psGPUFanLoad.Name = "psGPUFanLoad";
            this.psGPUFanLoad.ProgressBgColor = System.Drawing.Color.Silver;
            this.psGPUFanLoad.ProgressColor1 = System.Drawing.Color.PaleGreen;
            this.psGPUFanLoad.ProgressColor2 = System.Drawing.Color.Red;
            this.psGPUFanLoad.Size = new System.Drawing.Size(190, 121);
            this.psGPUFanLoad.TabIndex = 7;
            this.psGPUFanLoad.Thickness = 11;
            this.psGPUFanLoad.Value = 0;
            // 
            // bunifuGauge6
            // 
            this.bunifuGauge6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge6.BackgroundImage")));
            this.bunifuGauge6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuGauge6.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge6.Location = new System.Drawing.Point(1098, 111);
            this.bunifuGauge6.Margin = new System.Windows.Forms.Padding(18);
            this.bunifuGauge6.Name = "bunifuGauge6";
            this.bunifuGauge6.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuGauge6.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.bunifuGauge6.ProgressColor2 = System.Drawing.Color.Tomato;
            this.bunifuGauge6.Size = new System.Drawing.Size(630, 432);
            this.bunifuGauge6.TabIndex = 6;
            this.bunifuGauge6.Thickness = 10;
            this.bunifuGauge6.Value = 20;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(73, 89);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(49, 21);
            this.bunifuCustomLabel8.TabIndex = 5;
            this.bunifuCustomLabel8.Text = "TEMP";
            // 
            // psGPUTemp
            // 
            this.psGPUTemp.animated = false;
            this.psGPUTemp.animationIterval = 5;
            this.psGPUTemp.animationSpeed = 300;
            this.psGPUTemp.BackColor = System.Drawing.Color.Transparent;
            this.psGPUTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("psGPUTemp.BackgroundImage")));
            this.psGPUTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.psGPUTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.psGPUTemp.ForeColor = System.Drawing.Color.SeaGreen;
            this.psGPUTemp.LabelVisible = false;
            this.psGPUTemp.LineProgressThickness = 9;
            this.psGPUTemp.LineThickness = 15;
            this.psGPUTemp.Location = new System.Drawing.Point(16, 50);
            this.psGPUTemp.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.psGPUTemp.MaxValue = 100;
            this.psGPUTemp.Name = "psGPUTemp";
            this.psGPUTemp.ProgressBackColor = System.Drawing.Color.LightGray;
            this.psGPUTemp.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.psGPUTemp.Size = new System.Drawing.Size(158, 158);
            this.psGPUTemp.TabIndex = 4;
            this.psGPUTemp.Value = 0;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(237, 89);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(51, 21);
            this.bunifuCustomLabel9.TabIndex = 3;
            this.bunifuCustomLabel9.Text = "LOAD";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(3, 16);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(53, 25);
            this.bunifuCustomLabel10.TabIndex = 2;
            this.bunifuCustomLabel10.Text = "GPU:";
            // 
            // psGPULoad
            // 
            this.psGPULoad.animated = false;
            this.psGPULoad.animationIterval = 5;
            this.psGPULoad.animationSpeed = 300;
            this.psGPULoad.BackColor = System.Drawing.Color.Transparent;
            this.psGPULoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("psGPULoad.BackgroundImage")));
            this.psGPULoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.psGPULoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.psGPULoad.ForeColor = System.Drawing.Color.SeaGreen;
            this.psGPULoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.psGPULoad.LabelVisible = false;
            this.psGPULoad.LineProgressThickness = 9;
            this.psGPULoad.LineThickness = 15;
            this.psGPULoad.Location = new System.Drawing.Point(182, 50);
            this.psGPULoad.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.psGPULoad.MaxValue = 100;
            this.psGPULoad.Name = "psGPULoad";
            this.psGPULoad.ProgressBackColor = System.Drawing.Color.LightGray;
            this.psGPULoad.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.psGPULoad.Size = new System.Drawing.Size(158, 158);
            this.psGPULoad.TabIndex = 1;
            this.psGPULoad.Value = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(635, 941);
            this.Controls.Add(this.menuTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Hardware Monitor";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuTab.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl menuTab;
        private MetroFramework.Controls.MetroTabPage tabMonitor;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuGauge psGPUFanLoad;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCircleProgressbar psGPUTemp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCircleProgressbar psGPULoad;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar psCPUTemp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar psCPULoad;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGPUFan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel21;
        private Bunifu.Framework.UI.BunifuCircleProgressbar psRamLoad;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCPULoad;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCPUName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel23;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCpuTemp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel27;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGPULoad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel25;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGPUTemp;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGPUName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRamUse;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRamLoad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRamTotal;
    }
}