namespace QLKNCSDL
{
    partial class frm_nhanvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_phongban = new System.Windows.Forms.ComboBox();
            this.dtgv_luoi = new System.Windows.Forms.DataGridView();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.phucap = new System.Windows.Forms.Label();
            this.txt_hsl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phucap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.txt_ngayvaolam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_chuyenganh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_namsinh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbb_dantoc = new System.Windows.Forms.ComboBox();
            this.cbb_tongiao = new System.Windows.Forms.ComboBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_xlThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã Số:";
            // 
            // cbb_phongban
            // 
            this.cbb_phongban.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_phongban.FormattingEnabled = true;
            this.cbb_phongban.Location = new System.Drawing.Point(145, 8);
            this.cbb_phongban.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_phongban.Name = "cbb_phongban";
            this.cbb_phongban.Size = new System.Drawing.Size(168, 23);
            this.cbb_phongban.TabIndex = 0;
            // 
            // dtgv_luoi
            // 
            this.dtgv_luoi.AllowUserToAddRows = false;
            this.dtgv_luoi.AllowUserToDeleteRows = false;
            this.dtgv_luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_luoi.Location = new System.Drawing.Point(11, 286);
            this.dtgv_luoi.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_luoi.Name = "dtgv_luoi";
            this.dtgv_luoi.ReadOnly = true;
            this.dtgv_luoi.RowTemplate.Height = 28;
            this.dtgv_luoi.Size = new System.Drawing.Size(1450, 250);
            this.dtgv_luoi.TabIndex = 0;
            this.dtgv_luoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_luoi_CellClick);
            this.dtgv_luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_luoi_CellContentClick);
            // 
            // txt_maso
            // 
            this.txt_maso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maso.Location = new System.Drawing.Point(146, 40);
            this.txt_maso.Margin = new System.Windows.Forms.Padding(2);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.ReadOnly = true;
            this.txt_maso.Size = new System.Drawing.Size(167, 22);
            this.txt_maso.TabIndex = 1;
            // 
            // phucap
            // 
            this.phucap.AutoSize = true;
            this.phucap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phucap.Location = new System.Drawing.Point(394, 179);
            this.phucap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phucap.Name = "phucap";
            this.phucap.Size = new System.Drawing.Size(57, 15);
            this.phucap.TabIndex = 36;
            this.phucap.Text = "Phụ Cấp:";
            // 
            // txt_hsl
            // 
            this.txt_hsl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hsl.Location = new System.Drawing.Point(520, 144);
            this.txt_hsl.Margin = new System.Windows.Forms.Padding(2);
            this.txt_hsl.Name = "txt_hsl";
            this.txt_hsl.Size = new System.Drawing.Size(70, 22);
            this.txt_hsl.TabIndex = 12;
            this.txt_hsl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_hsl_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Họ Tên:";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(146, 75);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(2);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(167, 22);
            this.txt_hoten.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phòng Ban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Hệ Số Lương:";
            // 
            // txt_phucap
            // 
            this.txt_phucap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phucap.Location = new System.Drawing.Point(520, 176);
            this.txt_phucap.Name = "txt_phucap";
            this.txt_phucap.Size = new System.Drawing.Size(149, 22);
            this.txt_phucap.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Lương Thực Lãnh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ngày Vào Làm:";
            // 
            // txt_luong
            // 
            this.txt_luong.Enabled = false;
            this.txt_luong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luong.Location = new System.Drawing.Point(520, 210);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(149, 22);
            this.txt_luong.TabIndex = 14;
            // 
            // txt_ngayvaolam
            // 
            this.txt_ngayvaolam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngayvaolam.Location = new System.Drawing.Point(520, 111);
            this.txt_ngayvaolam.Name = "txt_ngayvaolam";
            this.txt_ngayvaolam.Size = new System.Drawing.Size(149, 22);
            this.txt_ngayvaolam.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Chuyên Ngành:";
            // 
            // txt_chuyenganh
            // 
            this.txt_chuyenganh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chuyenganh.Location = new System.Drawing.Point(145, 244);
            this.txt_chuyenganh.Name = "txt_chuyenganh";
            this.txt_chuyenganh.Size = new System.Drawing.Size(168, 22);
            this.txt_chuyenganh.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Địa Chỉ:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(145, 176);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(168, 22);
            this.txt_diachi.TabIndex = 5;
            // 
            // txt_namsinh
            // 
            this.txt_namsinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namsinh.Location = new System.Drawing.Point(146, 111);
            this.txt_namsinh.Name = "txt_namsinh";
            this.txt_namsinh.Size = new System.Drawing.Size(167, 22);
            this.txt_namsinh.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Năm Sinh:";
            // 
            // txt_cccd
            // 
            this.txt_cccd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cccd.Location = new System.Drawing.Point(146, 144);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(167, 22);
            this.txt_cccd.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 147);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "CCCD/CMND:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(394, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Dân Tộc :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(394, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Tôn Giáo :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(394, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "Chức Vụ :";
            // 
            // cbb_dantoc
            // 
            this.cbb_dantoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_dantoc.FormattingEnabled = true;
            this.cbb_dantoc.Location = new System.Drawing.Point(520, 8);
            this.cbb_dantoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_dantoc.Name = "cbb_dantoc";
            this.cbb_dantoc.Size = new System.Drawing.Size(149, 23);
            this.cbb_dantoc.TabIndex = 8;
            // 
            // cbb_tongiao
            // 
            this.cbb_tongiao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tongiao.FormattingEnabled = true;
            this.cbb_tongiao.Location = new System.Drawing.Point(520, 41);
            this.cbb_tongiao.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_tongiao.Name = "cbb_tongiao";
            this.cbb_tongiao.Size = new System.Drawing.Size(149, 23);
            this.cbb_tongiao.TabIndex = 9;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(520, 75);
            this.cbb_chucvu.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(149, 23);
            this.cbb_chucvu.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(597, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(299, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Lương cơ sở: 1.800.000, Bảo hiểm bắt buộc 10.5%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 214);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Số Điện Thoại:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(146, 211);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(167, 22);
            this.txt_sdt.TabIndex = 6;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Image = global::QLKNCSDL.Properties.Resources.close;
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(789, 244);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(70, 28);
            this.bt_thoat.TabIndex = 20;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Enabled = false;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Image = global::QLKNCSDL.Properties.Resources.delete;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(688, 244);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(61, 28);
            this.bt_xoa.TabIndex = 19;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Enabled = false;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Image = global::QLKNCSDL.Properties.Resources.editicon;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(617, 244);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(61, 28);
            this.bt_sua.TabIndex = 18;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Enabled = false;
            this.bt_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Image = global::QLKNCSDL.Properties.Resources.cen1;
            this.bt_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_huy.Location = new System.Drawing.Point(546, 244);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(61, 28);
            this.bt_huy.TabIndex = 17;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Enabled = false;
            this.bt_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Image = global::QLKNCSDL.Properties.Resources.save;
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(476, 244);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(61, 28);
            this.bt_luu.TabIndex = 16;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_xlThem
            // 
            this.bt_xlThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xlThem.Image = global::QLKNCSDL.Properties.Resources.add;
            this.bt_xlThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xlThem.Location = new System.Drawing.Point(397, 244);
            this.bt_xlThem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xlThem.Name = "bt_xlThem";
            this.bt_xlThem.Size = new System.Drawing.Size(70, 28);
            this.bt_xlThem.TabIndex = 15;
            this.bt_xlThem.Text = "Thêm";
            this.bt_xlThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xlThem.UseVisualStyleBackColor = true;
            this.bt_xlThem.Click += new System.EventHandler(this.bt_xlThem_Click);
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 647);
            this.ControlBox = false;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_cccd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_namsinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_chuyenganh);
            this.Controls.Add(this.txt_ngayvaolam);
            this.Controls.Add(this.txt_luong);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phucap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_hsl);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgv_luoi);
            this.Controls.Add(this.phucap);
            this.Controls.Add(this.cbb_chucvu);
            this.Controls.Add(this.cbb_tongiao);
            this.Controls.Add(this.cbb_dantoc);
            this.Controls.Add(this.cbb_phongban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_xlThem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_nhanvien";
            this.Text = "Quản Lý Nhân Sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_nhanvien_FormClosing);
            this.Load += new System.EventHandler(this.frm_nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_xlThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_phongban;
        private System.Windows.Forms.DataGridView dtgv_luoi;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Label phucap;
        private System.Windows.Forms.TextBox txt_hsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phucap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.TextBox txt_ngayvaolam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_chuyenganh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_namsinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbb_dantoc;
        private System.Windows.Forms.ComboBox cbb_tongiao;
        private System.Windows.Forms.ComboBox cbb_chucvu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_sdt;
    }
}