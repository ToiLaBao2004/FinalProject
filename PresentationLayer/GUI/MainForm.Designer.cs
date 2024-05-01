namespace PresentationLayer.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel = new System.Windows.Forms.Panel();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonSanPham = new System.Windows.Forms.Button();
            this.buttonHoaDon = new System.Windows.Forms.Button();
            this.buttonKhachHang = new System.Windows.Forms.Button();
            this.buttonNhanVien = new System.Windows.Forms.Button();
            this.buttonHoaDonNhap = new System.Windows.Forms.Button();
            this.buttonNhaCungCap = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel.Location = new System.Drawing.Point(332, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(960, 767);
            this.panel.TabIndex = 0;
            // 
            // labelChucVu
            // 
            this.labelChucVu.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelChucVu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChucVu.ForeColor = System.Drawing.Color.White;
            this.labelChucVu.Location = new System.Drawing.Point(83, 213);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Size = new System.Drawing.Size(181, 77);
            this.labelChucVu.TabIndex = 3;
            this.labelChucVu.Text = "Chức vụ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(76, 176);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(188, 37);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Tên nhân viên";
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.buttonDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangXuat.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangXuat.ForeColor = System.Drawing.Color.White;
            this.buttonDangXuat.Location = new System.Drawing.Point(56, 718);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(150, 47);
            this.buttonDangXuat.TabIndex = 5;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonSanPham
            // 
            this.buttonSanPham.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonSanPham.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.buttonSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSanPham.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSanPham.ForeColor = System.Drawing.Color.White;
            this.buttonSanPham.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSanPham.Location = new System.Drawing.Point(56, 293);
            this.buttonSanPham.Name = "buttonSanPham";
            this.buttonSanPham.Size = new System.Drawing.Size(278, 47);
            this.buttonSanPham.TabIndex = 6;
            this.buttonSanPham.Text = "Sản phẩm";
            this.buttonSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSanPham.UseVisualStyleBackColor = false;
            this.buttonSanPham.Click += new System.EventHandler(this.buttonSanPham_Click);
            // 
            // buttonHoaDon
            // 
            this.buttonHoaDon.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.buttonHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHoaDon.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoaDon.ForeColor = System.Drawing.Color.White;
            this.buttonHoaDon.Location = new System.Drawing.Point(56, 346);
            this.buttonHoaDon.Name = "buttonHoaDon";
            this.buttonHoaDon.Size = new System.Drawing.Size(278, 47);
            this.buttonHoaDon.TabIndex = 7;
            this.buttonHoaDon.Text = "Hóa đơn bán hàng";
            this.buttonHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHoaDon.UseVisualStyleBackColor = false;
            this.buttonHoaDon.Click += new System.EventHandler(this.buttonHoaDon_Click);
            // 
            // buttonKhachHang
            // 
            this.buttonKhachHang.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.buttonKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKhachHang.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhachHang.ForeColor = System.Drawing.Color.White;
            this.buttonKhachHang.Location = new System.Drawing.Point(56, 399);
            this.buttonKhachHang.Name = "buttonKhachHang";
            this.buttonKhachHang.Size = new System.Drawing.Size(278, 47);
            this.buttonKhachHang.TabIndex = 8;
            this.buttonKhachHang.Text = "Khách hàng";
            this.buttonKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKhachHang.UseVisualStyleBackColor = false;
            this.buttonKhachHang.Click += new System.EventHandler(this.buttonKhachHang_Click);
            // 
            // buttonNhanVien
            // 
            this.buttonNhanVien.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.buttonNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhanVien.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhanVien.ForeColor = System.Drawing.Color.White;
            this.buttonNhanVien.Location = new System.Drawing.Point(56, 505);
            this.buttonNhanVien.Name = "buttonNhanVien";
            this.buttonNhanVien.Size = new System.Drawing.Size(278, 47);
            this.buttonNhanVien.TabIndex = 9;
            this.buttonNhanVien.Text = "Nhân viên";
            this.buttonNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNhanVien.UseVisualStyleBackColor = false;
            // 
            // buttonHoaDonNhap
            // 
            this.buttonHoaDonNhap.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonHoaDonNhap.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.buttonHoaDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHoaDonNhap.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHoaDonNhap.ForeColor = System.Drawing.Color.White;
            this.buttonHoaDonNhap.Location = new System.Drawing.Point(56, 452);
            this.buttonHoaDonNhap.Name = "buttonHoaDonNhap";
            this.buttonHoaDonNhap.Size = new System.Drawing.Size(278, 47);
            this.buttonHoaDonNhap.TabIndex = 10;
            this.buttonHoaDonNhap.Text = "Hóa đơn nhập hàng";
            this.buttonHoaDonNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHoaDonNhap.UseVisualStyleBackColor = false;
            // 
            // buttonNhaCungCap
            // 
            this.buttonNhaCungCap.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonNhaCungCap.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.buttonNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhaCungCap.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.buttonNhaCungCap.Location = new System.Drawing.Point(56, 558);
            this.buttonNhaCungCap.Name = "buttonNhaCungCap";
            this.buttonNhaCungCap.Size = new System.Drawing.Size(278, 47);
            this.buttonNhaCungCap.TabIndex = 11;
            this.buttonNhaCungCap.Text = "Nhà cung cấp";
            this.buttonNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNhaCungCap.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(2, 718);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(55, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(2, 558);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(55, 47);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(2, 505);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 47);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-2, 452);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(2, 399);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-2, 346);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 767);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1292, 763);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonNhaCungCap);
            this.Controls.Add(this.buttonHoaDonNhap);
            this.Controls.Add(this.buttonNhanVien);
            this.Controls.Add(this.buttonKhachHang);
            this.Controls.Add(this.buttonHoaDon);
            this.Controls.Add(this.buttonSanPham);
            this.Controls.Add(this.buttonDangXuat);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelChucVu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelChucVu;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Button buttonHoaDon;
        private System.Windows.Forms.Button buttonKhachHang;
        private System.Windows.Forms.Button buttonNhanVien;
        private System.Windows.Forms.Button buttonHoaDonNhap;
        private System.Windows.Forms.Button buttonNhaCungCap;
        private System.Windows.Forms.Button buttonSanPham;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}