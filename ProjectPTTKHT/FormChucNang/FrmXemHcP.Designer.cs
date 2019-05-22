namespace ProjectPTTKHT
{
    partial class FrmXemHcP
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPHAIDONG = new System.Windows.Forms.TextBox();
            this.cboMIENGIAM = new System.Windows.Forms.ComboBox();
            this.txtHOCPHI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboHOCKY = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExit = new Telerik.WinControls.UI.RadButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExit)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "1. Sinh viên vùng sâu, vùng xa, \r\ndân tộc thiểu số (giảm 10% học phí)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "VNĐ";
            // 
            // txtPHAIDONG
            // 
            this.txtPHAIDONG.Location = new System.Drawing.Point(183, 222);
            this.txtPHAIDONG.Name = "txtPHAIDONG";
            this.txtPHAIDONG.ReadOnly = true;
            this.txtPHAIDONG.Size = new System.Drawing.Size(332, 27);
            this.txtPHAIDONG.TabIndex = 8;
            // 
            // cboMIENGIAM
            // 
            this.cboMIENGIAM.FormattingEnabled = true;
            this.cboMIENGIAM.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.cboMIENGIAM.Location = new System.Drawing.Point(183, 170);
            this.cboMIENGIAM.Name = "cboMIENGIAM";
            this.cboMIENGIAM.Size = new System.Drawing.Size(333, 27);
            this.cboMIENGIAM.TabIndex = 7;
            this.cboMIENGIAM.SelectedIndexChanged += new System.EventHandler(this.cboMIENGIAM_SelectedIndexChanged);
            // 
            // txtHOCPHI
            // 
            this.txtHOCPHI.Location = new System.Drawing.Point(183, 109);
            this.txtHOCPHI.Name = "txtHOCPHI";
            this.txtHOCPHI.Size = new System.Drawing.Size(333, 27);
            this.txtHOCPHI.TabIndex = 6;
            this.txtHOCPHI.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHOCPHI_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 38);
            this.label11.TabIndex = 2;
            this.label11.Text = "3. Sinh viên là con của thương binh liệt sĩ \r\n(giảm 30% học phí)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(338, 38);
            this.label10.TabIndex = 1;
            this.label10.Text = "2. Sinh viên có sổ hộ nghèo, có anh (chị, em) \r\nhọc chung trường (giảm 20% học ph" +
    "í)";
            // 
            // cboHOCKY
            // 
            this.cboHOCKY.FormattingEnabled = true;
            this.cboHOCKY.Items.AddRange(new object[] {
            "Học kỳ I (2018-2019)",
            "Học kỳ II (2018-2019)",
            "Học kỳ III (2018-2019)"});
            this.cboHOCKY.Location = new System.Drawing.Point(183, 52);
            this.cboHOCKY.Name = "cboHOCKY";
            this.cboHOCKY.Size = new System.Drawing.Size(333, 27);
            this.cboHOCKY.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học Kỳ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPHAIDONG);
            this.groupBox1.Controls.Add(this.cboMIENGIAM);
            this.groupBox1.Controls.Add(this.txtHOCPHI);
            this.groupBox1.Controls.Add(this.cboHOCKY);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(54, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 286);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học phí";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(670, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chế độ miễn giảm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phải đóng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Miễn Giảm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Học Phí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "XEM HỌC PHÍ";
            // 
            // txtExit
            // 
            this.txtExit.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.txtExit.Location = new System.Drawing.Point(921, 388);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(165, 58);
            this.txtExit.TabIndex = 6;
            this.txtExit.Text = "Thoát";
            // 
            // FrmXemHcP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 588);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmXemHcP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXemHcP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPHAIDONG;
        private System.Windows.Forms.ComboBox cboMIENGIAM;
        private System.Windows.Forms.TextBox txtHOCPHI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboHOCKY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton txtExit;
    }
}