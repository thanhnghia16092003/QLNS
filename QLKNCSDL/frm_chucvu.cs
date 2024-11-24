using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QLKNCSDL
{
    
    public partial class frm_chucvu : Form
    {
        TV_KNCSL tv;
        public frm_chucvu()
        {
            InitializeComponent();
            tv = new TV_KNCSL();

            if (tv.MoKetNoi())
            {
                // MessageBox.Show("Ket Noi Thanh Cong","Thong Bao");
                HienThiDL();



            }
            else
            {
                MessageBox.Show("Khong Mo Duoc Ket Noi", "Thong Bao");
            }
        }
        void HienThiDL()
        {
            DataTable bang = new DataTable();
            string str = "select MaCV as 'Mã Chức Vụ',TenCV as 'Tên Chức Vụ' from TB_ChucVu";
            bang = tv.Docdulieu(str);

            // cbb_hienthi.DataSource = bang;
            //cbb_hienthi.DisplayMember = "TenPhongBan";
            // cbb_hienthi.ValueMember = "MaPB";
            //Hien thi du lieu ra DataGridView
            dtgv_luoi.DataSource = bang;
        }
        private void frm_chucvu_FormClosing(object sender, FormClosingEventArgs e)
        {
            tv.DongKetNoi();
        }

        private void bt_xlthem_Click(object sender, EventArgs e)
        {
            txt_macv.Enabled = true;
            txt_tencv.Enabled = true;
            bt_huy.Enabled = true;
            bt_luu.Enabled = true;
            Thoát.Enabled = false;
            bt_xlthem.Enabled = false;
            txt_macv.Text = "";
            txt_tencv.Text = "";
            txt_macv.Focus();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {

            string str = "insert into TB_ChucVu values('" + txt_macv.Text.Trim() + "', N'" + txt_tencv.Text.Trim() + "')";
            tv.CapNhatDL(str);
            HienThiDL();

            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            Thoát.Enabled = true;
            bt_xlthem.Enabled = true;
            txt_macv.Text = "";
            txt_tencv.Text = "";
            txt_macv.Enabled = false;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            Thoát.Enabled = true;
            bt_xlthem.Enabled = true;
            txt_macv.Text = "";
            txt_tencv.Text = "";
            txt_macv.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string str = "update TB_ChucVu set TenCV= N'" + txt_tencv.Text.Trim() + "' where MaCV= '" + txt_macv.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string str = "delete from TB_ChucVu where MaCV= '" + txt_macv.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_macv.Text = dtgv_luoi[0, e.RowIndex].Value.ToString();
                txt_tencv.Text = dtgv_luoi[1, e.RowIndex].Value.ToString();
                bt_sua.Enabled = true;
                bt_xoa.Enabled = true;
                txt_macv.Enabled = false;

            }
            catch { }
        }

        private void dtgv_luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
