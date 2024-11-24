namespace QLKNCSDL
{
    partial class frm_baocao
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_luoi
            // 
            this.dtgv_luoi.AllowUserToAddRows = false;
            this.dtgv_luoi.AllowUserToDeleteRows = false;
            this.dtgv_luoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_luoi.Location = new System.Drawing.Point(1, 97);
            this.dtgv_luoi.Name = "dtgv_luoi";
            this.dtgv_luoi.ReadOnly = true;
            this.dtgv_luoi.Size = new System.Drawing.Size(1153, 240);
            this.dtgv_luoi.TabIndex = 2;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = global::QLKNCSDL.Properties.Resources.close;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(269, 29);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(86, 28);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Image = global::QLKNCSDL.Properties.Resources.iconprint;
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Location = new System.Drawing.Point(12, 28);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(210, 29);
            this.btn_in.TabIndex = 0;
            this.btn_in.Text = "Xuất Danh Sách Nhân Sự";
            this.btn_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // frm_baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 391);
            this.ControlBox = false;
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.dtgv_luoi);
            this.Name = "frm_baocao";
            this.Text = "Báo Cáo Nhân Sự";
            this.Load += new System.EventHandler(this.frm_baocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_luoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_luoi;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_thoat;
    }
}