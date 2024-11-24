namespace QLKNCSDL
{
    partial class frm_tongiao
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
            this.dtgv_luoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matg = new System.Windows.Forms.TextBox();
            this.txt_tentg = new System.Windows.Forms.TextBox();
            this.Thoát = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xlthem = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_luoi
            // 
            this.dtgv_luoi.AllowUserToAddRows = false;
            this.dtgv_luoi.AllowUserToDeleteRows = false;
            this.dtgv_luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_luoi.Location = new System.Drawing.Point(11, 131);
            this.dtgv_luoi.Name = "dtgv_luoi";
            this.dtgv_luoi.ReadOnly = true;
            this.dtgv_luoi.Size = new System.Drawing.Size(279, 182);
            this.dtgv_luoi.TabIndex = 8;
            this.dtgv_luoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_luoi_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Tôn Giáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Tôn Giáo";
            // 
            // txt_matg
            // 
            this.txt_matg.Enabled = false;
            this.txt_matg.Location = new System.Drawing.Point(128, 45);
            this.txt_matg.Name = "txt_matg";
            this.txt_matg.Size = new System.Drawing.Size(162, 20);
            this.txt_matg.TabIndex = 0;
            // 
            // txt_tentg
            // 
            this.txt_tentg.Location = new System.Drawing.Point(128, 79);
            this.txt_tentg.Name = "txt_tentg";
            this.txt_tentg.Size = new System.Drawing.Size(162, 20);
            this.txt_tentg.TabIndex = 1;
            // 
            // Thoát
            // 
            this.Thoát.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoát.Image = global::QLKNCSDL.Properties.Resources.close;
            this.Thoát.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Thoát.Location = new System.Drawing.Point(317, 283);
            this.Thoát.Margin = new System.Windows.Forms.Padding(2);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(77, 27);
            this.Thoát.TabIndex = 7;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Enabled = false;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Image = global::QLKNCSDL.Properties.Resources.delete;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(317, 252);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(77, 27);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Enabled = false;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Image = global::QLKNCSDL.Properties.Resources.editicon;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(317, 220);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(77, 28);
            this.bt_sua.TabIndex = 5;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xlthem
            // 
            this.bt_xlthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xlthem.Image = global::QLKNCSDL.Properties.Resources.add;
            this.bt_xlthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xlthem.Location = new System.Drawing.Point(317, 125);
            this.bt_xlthem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xlthem.Name = "bt_xlthem";
            this.bt_xlthem.Size = new System.Drawing.Size(77, 29);
            this.bt_xlthem.TabIndex = 2;
            this.bt_xlthem.Text = "Thêm";
            this.bt_xlthem.UseVisualStyleBackColor = true;
            this.bt_xlthem.Click += new System.EventHandler(this.bt_xlthem_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Enabled = false;
            this.bt_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.Image = global::QLKNCSDL.Properties.Resources.cen1;
            this.bt_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_huy.Location = new System.Drawing.Point(317, 189);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(77, 27);
            this.bt_huy.TabIndex = 4;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Enabled = false;
            this.bt_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Image = global::QLKNCSDL.Properties.Resources.save;
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(317, 158);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(77, 27);
            this.bt_luu.TabIndex = 3;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // frm_tongiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 348);
            this.ControlBox = false;
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xlthem);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.txt_tentg);
            this.Controls.Add(this.txt_matg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_luoi);
            this.Name = "frm_tongiao";
            this.Text = "Quản Lý Tôn Giáo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_tongiao_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_luoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matg;
        private System.Windows.Forms.TextBox txt_tentg;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xlthem;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_luu;
    }
}