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
using ms = Microsoft.Office.Interop.Excel;

namespace QLKNCSDL
{
    public partial class frm_chinh : Form
    {
        public frm_chinh()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_nhanvien tb = new frm_nhanvien();
            tb.ShowDialog();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_phongban tb = new frm_phongban();
            tb.ShowDialog();
        }



        private void dânTộcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_dantoc tb = new frm_dantoc();
            tb.ShowDialog();
        }

        private void tônGiáoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_tongiao tb = new frm_tongiao();
            tb.ShowDialog();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_chucvu tb = new frm_chucvu();
            tb.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đồ án: Phần mềm quản lý nhân sự.\n\n Nhóm sinh viên thực hiện: \n1. Trần Vạn Kiếp\n2. Trần Thị Kiều My\n3. Phúa Thị Kim Luông", "Giới thiệu");
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_baocao frm= new frm_baocao();
            frm.ShowDialog();
            // new Reports.Frm_Report_LuongThucLanh().Show();
            // lenh.CommandType = CommandType.StoredProcedure;
            //  lenh.CommandTest = "spBaoCao";
           //   lenh.Parameters.Clear();
           //   lenh.Parameters.AddWithValue("@MSNV", frm_nhanvien.txt_maso.text);

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thiĐuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thidua tb = new frm_thidua();
            tb.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frm_chinh_Load(object sender, EventArgs e)
        {

        }
    }
}