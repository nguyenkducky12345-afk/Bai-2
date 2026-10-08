namespace Bai_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtNguoiYeuCau;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.GroupBox groupBoxMucDo;
        private System.Windows.Forms.RadioButton rbKhanCap;
        private System.Windows.Forms.RadioButton rbTrungBinh;
        private System.Windows.Forms.RadioButton rbThap;
        private System.Windows.Forms.ComboBox cbLoaiSuCo;
        private System.Windows.Forms.CheckBox chkMayTinhBan;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkMayIn;
        private System.Windows.Forms.CheckBox chkDienThoai;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBoxMucDo = new System.Windows.Forms.GroupBox();
            this.rbKhanCap = new System.Windows.Forms.RadioButton();
            this.rbTrungBinh = new System.Windows.Forms.RadioButton();
            this.rbThap = new System.Windows.Forms.RadioButton();
            this.cbLoaiSuCo = new System.Windows.Forms.ComboBox();
            this.chkMayTinhBan = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkMayIn = new System.Windows.Forms.CheckBox();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.groupBoxMucDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(120, 15);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(200, 22);
            this.txtMaPhieu.TabIndex = 0;
            // 
            // txtNguoiYeuCau
            // 
            this.txtNguoiYeuCau.Location = new System.Drawing.Point(120, 45);
            this.txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            this.txtNguoiYeuCau.Size = new System.Drawing.Size(200, 22);
            this.txtNguoiYeuCau.TabIndex = 1;
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(120, 75);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(120, 22);
            this.dtpNgay.TabIndex = 2;
            // 
            // groupBoxMucDo
            // 
            this.groupBoxMucDo.Controls.Add(this.rbKhanCap);
            this.groupBoxMucDo.Controls.Add(this.rbTrungBinh);
            this.groupBoxMucDo.Controls.Add(this.rbThap);
            this.groupBoxMucDo.Location = new System.Drawing.Point(15, 110);
            this.groupBoxMucDo.Name = "groupBoxMucDo";
            this.groupBoxMucDo.Size = new System.Drawing.Size(305, 50);
            this.groupBoxMucDo.TabIndex = 3;
            this.groupBoxMucDo.TabStop = false;
            this.groupBoxMucDo.Text = "Mức độ ưu tiên";
            // 
            // rbKhanCap
            // 
            this.rbKhanCap.AutoSize = true;
            this.rbKhanCap.Location = new System.Drawing.Point(210, 20);
            this.rbKhanCap.Name = "rbKhanCap";
            this.rbKhanCap.Size = new System.Drawing.Size(75, 21);
            this.rbKhanCap.TabIndex = 2;
            this.rbKhanCap.Text = "Khẩn cấp";
            this.rbKhanCap.UseVisualStyleBackColor = true;
            // 
            // rbTrungBinh
            // 
            this.rbTrungBinh.AutoSize = true;
            this.rbTrungBinh.Location = new System.Drawing.Point(105, 20);
            this.rbTrungBinh.Name = "rbTrungBinh";
            this.rbTrungBinh.Size = new System.Drawing.Size(97, 21);
            this.rbTrungBinh.TabIndex = 1;
            this.rbTrungBinh.Text = "Trung bình";
            this.rbTrungBinh.UseVisualStyleBackColor = true;
            // 
            // rbThap
            // 
            this.rbThap.AutoSize = true;
            this.rbThap.Location = new System.Drawing.Point(10, 20);
            this.rbThap.Name = "rbThap";
            this.rbThap.Size = new System.Drawing.Size(57, 21);
            this.rbThap.TabIndex = 0;
            this.rbThap.Text = "Thấp";
            this.rbThap.UseVisualStyleBackColor = true;
            // 
            // cbLoaiSuCo
            // 
            this.cbLoaiSuCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSuCo.FormattingEnabled = true;
            this.cbLoaiSuCo.Items.AddRange(new object[] {
            "Phần cứng",
            "Phần mềm",
            "Mạng",
            "Tài khoản"});
            this.cbLoaiSuCo.Location = new System.Drawing.Point(120, 175);
            this.cbLoaiSuCo.Name = "cbLoaiSuCo";
            this.cbLoaiSuCo.Size = new System.Drawing.Size(200, 24);
            this.cbLoaiSuCo.TabIndex = 4;
            // 
            // chkMayTinhBan
            // 
            this.chkMayTinhBan.AutoSize = true;
            this.chkMayTinhBan.Location = new System.Drawing.Point(15, 215);
            this.chkMayTinhBan.Name = "chkMayTinhBan";
            this.chkMayTinhBan.Size = new System.Drawing.Size(117, 21);
            this.chkMayTinhBan.TabIndex = 5;
            this.chkMayTinhBan.Text = "Máy tính bàn";
            this.chkMayTinhBan.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(140, 215);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(74, 21);
            this.chkLaptop.TabIndex = 6;
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            this.chkMayIn.AutoSize = true;
            this.chkMayIn.Location = new System.Drawing.Point(220, 215);
            this.chkMayIn.Name = "chkMayIn";
            this.chkMayIn.Size = new System.Drawing.Size(72, 21);
            this.chkMayIn.TabIndex = 7;
            this.chkMayIn.Text = "Máy in";
            this.chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkDienThoai
            // 
            this.chkDienThoai.AutoSize = true;
            this.chkDienThoai.Location = new System.Drawing.Point(15, 245);
            this.chkDienThoai.Name = "chkDienThoai";
            this.chkDienThoai.Size = new System.Drawing.Size(95, 21);
            this.chkDienThoai.TabIndex = 8;
            this.chkDienThoai.Text = "Điện thoại";
            this.chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(350, 15);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(420, 300);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 9;
            this.picAnh.TabStop = false;
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Location = new System.Drawing.Point(350, 325);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(120, 30);
            this.btnTaiAnh.TabIndex = 10;
            this.btnTaiAnh.Text = "Tải ảnh lỗi";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(640, 325);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(130, 30);
            this.btnGui.TabIndex = 11;
            this.btnGui.Text = "Gửi yêu cầu";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(500, 325);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(120, 30);
            this.btnNhapLai.TabIndex = 12;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Người yêu cầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày ghi nhận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Loại sự cố";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnTaiAnh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.chkDienThoai);
            this.Controls.Add(this.chkMayIn);
            this.Controls.Add(this.chkLaptop);
            this.Controls.Add(this.chkMayTinhBan);
            this.Controls.Add(this.cbLoaiSuCo);
            this.Controls.Add(this.groupBoxMucDo);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtNguoiYeuCau);
            this.Controls.Add(this.txtMaPhieu);
            this.Name = "Form1";
            this.Text = "Form Tiếp nhận - IT Support Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.groupBoxMucDo.ResumeLayout(false);
            this.groupBoxMucDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

