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
    public partial class frm_tongiao : Form
    {
        TV_KNCSL tv;
        public frm_tongiao()
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
            string str = "select MaTG as 'Mã Tôn Giáo',TenTG as 'Tên Tôn Giáo' from TB_TonGiao";
            bang = tv.Docdulieu(str);

            // cbb_hienthi.DataSource = bang;
            //cbb_hienthi.DisplayMember = "TenPhongBan";
            // cbb_hienthi.ValueMember = "MaPB";
            //Hien thi du lieu ra DataGridView
            dtgv_luoi.DataSource = bang;
        }
        private void frm_tongiao_FormClosing(object sender, FormClosingEventArgs e)
        {
            tv.DongKetNoi();
        }

        private void dtgv_luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_matg.Text = dtgv_luoi[0, e.RowIndex].Value.ToString();
                txt_tentg.Text = dtgv_luoi[1, e.RowIndex].Value.ToString();
                bt_sua.Enabled = true;
                bt_xoa.Enabled = true;
                txt_matg.Enabled=false;
               

            }
            catch { }
        }

        private void bt_xlthem_Click(object sender, EventArgs e)
        {
            bt_huy.Enabled = true;
            bt_luu.Enabled = true;
            Thoát.Enabled = false;
            bt_xlthem.Enabled = false;
            txt_matg.Text = "";
            txt_tentg.Text = "";
            txt_matg.Enabled = true;
            txt_tentg.Enabled = true;
           txt_matg.Focus();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string str = "insert into TB_TonGiao values('" + txt_matg.Text.Trim() + "', N'" + txt_tentg.Text.Trim() + "')";
            tv.CapNhatDL(str);
            HienThiDL();

            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            Thoát.Enabled = true;
            bt_xlthem.Enabled = true;
            txt_matg.Text = "";
            txt_tentg.Text = "";
            txt_matg.Enabled = false;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            Thoát.Enabled = true;
            bt_xlthem.Enabled = true;
            txt_matg.Text = "";
            txt_tentg.Text = "";
            txt_matg.Enabled = false;

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string str = "update TB_TonGiao set TenTG= N'" + txt_tentg.Text.Trim() + "' where MaTG= '" + txt_matg.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string str = "delete from TB_TonGiao where MaTG= '" + txt_matg.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
