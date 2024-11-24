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
    public partial class frm_thidua : Form
    {
        TV_KNCSL tv;
        public frm_thidua()
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
         /*   DataTable bang = new DataTable();
            string str = "select * from TB_PhongBan";
            bang = tv.Docdulieu(str);

            cbb_phongban.DataSource = bang;
            cbb_phongban.DisplayMember = "TenPhongBan";
            cbb_phongban.ValueMember = "MaPB";
           */ 
            DataTable bang2 = new DataTable();
            string str2 = "select * from TB_NhanVien";
            bang2 = tv.Docdulieu(str2);

            cbb_hoten.DataSource = bang2;
            cbb_hoten.DisplayMember = "Ho_Ten";
            cbb_hoten.ValueMember = "MSNV";
           
            string str6 = "select TB_ThiDua.MaTD as 'Mã Thi đua', TB_NhanVien.Ho_Ten as 'Họ Tên', TB_PhongBan.TenPhongBan as 'Phòng Ban', TB_ChucVu.TenCV as 'Chức Vụ', TB_ThiDua.NoiDung as 'Nội Dung', TB_ThiDua.LyDo as 'Lý Do', TB_ThiDua.NgayThangNam as 'Ngày/Tháng' from TB_NhanVien, TB_PhongBan,TB_ChucVu,TB_ThiDua where TB_NhanVien.MaPB= TB_PhongBan.MaPB and TB_NhanVien.MaCV=TB_ChucVu.MaCV and TB_NhanVien.MSNV=TB_ThiDua.MSNV";
            bang2 = tv.Docdulieu(str6);

            
            //Hien thi du lieu ra DataGridView       
            dtgv_luoi.DataSource = bang2;
            
        }
        private void frm_thidua_FormClosing(object sender, FormClosingEventArgs e)
        {
            tv.DongKetNoi();
        }

        private void frm_thidua_Load(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_xlThem_Click(object sender, EventArgs e)
        {
            bt_huy.Enabled = true;
            bt_luu.Enabled = true;
            bt_thoat.Enabled = false;
            bt_xoa.Enabled = false;
            bt_sua.Enabled = false;
            bt_xlThem.Enabled = false;
           
            txt_maso.Enabled = true;
            cbb_hoten.Text = "Chọn nhân viên...";
            txt_maso.Text = "";
            txt_lydo.Text = "";
            txt_noidung.Text = "";
            txt_phongban.Text = "";    
            txt_maso.Focus();
           
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            string str = "insert into TB_ThiDua values('" + txt_maso.Text.Trim() + "', N'" + txt_noidung.Text.Trim() + "', N'" + txt_lydo.Text.Trim() + "', N'" + txt_ngaythang.Text.Trim() + "','" + cbb_hoten.SelectedValue.ToString().Trim() + "')";

            tv.CapNhatDL(str);
            HienThiDL();

            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            bt_thoat.Enabled = true;
            bt_xlThem.Enabled = true;
            txt_maso.Text = "";
            txt_phongban.Text = "";
            txt_noidung.Text = "";
            txt_lydo.Text = "";
            
            txt_maso.Enabled = false;
            
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            bt_thoat.Enabled = true;
            bt_xlThem.Enabled = true;
            txt_maso.Text = "";
            cbb_hoten.Text = "Chọn nhân viên...";
            //cbb_phongban.Text = "";            
            txt_noidung.Text = "";
            txt_lydo.Text = "";           
            txt_maso.Enabled = false;
            cbb_hoten.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string str = "update TB_ThiDua set NoiDung= N'" + txt_noidung.Text.Trim() + "', LyDo= N'" + txt_lydo.Text.Trim() + "', NgayThangNam= N'" + txt_ngaythang.Text.Trim() + "', MSNV= N'" + cbb_hoten.SelectedValue.ToString().Trim() + "' where MaTD= '" + txt_maso.Text.Trim() + "'";
            tv.CapNhatDL(str);
            HienThiDL();
            
        }
       
       

        private void dtgv_luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maso.Text = dtgv_luoi[0, e.RowIndex].Value.ToString();
            cbb_hoten.Text = dtgv_luoi[1, e.RowIndex].Value.ToString();
            //cbb_phongban.Text = dtgv_luoi[2, e.RowIndex].Value.ToString();
            txt_phongban.Text = dtgv_luoi[2, e.RowIndex].Value.ToString();
            txt_noidung.Text = dtgv_luoi[4, e.RowIndex].Value.ToString();
            txt_lydo.Text = dtgv_luoi[5, e.RowIndex].Value.ToString();


            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            txt_maso.Enabled = false;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string str = "delete from TB_ThiDua where MaTD= '" + txt_maso.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }
    }
}
