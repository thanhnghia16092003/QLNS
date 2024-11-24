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
    public partial class frm_baocao : Form
    {
        clthaotac tt = new clthaotac();
        TV_KNCSL tv;
        public frm_baocao()
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
            string str = "select MSNV as'Mã NV', Ho_Ten as'Họ Tên', NamSinh as'Năm Sinh', CCCD as'CCCD/CMND', DiaChi as'Địa Chỉ',SDT as'Số Điện Thoại', ChuyenNganh as'Ngành', ((HSL * 1800000-HSL * 1800000/100*10.5) + phucap) as Lương, TenPhongBan as'Phòng Ban', TenCV as'Chức Vụ', NgayVaoLam as'Ngày Vào' from TB_NhanVien,TB_PhongBan,TB_ChucVu where TB_NhanVien.MaPB=TB_PhongBan.MaPB and TB_NhanVien.MaCV=TB_ChucVu.MaCV ";
            bang = tv.Docdulieu(str);
                       
            dtgv_luoi.DataSource = bang;
        }


        private void frm_baocao_Load(object sender, EventArgs e)
        {
         
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {            
        }   

        private void btn_in_Click(object sender, EventArgs e)
        {
            tv.ExportExcel(dtgv_luoi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

