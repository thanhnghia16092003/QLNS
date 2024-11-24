namespace QLKNCSDL
{
    partial class frm_thidua
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_lydo = new System.Windows.Forms.TextBox();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.cbb_hoten = new System.Windows.Forms.ComboBox();
            this.dtgv_luoi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_maso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_xlThem = new System.Windows.Forms.Button();
            this.txt_ngaythang = new System.Windows.Forms.DateTimePicker();
            this.txt_phongban = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Họ Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nội Dung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lý Do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phòng Ban:";
            // 
            // txt_lydo
            // 
            this.txt_lydo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lydo.Location = new System.Drawing.Point(546, 54);
            this.txt_lydo.Name = "txt_lydo";
            this.txt_lydo.Size = new System.Drawing.Size(210, 22);
            this.txt_lydo.TabIndex = 4;
            // 
            // txt_noidung
            // 
            this.txt_noidung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noidung.Location = new System.Drawing.Point(546, 14);
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(210, 22);
            this.txt_noidung.TabIndex = 3;
            // 
            // cbb_hoten
            // 
            this.cbb_hoten.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_hoten.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbb_hoten.FormattingEnabled = true;
            this.cbb_hoten.Location = new System.Drawing.Point(187, 54);
            this.cbb_hoten.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_hoten.Name = "cbb_hoten";
            this.cbb_hoten.Size = new System.Drawing.Size(146, 23);
            this.cbb_hoten.TabIndex = 1;
            this.cbb_hoten.Text = "Chọn nhân viên...";
            // 
            // dtgv_luoi
            // 
            this.dtgv_luoi.AllowUserToAddRows = false;
            this.dtgv_luoi.AllowUserToDeleteRows = false;
            this.dtgv_luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_luoi.Location = new System.Drawing.Point(12, 215);
            this.dtgv_luoi.Name = "dtgv_luoi";
            this.dtgv_luoi.ReadOnly = true;
            this.dtgv_luoi.Size = new System.Drawing.Size(806, 193);
            this.dtgv_luoi.TabIndex = 12;
            this.dtgv_luoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_luoi_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã Số Khen thưởng";
            // 
            // txt_maso
            // 
            this.txt_maso.Enabled = false;
            this.txt_maso.Location = new System.Drawing.Point(187, 14);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new System.Drawing.Size(146, 22);
            this.txt_maso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ngày/Tháng/ Năm";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Image = global::QLKNCSDL.Properties.Resources.close;
            this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thoat.Location = new System.Drawing.Point(528, 168);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(82, 32);
            this.bt_thoat.TabIndex = 11;
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
            this.bt_xoa.Location = new System.Drawing.Point(403, 168);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(71, 32);
            this.bt_xoa.TabIndex = 10;
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
            this.bt_sua.Location = new System.Drawing.Point(328, 168);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(71, 32);
            this.bt_sua.TabIndex = 9;
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
            this.bt_huy.Location = new System.Drawing.Point(253, 168);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(71, 32);
            this.bt_huy.TabIndex = 8;
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
            this.bt_luu.Location = new System.Drawing.Point(178, 168);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(71, 32);
            this.bt_luu.TabIndex = 7;
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
            this.bt_xlThem.Location = new System.Drawing.Point(103, 168);
            this.bt_xlThem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xlThem.Name = "bt_xlThem";
            this.bt_xlThem.Size = new System.Drawing.Size(71, 32);
            this.bt_xlThem.TabIndex = 6;
            this.bt_xlThem.Text = "Thêm";
            this.bt_xlThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xlThem.UseVisualStyleBackColor = true;
            this.bt_xlThem.Click += new System.EventHandler(this.bt_xlThem_Click);
            // 
            // txt_ngaythang
            // 
            this.txt_ngaythang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_ngaythang.Location = new System.Drawing.Point(546, 97);
            this.txt_ngaythang.Name = "txt_ngaythang";
            this.txt_ngaythang.Size = new System.Drawing.Size(114, 22);
            this.txt_ngaythang.TabIndex = 5;
            // 
            // txt_phongban
            // 
            this.txt_phongban.Enabled = false;
            this.txt_phongban.Location = new System.Drawing.Point(187, 97);
            this.txt_phongban.Name = "txt_phongban";
            this.txt_phongban.Size = new System.Drawing.Size(146, 22);
            this.txt_phongban.TabIndex = 3;
            // 
            // frm_thidua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 420);
            this.ControlBox = false;
            this.Controls.Add(this.txt_ngaythang);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_xlThem);
            this.Controls.Add(this.dtgv_luoi);
            this.Controls.Add(this.cbb_hoten);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.txt_phongban);
            this.Controls.Add(this.txt_noidung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lydo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_thidua";
            this.Text = "Quản lý thi đua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_thidua_FormClosing);
            this.Load += new System.EventHandler(this.frm_thidua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_lydo;
        private System.Windows.Forms.TextBox txt_noidung;
        private System.Windows.Forms.ComboBox cbb_hoten;
        private System.Windows.Forms.DataGridView dtgv_luoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_maso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_xlThem;
        private System.Windows.Forms.DateTimePicker txt_ngaythang;
        private System.Windows.Forms.TextBox txt_phongban;
    }
}