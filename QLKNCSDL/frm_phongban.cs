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
    public partial class frm_phongban : Form
    {
        TV_KNCSL tv;
        public frm_phongban()
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
            string str = "select MaPB as 'Mã Phòng',TenPhongBan as 'Tên Phòng' from TB_PhongBan";
            bang = tv.Docdulieu(str);

            // cbb_hienthi.DataSource = bang;
            //cbb_hienthi.DisplayMember = "TenPhongBan";
            // cbb_hienthi.ValueMember = "MaPB";
            //Hien thi du lieu ra DataGridView
            dtgv_luoi.DataSource = bang;
        }

        private void dtgv_luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_mapb.Text = dtgv_luoi[0, e.RowIndex].Value.ToString();
                txt_tenpb.Text = dtgv_luoi[1, e.RowIndex].Value.ToString();
                bt_sua.Enabled = true;
                bt_xoa.Enabled = true;
                txt_mapb.Enabled = false;

            }
            catch { }
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_xlthem_Click(object sender, EventArgs e)
        {
            txt_mapb.Enabled = true;
            txt_tenpb.Enabled = true;
            bt_huy.Enabled = true;
            bt_luu.Enabled = true;
            Thoát.Enabled = false;
            bt_xlthem.Enabled = false;
            txt_mapb.Text = "";
            txt_tenpb.Text = "";
            txt_mapb.Focus();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string str = "insert into TB_PhongBan values('" + txt_mapb.Text.Trim() + "', N'" + txt_tenpb.Text.Trim() + "')";
            tv.CapNhatDL(str);
            HienThiDL();

            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            Thoát.Enabled = true;
            bt_xlthem.Enabled = true;
            txt_mapb.Text = "";
            txt_tenpb.Text = "";
            txt_mapb.Enabled = false;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            Thoát.Enabled = true;
            bt_xlthem.Enabled = true;
            txt_mapb.Text = "";
            txt_tenpb.Text = "";
            txt_mapb.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string str = "update TB_PhongBan set TenPhongBan= N'" + txt_tenpb.Text.Trim() + "' where MaPB= '" + txt_mapb.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string str = "delete from TB_PhongBan where MaPB= '" + txt_mapb.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }

        private void frm_phongban_FormClosing(object sender, FormClosingEventArgs e)
        {
            tv.DongKetNoi();
        }
    }
}
