namespace ProjectPTTKHT
{
    partial class FrmTkbSV
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn9 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Tiết");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn10 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Thứ 2");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn11 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Thứ 3");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn12 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Thứ 4");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn13 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Thứ 5");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn14 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Thứ 6");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn15 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 6", "Thứ 7");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn16 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 7", "Chủ Nhật");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn17 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Mã MH");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn18 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Tên MH");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn19 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Ten GV");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn20 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Phòng");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn21 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Tên lớp");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn22 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "TietBD");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn23 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 6", "So Luong Tiet");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn24 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 7", "Thời Gian BĐ");
            this.lstTKB = new Telerik.WinControls.UI.RadListView();
            this.lstTKBChitiet = new Telerik.WinControls.UI.RadListView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnSearchTuan = new DevExpress.XtraEditors.SimpleButton();
            this.cboTuan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnTimKiemHocKi = new DevExpress.XtraEditors.SimpleButton();
            this.cboHocki = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstTKB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTKBChitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocki.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTKB
            // 
            listViewDetailColumn9.HeaderText = "Tiết";
            listViewDetailColumn9.Width = 100F;
            listViewDetailColumn10.HeaderText = "Thứ 2";
            listViewDetailColumn11.HeaderText = "Thứ 3";
            listViewDetailColumn12.HeaderText = "Thứ 4";
            listViewDetailColumn13.HeaderText = "Thứ 5";
            listViewDetailColumn14.HeaderText = "Thứ 6";
            listViewDetailColumn15.HeaderText = "Thứ 7";
            listViewDetailColumn16.HeaderText = "Chủ Nhật";
            this.lstTKB.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn9,
            listViewDetailColumn10,
            listViewDetailColumn11,
            listViewDetailColumn12,
            listViewDetailColumn13,
            listViewDetailColumn14,
            listViewDetailColumn15,
            listViewDetailColumn16});
            this.lstTKB.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lstTKB.ItemSpacing = -1;
            this.lstTKB.Location = new System.Drawing.Point(5, 36);
            this.lstTKB.Name = "lstTKB";
            this.lstTKB.Size = new System.Drawing.Size(1597, 400);
            this.lstTKB.TabIndex = 0;
            this.lstTKB.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // lstTKBChitiet
            // 
            listViewDetailColumn17.HeaderText = "Mã MH";
            listViewDetailColumn18.HeaderText = "Tên MH";
            listViewDetailColumn19.HeaderText = "Ten GV";
            listViewDetailColumn20.HeaderText = "Phòng";
            listViewDetailColumn21.HeaderText = "Tên lớp";
            listViewDetailColumn22.HeaderText = "TietBD";
            listViewDetailColumn23.HeaderText = "So Luong Tiet";
            listViewDetailColumn24.HeaderText = "Thời Gian BĐ";
            this.lstTKBChitiet.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn17,
            listViewDetailColumn18,
            listViewDetailColumn19,
            listViewDetailColumn20,
            listViewDetailColumn21,
            listViewDetailColumn22,
            listViewDetailColumn23,
            listViewDetailColumn24});
            this.lstTKBChitiet.ItemSpacing = -1;
            this.lstTKBChitiet.Location = new System.Drawing.Point(6, 36);
            this.lstTKBChitiet.Name = "lstTKBChitiet";
            this.lstTKBChitiet.Size = new System.Drawing.Size(1596, 344);
            this.lstTKBChitiet.TabIndex = 1;
            this.lstTKBChitiet.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lstTKBChitiet);
            this.groupControl1.Location = new System.Drawing.Point(7, 464);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1609, 386);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chi Tiết TKB";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lstTKB);
            this.groupControl2.Location = new System.Drawing.Point(7, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1609, 446);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thời Khóa Biểu";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnSearchTuan);
            this.groupControl3.Controls.Add(this.cboTuan);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Location = new System.Drawing.Point(1622, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(290, 446);
            this.groupControl3.TabIndex = 4;
            // 
            // btnSearchTuan
            // 
            this.btnSearchTuan.Location = new System.Drawing.Point(11, 130);
            this.btnSearchTuan.Name = "btnSearchTuan";
            this.btnSearchTuan.Size = new System.Drawing.Size(160, 54);
            this.btnSearchTuan.TabIndex = 2;
            this.btnSearchTuan.Text = "Tìm Kiếm";
            // 
            // cboTuan
            // 
            this.cboTuan.Location = new System.Drawing.Point(11, 79);
            this.cboTuan.Name = "cboTuan";
            this.cboTuan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboTuan.Properties.Appearance.Options.UseFont = true;
            this.cboTuan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTuan.Properties.Items.AddRange(new object[] {
            "Tuần 1"});
            this.cboTuan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTuan.Size = new System.Drawing.Size(273, 36);
            this.cboTuan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tuần học:";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnTimKiemHocKi);
            this.groupControl4.Controls.Add(this.cboHocki);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Location = new System.Drawing.Point(1622, 464);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(290, 386);
            this.groupControl4.TabIndex = 5;
            // 
            // btnTimKiemHocKi
            // 
            this.btnTimKiemHocKi.Location = new System.Drawing.Point(11, 123);
            this.btnTimKiemHocKi.Name = "btnTimKiemHocKi";
            this.btnTimKiemHocKi.Size = new System.Drawing.Size(160, 54);
            this.btnTimKiemHocKi.TabIndex = 4;
            this.btnTimKiemHocKi.Text = "Tìm Kiếm";
            // 
            // cboHocki
            // 
            this.cboHocki.Location = new System.Drawing.Point(11, 68);
            this.cboHocki.Name = "cboHocki";
            this.cboHocki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cboHocki.Properties.Appearance.Options.UseFont = true;
            this.cboHocki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocki.Properties.Items.AddRange(new object[] {
            "Tuần 1"});
            this.cboHocki.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboHocki.Size = new System.Drawing.Size(273, 36);
            this.cboHocki.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn học kì:";
            // 
            // FrmTkbSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 887);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmTkbSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTkbSV";
            ((System.ComponentModel.ISupportInitialize)(this.lstTKB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTKBChitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocki.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView lstTKB;
        private Telerik.WinControls.UI.RadListView lstTKBChitiet;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboTuan;
        private DevExpress.XtraEditors.ComboBoxEdit cboHocki;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSearchTuan;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemHocKi;
    }
}