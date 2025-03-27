namespace QLHH_2200011643
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            radEllipse = new RadioButton();
            radTron = new RadioButton();
            radChuNhat = new RadioButton();
            groupBoxTron = new GroupBox();
            txtBanKinh = new TextBox();
            label2 = new Label();
            groupBoxChuNhat = new GroupBox();
            txtChieuDai = new TextBox();
            txtChieuRong = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBoxEllipse = new GroupBox();
            txtTrucNgan = new TextBox();
            txtTrucDai = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnThem = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            txtDanhSach = new TextBox();
            groupBox1.SuspendLayout();
            groupBoxTron.SuspendLayout();
            groupBoxChuNhat.SuspendLayout();
            groupBoxEllipse.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(608, 39);
            label1.TabIndex = 0;
            label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ HÌNH HỌC";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radEllipse);
            groupBox1.Controls.Add(radTron);
            groupBox1.Controls.Add(radChuNhat);
            groupBox1.Font = new Font("Tahoma", 10.125F);
            groupBox1.Location = new Point(28, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 154);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại hình";
            // 
            // radEllipse
            // 
            radEllipse.AutoSize = true;
            radEllipse.Font = new Font("Tahoma", 10.125F);
            radEllipse.Location = new Point(291, 67);
            radEllipse.Name = "radEllipse";
            radEllipse.Size = new Size(120, 37);
            radEllipse.TabIndex = 2;
            radEllipse.Text = "Ellipse";
            radEllipse.UseVisualStyleBackColor = true;
            radEllipse.CheckedChanged += radEllipse_CheckedChanged;
            // 
            // radTron
            // 
            radTron.AutoSize = true;
            radTron.Font = new Font("Tahoma", 10.125F);
            radTron.Location = new Point(178, 67);
            radTron.Name = "radTron";
            radTron.Size = new Size(102, 37);
            radTron.TabIndex = 1;
            radTron.Text = "Tròn";
            radTron.UseVisualStyleBackColor = true;
            radTron.CheckedChanged += radTron_CheckedChanged;
            // 
            // radChuNhat
            // 
            radChuNhat.AutoSize = true;
            radChuNhat.Checked = true;
            radChuNhat.Font = new Font("Tahoma", 10.125F);
            radChuNhat.Location = new Point(10, 67);
            radChuNhat.Name = "radChuNhat";
            radChuNhat.Size = new Size(162, 37);
            radChuNhat.TabIndex = 0;
            radChuNhat.TabStop = true;
            radChuNhat.Text = "Chữ nhật ";
            radChuNhat.UseVisualStyleBackColor = true;
            radChuNhat.CheckedChanged += radChuNhat_CheckedChanged;
            // 
            // groupBoxTron
            // 
            groupBoxTron.Controls.Add(txtBanKinh);
            groupBoxTron.Controls.Add(label2);
            groupBoxTron.Font = new Font("Tahoma", 10.125F);
            groupBoxTron.Location = new Point(475, 102);
            groupBoxTron.Name = "groupBoxTron";
            groupBoxTron.Size = new Size(355, 154);
            groupBoxTron.TabIndex = 2;
            groupBoxTron.TabStop = false;
            groupBoxTron.Text = "Hình Tròn";
            // 
            // txtBanKinh
            // 
            txtBanKinh.Font = new Font("Tahoma", 10.125F);
            txtBanKinh.Location = new Point(134, 66);
            txtBanKinh.Name = "txtBanKinh";
            txtBanKinh.Size = new Size(200, 40);
            txtBanKinh.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.125F);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(117, 33);
            label2.TabIndex = 0;
            label2.Text = "Bán kính";
            // 
            // groupBoxChuNhat
            // 
            groupBoxChuNhat.Controls.Add(txtChieuDai);
            groupBoxChuNhat.Controls.Add(txtChieuRong);
            groupBoxChuNhat.Controls.Add(label4);
            groupBoxChuNhat.Controls.Add(label3);
            groupBoxChuNhat.Font = new Font("Tahoma", 10.125F);
            groupBoxChuNhat.Location = new Point(28, 287);
            groupBoxChuNhat.Name = "groupBoxChuNhat";
            groupBoxChuNhat.Size = new Size(383, 200);
            groupBoxChuNhat.TabIndex = 3;
            groupBoxChuNhat.TabStop = false;
            groupBoxChuNhat.Text = "Hình chữ nhật";
            // 
            // txtChieuDai
            // 
            txtChieuDai.Font = new Font("Tahoma", 10.125F);
            txtChieuDai.Location = new Point(157, 55);
            txtChieuDai.Name = "txtChieuDai";
            txtChieuDai.Size = new Size(200, 40);
            txtChieuDai.TabIndex = 4;
            // 
            // txtChieuRong
            // 
            txtChieuRong.Font = new Font("Tahoma", 10.125F);
            txtChieuRong.Location = new Point(157, 116);
            txtChieuRong.Name = "txtChieuRong";
            txtChieuRong.Size = new Size(200, 40);
            txtChieuRong.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.125F);
            label4.Location = new Point(10, 123);
            label4.Name = "label4";
            label4.Size = new Size(144, 33);
            label4.TabIndex = 2;
            label4.Text = "Chiều rộng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.125F);
            label3.Location = new Point(10, 58);
            label3.Name = "label3";
            label3.Size = new Size(124, 33);
            label3.TabIndex = 1;
            label3.Text = "Chiều dài";
            // 
            // groupBoxEllipse
            // 
            groupBoxEllipse.Controls.Add(txtTrucNgan);
            groupBoxEllipse.Controls.Add(txtTrucDai);
            groupBoxEllipse.Controls.Add(label6);
            groupBoxEllipse.Controls.Add(label5);
            groupBoxEllipse.Font = new Font("Tahoma", 10.125F);
            groupBoxEllipse.Location = new Point(449, 287);
            groupBoxEllipse.Name = "groupBoxEllipse";
            groupBoxEllipse.Size = new Size(379, 200);
            groupBoxEllipse.TabIndex = 4;
            groupBoxEllipse.TabStop = false;
            groupBoxEllipse.Text = "Hình ellipse";
            // 
            // txtTrucNgan
            // 
            txtTrucNgan.Font = new Font("Tahoma", 10.125F);
            txtTrucNgan.Location = new Point(160, 116);
            txtTrucNgan.Name = "txtTrucNgan";
            txtTrucNgan.Size = new Size(200, 40);
            txtTrucNgan.TabIndex = 3;
            // 
            // txtTrucDai
            // 
            txtTrucDai.Font = new Font("Tahoma", 10.125F);
            txtTrucDai.Location = new Point(160, 51);
            txtTrucDai.Name = "txtTrucDai";
            txtTrucDai.Size = new Size(200, 40);
            txtTrucDai.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.125F);
            label6.Location = new Point(14, 123);
            label6.Name = "label6";
            label6.Size = new Size(136, 33);
            label6.TabIndex = 1;
            label6.Text = "Trực ngắn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.125F);
            label5.Location = new Point(14, 58);
            label5.Name = "label5";
            label5.Size = new Size(112, 33);
            label5.TabIndex = 0;
            label5.Text = "Trực dài";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Tahoma", 10.125F);
            btnThem.Location = new Point(50, 511);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(139, 46);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Tahoma", 10.125F);
            btnNhap.Location = new Point(236, 511);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(128, 46);
            btnNhap.TabIndex = 6;
            btnNhap.Text = "Nhập lại";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Tahoma", 10.125F);
            btnLuu.Location = new Point(415, 511);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 46);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu file";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Tahoma", 10.125F);
            btnThoat.Location = new Point(635, 511);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 46);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtDanhSach
            // 
            txtDanhSach.Font = new Font("Tahoma", 10.125F);
            txtDanhSach.Location = new Point(38, 579);
            txtDanhSach.Multiline = true;
            txtDanhSach.Name = "txtDanhSach";
            txtDanhSach.Size = new Size(790, 259);
            txtDanhSach.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 863);
            Controls.Add(txtDanhSach);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(btnNhap);
            Controls.Add(btnThem);
            Controls.Add(groupBoxEllipse);
            Controls.Add(groupBoxChuNhat);
            Controls.Add(groupBoxTron);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "2200011643-Đặng Hoàng Quân";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxTron.ResumeLayout(false);
            groupBoxTron.PerformLayout();
            groupBoxChuNhat.ResumeLayout(false);
            groupBoxChuNhat.PerformLayout();
            groupBoxEllipse.ResumeLayout(false);
            groupBoxEllipse.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBoxTron;
        private GroupBox groupBoxChuNhat;
        private GroupBox groupBoxEllipse;
        private Button btnThem;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnThoat;
        private TextBox txtDanhSach;
        private RadioButton radEllipse;
        private RadioButton radTron;
        private RadioButton radChuNhat;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtBanKinh;
        private TextBox txtChieuDai;
        private TextBox txtChieuRong;
        private TextBox txtTrucNgan;
        private TextBox txtTrucDai;
    }
}
