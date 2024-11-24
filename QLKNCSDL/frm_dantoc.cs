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
    public partial class frm_dantoc : Form
    {
        TV_KNCSL tv;
        public frm_dantoc()
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
            string str = "select MaDT as 'Mã Dân Tộc',TenDT as 'Tên Dân Tộc' from TB_DanToc";
            bang = tv.Docdulieu(str);

            // cbb_hienthi.DataSource = bang;
            //cbb_hienthi.DisplayMember = "TenPhongBan";
            // cbb_hienthi.ValueMember = "MaPB";
            //Hien thi du lieu ra DataGridView
            dtgv_luoi.DataSource = bang;
        }

        private void frm_dantoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            tv.DongKetNoi();
        }

        private void bt_xlthem_Click(object sender, EventArgs e)
        {
            txt_madt.Enabled = true;
            txt_tendt.Enabled = true;
            bt_huy.Enabled = true;
            bt_luu.Enabled = true;
            Thoát.Enabled = false;
            bt_xlthem.Enabled = false;
            txt_madt.Text = "";
            txt_tendt.Text = "";
            txt_madt.Focus();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {

            string str = "insert into TB_DanToc values('" + txt_madt.Text.Trim() + "', N'" + txt_tendt.Text.Trim() + "')";
            tv.CapNhatDL(str);
            HienThiDL();

            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            Thoát.Enabled = true;
            bt_xlthem.Enabled = true;
            txt_madt.Text = "";
            txt_tendt.Text = "";
            txt_madt.Enabled = false;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            Thoát.Enabled = true;
            bt_xlthem.Enabled = true;
            txt_madt.Text = "";
            txt_tendt.Text = "";
            txt_madt.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            txt_tendt.Enabled = true;
            string str = "update TB_DanToc set TenDT= N'" + txt_tendt.Text.Trim() + "' where MaDT= '" + txt_madt.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string str = "delete from TB_DanToc where MaDT= '" + txt_madt.Text.Trim() + "'";

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
                txt_madt.Text = dtgv_luoi[0, e.RowIndex].Value.ToString();
                txt_tendt.Text = dtgv_luoi[1, e.RowIndex].Value.ToString();
                bt_sua.Enabled = true;
                bt_xoa.Enabled = true;
                txt_madt.Enabled = false;

            }
            catch { }
        }
    }
}
