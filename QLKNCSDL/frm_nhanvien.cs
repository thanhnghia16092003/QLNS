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
    public partial class frm_nhanvien : Form
    {
        TV_KNCSL tv;

        public frm_nhanvien()
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
            string str = "select * from TB_PhongBan";
            bang = tv.Docdulieu(str);

            cbb_phongban.DataSource = bang;
            cbb_phongban.DisplayMember = "TenPhongBan";
            cbb_phongban.ValueMember = "MaPB";

            DataTable bang2 = new DataTable();
            string str2 = "select * from TB_DanToc";
            bang2 = tv.Docdulieu(str2);

            cbb_dantoc.DataSource = bang2;
            cbb_dantoc.DisplayMember = "TenDT";
            cbb_dantoc.ValueMember = "MaDT";

            DataTable bang3 = new DataTable();
            string str3 = "select * from TB_TonGiao";
            bang3 = tv.Docdulieu(str3);

            cbb_tongiao.DataSource = bang3;
            cbb_tongiao.DisplayMember = "TenTG";
            cbb_tongiao.ValueMember = "MaTG";

            DataTable bang4 = new DataTable();
            string str4 = "select * from TB_ChucVu";
            bang4 = tv.Docdulieu(str4);

            cbb_chucvu.DataSource = bang4;
            cbb_chucvu.DisplayMember = "TenCV";
            cbb_chucvu.ValueMember = "MaCV";





            string str6 = "select TB_NhanVien.MSNV as 'Mã Số NV', TB_NhanVien.Ho_Ten as 'Họ Tên', TB_NhanVien.NamSinh as 'Năm Sinh', TB_NhanVien.CCCD as'CCCD/CMND',TB_NhanVien.SDT as'Số Điện Thoại', TB_NhanVien.DiaChi as'Địa Chỉ', TB_NhanVien.ChuyenNganh as'Ngành', TB_NhanVien.HSL as 'Hệ Số Lương', TB_NhanVien.PhuCap as'Phụ Cấp', TB_DanToc.TenDT as'Dân Tộc', TB_TonGiao.TenTG as'Tôn Giáo', TB_PhongBan.TenPhongBan as 'Phòng Ban', TB_ChucVu.TenCV as'Chức Vụ', TB_NhanVien.NgayVaoLam as'Ngày Vào' from TB_NhanVien, TB_PhongBan,TB_TonGiao,TB_ChucVu,TB_DanToc where TB_NhanVien.MaPB= TB_PhongBan.MaPB and TB_NhanVien.MaDT=TB_DanToc.MaDT and TB_NhanVien.MaTG=TB_TonGiao.MaTG and TB_NhanVien.MaCV=TB_ChucVu.MaCV";
            bang = tv.Docdulieu(str6);
           

            //Hien thi du lieu ra DataGridView       
            dtgv_luoi.DataSource = bang;

        }


        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_nhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            tv.DongKetNoi();
        }

        private void bt_xlThem_Click(object sender, EventArgs e)
        {           
            bt_huy.Enabled = true;
            bt_luu.Enabled = true;
            bt_thoat.Enabled = false;
            bt_xlThem.Enabled = false;
            txt_maso.ReadOnly = false;
            txt_maso.Enabled = true;
            txt_maso.Text = "";
            txt_hoten.Text = "";
            txt_namsinh.Text = "";
            txt_cccd.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_chuyenganh.Text = "";
            txt_ngayvaolam.Text = "";
            txt_phucap.Text = "";
            txt_hsl.Text = "";            
            txt_maso.Focus();
           
        }
       
        private void bt_luu_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Bạn Chọn Phòng Ban : "+cbb_phongban.SelectedValue.ToString(), "Thông Báo!!!");

            string str = "insert into TB_NhanVien values('" + txt_maso.Text.Trim() + "', N'" + txt_hoten.Text.Trim() + "'," + txt_hsl.Text.Trim() + ",'" + cbb_phongban.SelectedValue.ToString().Trim() + "',N'" + txt_cccd.Text.Trim() + "', N'" + txt_diachi.Text.Trim() + "', N'" + txt_namsinh.Text.Trim() + "', N'" + txt_chuyenganh.Text.Trim() + "'," + txt_phucap.Text.Trim() + ",N'" + txt_ngayvaolam.Text.Trim() + "','" + cbb_dantoc.SelectedValue.ToString().Trim() + "','" + cbb_tongiao.SelectedValue.ToString().Trim() + "','" + cbb_chucvu.SelectedValue.ToString().Trim() + "', N'" + txt_sdt.Text.Trim() + "')";
            
            tv.CapNhatDL(str);
            HienThiDL();

            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            bt_thoat.Enabled = true;
            bt_xlThem.Enabled = true;
            txt_maso.Text = "";
            txt_hoten.Text = "";
            txt_namsinh.Text = "";
            txt_cccd.Text = "";
            txt_diachi.Text = "";
            txt_chuyenganh.Text = "";
            txt_ngayvaolam.Text = "";
            txt_phucap.Text = "";
            txt_hsl.Text = "";
            txt_luong.Text = "";
            txt_maso.Enabled = false;
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {


        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            bt_huy.Enabled = false;
            bt_luu.Enabled = false;
            bt_thoat.Enabled = true;
            bt_xlThem.Enabled = true;
            txt_maso.Text = "";
            txt_hoten.Text = "";
            txt_namsinh.Text = "";
            txt_cccd.Text = "";
            txt_diachi.Text = "";
            txt_chuyenganh.Text = "";
            txt_ngayvaolam.Text = "";
            txt_hsl.Text = "";
            txt_phucap.Text = "";
            txt_luong.Text = "";
            txt_maso.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {           
            string str = "update TB_NhanVien set Ho_Ten= N'" + txt_hoten.Text.Trim() + "', NamSinh= N'" + txt_namsinh.Text.Trim() + "', CCCD= N'" + txt_cccd.Text.Trim() + "', DiaChi= N'" + txt_diachi.Text.Trim() + "', ChuyenNganh= N'" + txt_chuyenganh.Text.Trim() + "', NgayVaoLam= N'" + txt_ngayvaolam.Text.Trim() + "', HSL= N'" + txt_hsl.Text.Trim() + "', PhuCap= N'" + txt_phucap.Text.Trim() + "', MaPB=N'" + cbb_phongban.SelectedValue.ToString().Trim() + "', MaDT=N'" + cbb_dantoc.SelectedValue.ToString().Trim() + "', MaTG=N'" + cbb_tongiao.SelectedValue.ToString().Trim() + "', MaCV=N'" + cbb_chucvu.SelectedValue.ToString().Trim() + "', SDT=N'" + txt_sdt.Text.Trim() + "' where MSNV= '" + txt_maso.Text.Trim() + "'";
            tv.CapNhatDL(str);
            HienThiDL();
        }
       
        private void dtgv_luoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maso.Text = dtgv_luoi[0, e.RowIndex].Value.ToString();
            txt_hoten.Text = dtgv_luoi[1, e.RowIndex].Value.ToString();
            txt_namsinh.Text = dtgv_luoi[2, e.RowIndex].Value.ToString();
            txt_cccd.Text = dtgv_luoi[3, e.RowIndex].Value.ToString();
            txt_sdt.Text = dtgv_luoi[4, e.RowIndex].Value.ToString();
            txt_diachi.Text = dtgv_luoi[5, e.RowIndex].Value.ToString();
            txt_chuyenganh.Text = dtgv_luoi[6, e.RowIndex].Value.ToString();
            txt_hsl.Text = dtgv_luoi[7, e.RowIndex].Value.ToString();
            txt_phucap.Text = dtgv_luoi[8, e.RowIndex].Value.ToString();

           // cbb_dantoc.SelectedIndex = (int.Parse(dtgv_luoi[9, e.RowIndex].Value.ToString()) - 1);
           // cbb_tongiao.SelectedIndex = (int.Parse(dtgv_luoi[10, e.RowIndex].Value.ToString()) - 1);
            cbb_dantoc.Text = dtgv_luoi[9, e.RowIndex].Value.ToString();
            cbb_tongiao.Text = dtgv_luoi[10, e.RowIndex].Value.ToString();
            cbb_phongban.Text = dtgv_luoi[11, e.RowIndex].Value.ToString();
            cbb_chucvu.Text = dtgv_luoi[12, e.RowIndex].Value.ToString();
           // cbb_chucvu.SelectedIndex = (int.Parse(dtgv_luoi[12, e.RowIndex].Value.ToString()) - 1);
            txt_ngayvaolam.Text = dtgv_luoi[13, e.RowIndex].Value.ToString();         
                                  
            double hsl = double.Parse(txt_hsl.Text);
            double phucap = double.Parse(txt_phucap.Text);
            txt_luong.Text = ((hsl * 1800000-hsl * 1800000/100*10.5) + phucap).ToString();//trừ bảo hiểm 10.5%
            
            bt_sua.Enabled = true;
            bt_xoa.Enabled = true;
            txt_maso.Enabled = false;
        }       
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string str = "delete from TB_NhanVien where MSNV= '" + txt_maso.Text.Trim() + "'";

            tv.CapNhatDL(str);
            HienThiDL();
        }

        private void txt_hsl_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dtgv_luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
