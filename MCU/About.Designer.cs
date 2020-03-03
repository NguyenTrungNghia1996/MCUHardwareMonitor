namespace MCU
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblVer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFB = new System.Windows.Forms.LinkLabel();
            this.lblSC = new System.Windows.Forms.LinkLabel();
            this.LblLIB = new System.Windows.Forms.LinkLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(180, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(269, 32);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "MCU Hardware Monitor";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.Location = new System.Drawing.Point(182, 55);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(34, 21);
            this.lblVer.TabIndex = 2;
            this.lblVer.Text = "Ver";
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt.Location = new System.Drawing.Point(182, 87);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(287, 21);
            this.lblt.TabIndex = 3;
            this.lblt.Text = "Copyright © 2020 Nguyễn Trung Nghĩa";
            // 
            // lblFB
            // 
            this.lblFB.AutoSize = true;
            this.lblFB.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFB.Location = new System.Drawing.Point(186, 121);
            this.lblFB.Name = "lblFB";
            this.lblFB.Size = new System.Drawing.Size(64, 17);
            this.lblFB.TabIndex = 5;
            this.lblFB.TabStop = true;
            this.lblFB.Text = "Facebook";
            this.lblFB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSC.Location = new System.Drawing.Point(332, 122);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(81, 17);
            this.lblSC.TabIndex = 6;
            this.lblSC.TabStop = true;
            this.lblSC.Text = "Source code";
            this.lblSC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // LblLIB
            // 
            this.LblLIB.AutoSize = true;
            this.LblLIB.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLIB.Location = new System.Drawing.Point(186, 156);
            this.LblLIB.Name = "LblLIB";
            this.LblLIB.Size = new System.Drawing.Size(149, 17);
            this.LblLIB.TabIndex = 7;
            this.LblLIB.TabStop = true;
            this.LblLIB.Text = "Libre Hardware Monitor";
            this.LblLIB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(443, 147);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 26);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "OK";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 181);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.LblLIB);
            this.Controls.Add(this.lblSC);
            this.Controls.Add(this.lblFB);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblVer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblt;
        private System.Windows.Forms.LinkLabel lblFB;
        private System.Windows.Forms.LinkLabel lblSC;
        private System.Windows.Forms.LinkLabel LblLIB;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}