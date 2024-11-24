namespace QLKNCSDL
{
    partial class frm_dantoc
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
            this.Thoát = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xlthem = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            this.txt_tendt = new System.Windows.Forms.TextBox();
            this.txt_madt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_luoi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // Thoát
            // 
            this.Thoát.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoát.Image = global::QLKNCSDL.Properties.Resources.close;
            this.Thoát.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Thoát.Location = new System.Drawing.Point(320, 268);
            this.Thoát.Margin = new System.Windows.Forms.Padding(2);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(77, 31);
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
            this.bt_xoa.Location = new System.Drawing.Point(320, 237);
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
            this.bt_sua.Location = new System.Drawing.Point(320, 204);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(77, 29);
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
            this.bt_xlthem.Location = new System.Drawing.Point(320, 105);
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
            this.bt_huy.Location = new System.Drawing.Point(320, 171);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(2);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(77, 29);
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
            this.bt_luu.Location = new System.Drawing.Point(320, 138);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(2);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(77, 29);
            this.bt_luu.TabIndex = 3;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // txt_tendt
            // 
            this.txt_tendt.Location = new System.Drawing.Point(125, 78);
            this.txt_tendt.Name = "txt_tendt";
            this.txt_tendt.Size = new System.Drawing.Size(168, 20);
            this.txt_tendt.TabIndex = 1;
            // 
            // txt_madt
            // 
            this.txt_madt.Enabled = false;
            this.txt_madt.Location = new System.Drawing.Point(125, 51);
            this.txt_madt.Name = "txt_madt";
            this.txt_madt.Size = new System.Drawing.Size(168, 20);
            this.txt_madt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Dân Tộc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Dân Tộc:";
            // 
            // dtgv_luoi
            // 
            this.dtgv_luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_luoi.Location = new System.Drawing.Point(14, 117);
            this.dtgv_luoi.Name = "dtgv_luoi";
            this.dtgv_luoi.Size = new System.Drawing.Size(279, 182);
            this.dtgv_luoi.TabIndex = 8;
            this.dtgv_luoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_luoi_CellClick);
            // 
            // frm_dantoc
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
            this.Controls.Add(this.txt_tendt);
            this.Controls.Add(this.txt_madt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_luoi);
            this.Name = "frm_dantoc";
            this.Text = "Quản Lý Dân Tộc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_dantoc_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xlthem;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_tendt;
        public System.Windows.Forms.TextBox txt_madt;
        public System.Windows.Forms.DataGridView dtgv_luoi;
    }
}