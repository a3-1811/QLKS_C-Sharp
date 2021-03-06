﻿namespace QUANLYKHACHSAN
{
    partial class frmKhachhangthanthiet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachhangthanthiet));
            this.gridControlKhachhangthanthiet = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuotDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiHoiVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachhangthanthiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKhachhangthanthiet
            // 
            this.gridControlKhachhangthanthiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKhachhangthanthiet.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControlKhachhangthanthiet.Location = new System.Drawing.Point(12, 29);
            this.gridControlKhachhangthanthiet.MainView = this.gridView1;
            this.gridControlKhachhangthanthiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControlKhachhangthanthiet.Name = "gridControlKhachhangthanthiet";
            this.gridControlKhachhangthanthiet.Size = new System.Drawing.Size(859, 464);
            this.gridControlKhachhangthanthiet.TabIndex = 7;
            this.gridControlKhachhangthanthiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.SoLuotDen,
            this.LoaiHoiVien,
            this.TongHoaDon,
            this.DienThoai,
            this.GhiChu});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlKhachhangthanthiet;
            this.gridView1.Name = "gridView1";
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.Caption = "Mã Khách Hàng";
            this.MaKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("MaKhachHang.ImageOptions.Image")));
            this.MaKhachHang.MinWidth = 19;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Visible = true;
            this.MaKhachHang.VisibleIndex = 0;
            this.MaKhachHang.Width = 102;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Caption = "Tên Khách Hàng";
            this.TenKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TenKhachHang.ImageOptions.Image")));
            this.TenKhachHang.MinWidth = 19;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Visible = true;
            this.TenKhachHang.VisibleIndex = 1;
            this.TenKhachHang.Width = 122;
            // 
            // SoLuotDen
            // 
            this.SoLuotDen.Caption = "Số Lượt Đến";
            this.SoLuotDen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SoLuotDen.ImageOptions.Image")));
            this.SoLuotDen.MinWidth = 19;
            this.SoLuotDen.Name = "SoLuotDen";
            this.SoLuotDen.Visible = true;
            this.SoLuotDen.VisibleIndex = 3;
            this.SoLuotDen.Width = 100;
            // 
            // LoaiHoiVien
            // 
            this.LoaiHoiVien.Caption = "Loại Hội Viên";
            this.LoaiHoiVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LoaiHoiVien.ImageOptions.Image")));
            this.LoaiHoiVien.MinWidth = 19;
            this.LoaiHoiVien.Name = "LoaiHoiVien";
            this.LoaiHoiVien.Visible = true;
            this.LoaiHoiVien.VisibleIndex = 4;
            this.LoaiHoiVien.Width = 108;
            // 
            // TongHoaDon
            // 
            this.TongHoaDon.Caption = "Tổng Hóa Đơn";
            this.TongHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TongHoaDon.ImageOptions.Image")));
            this.TongHoaDon.MinWidth = 19;
            this.TongHoaDon.Name = "TongHoaDon";
            this.TongHoaDon.Visible = true;
            this.TongHoaDon.VisibleIndex = 5;
            this.TongHoaDon.Width = 127;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "Điện Thoại";
            this.DienThoai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DienThoai.ImageOptions.Image")));
            this.DienThoai.MinWidth = 19;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 2;
            this.DienThoai.Width = 79;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GhiChu.ImageOptions.Image")));
            this.GhiChu.MinWidth = 19;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 6;
            this.GhiChu.Width = 116;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Controls.Add(this.iconPictureBox3);
            this.groupBox1.Controls.Add(this.iconPictureBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(890, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(398, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi Chú";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gem;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(29, 31);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 42);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 41;
            this.iconPictureBox3.Location = new System.Drawing.Point(29, 147);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(41, 42);
            this.iconPictureBox3.TabIndex = 5;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gold;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gold;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 41;
            this.iconPictureBox2.Location = new System.Drawing.Point(29, 92);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(41, 42);
            this.iconPictureBox2.TabIndex = 4;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hội viên Bạc: >3 lượt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hội viên Vàng: >5 lượt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hội viên Kim Cương: >8 lượt ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.iconPictureBox5);
            this.groupBox2.Controls.Add(this.iconPictureBox6);
            this.groupBox2.Controls.Add(this.iconPictureBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(890, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(398, 268);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giá Trị Phần Thưởng";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 41;
            this.iconPictureBox5.Location = new System.Drawing.Point(26, 185);
            this.iconPictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(41, 42);
            this.iconPictureBox5.TabIndex = 9;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox6.ForeColor = System.Drawing.Color.Gold;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.iconPictureBox6.IconColor = System.Drawing.Color.Gold;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 41;
            this.iconPictureBox6.Location = new System.Drawing.Point(26, 105);
            this.iconPictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(41, 42);
            this.iconPictureBox6.TabIndex = 8;
            this.iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Gem;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 41;
            this.iconPictureBox4.Location = new System.Drawing.Point(26, 36);
            this.iconPictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(41, 42);
            this.iconPictureBox4.TabIndex = 7;
            this.iconPictureBox4.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(71, 185);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(332, 58);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Hội viên Bạc: 500k + Voucher giảm giá lần sau đến 300k ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(71, 105);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 58);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Hội viên Vàng: 1 triệu + Voucher giảm giá lần sau đến 700k";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 58);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Hội viên Kim Cương: 2 triệu + Voucher giảm giá lần sau đến 1 triệu ";
            // 
            // frmKhachhangthanthiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControlKhachhangthanthiet);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKhachhangthanthiet";
            this.Size = new System.Drawing.Size(1311, 535);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachhangthanthiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKhachhangthanthiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuotDen;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiHoiVien;
        private DevExpress.XtraGrid.Columns.GridColumn TongHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
    }
}
