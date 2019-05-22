namespace ProjectPTTKHT
{
    partial class FrmTkbGV
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Mã MH");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Tên MH");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Tiết Bắt Đầu");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Số lượng tiết");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Ngày BĐ");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Phòng");
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lstTKBGv = new Telerik.WinControls.UI.RadListView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTKBGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lstTKBGv);
            this.groupControl2.Location = new System.Drawing.Point(1, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1123, 392);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Lịch Dạy";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // lstTKBGv
            // 
            listViewDetailColumn1.HeaderText = "Mã MH";
            listViewDetailColumn1.Width = 100F;
            listViewDetailColumn2.HeaderText = "Tên MH";
            listViewDetailColumn3.HeaderText = "Tiết Bắt Đầu";
            listViewDetailColumn4.HeaderText = "Số lượng tiết";
            listViewDetailColumn5.HeaderText = "Ngày BĐ";
            listViewDetailColumn6.HeaderText = "Phòng";
            this.lstTKBGv.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5,
            listViewDetailColumn6});
            this.lstTKBGv.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lstTKBGv.ItemSpacing = -1;
            this.lstTKBGv.Location = new System.Drawing.Point(11, 36);
            this.lstTKBGv.Name = "lstTKBGv";
            this.lstTKBGv.Size = new System.Drawing.Size(1099, 336);
            this.lstTKBGv.TabIndex = 0;
            this.lstTKBGv.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(41, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tuần Dạy:";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(161, 418);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Tuần 1",
            "Tuần 2",
            "Tuần 3",
            "Tuần 4",
            "Tuần 5",
            "Tuần 6"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(286, 28);
            this.comboBoxEdit1.TabIndex = 6;
            // 
            // FrmTkbGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 524);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl2);
            this.Name = "FrmTkbGV";
            this.Text = "FrmTkbGV";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTKBGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Telerik.WinControls.UI.RadListView lstTKBGv;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}