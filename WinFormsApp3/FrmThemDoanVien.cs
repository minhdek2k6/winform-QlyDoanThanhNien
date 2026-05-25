using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace WinFormsApp3
{
    public partial class FrmThemDoanVien : Form
    {
        public FrmThemDoanVien()
        {
            InitializeComponent();
        }
        void LoadChiDoan()
        {
            string connStr = @"Server=localhost;
                       Database=QuanLyDoanVien;
                       Trusted_Connection=True;
                       Encrypt=False;
                       TrustServerCertificate=True;";

            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "SELECT MaChiDoan, TenChiDoan FROM ChiDoan";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                cbochidoan.DataSource = dt;

                cbochidoan.DisplayMember = "TenChiDoan";

                cbochidoan.ValueMember = "MaChiDoan";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void FrmThemDoanVien_Load(object sender, EventArgs e)
        {
            LoadChiDoan();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtsdt.Text, out _))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng!","Thông báo",MessageBoxButtons.OK);
                txtsdt.Focus();
                return;
            }
            string gioitinh = "";

            if (rdnam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rdnu.Checked)
            {
                gioitinh = "Nữ";
            }

            string connStr = @"Server=localhost;
                       Database=QuanLyDoanVien;
                       Trusted_Connection=True;
                       Encrypt=False;
                       TrustServerCertificate=True;";

            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO DoanVien
                       (MaSinhVien, HoTen, NgaySinh, GioiTinh,
                        DiaChi, SoDienThoai, MaChiDoan, Email, NgayVaoDoan, ChucVu)

                       VALUES
                       (@MaSinhVien, @HoTen, @NgaySinh, @GioiTinh,
                        @DiaChi, @SoDienThoai, @MaChiDoan, @Email, @NgayVaoDoan, @ChucVu)";


                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaSinhVien", txtmasv.Text);
                cmd.Parameters.AddWithValue("@HoTen", txthoten.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpngaysinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtsdt.Text);
                cmd.Parameters.AddWithValue("@NgayVaoDoan", dtpngayvaodoan.Value);
                cmd.Parameters.AddWithValue("@MaChiDoan",
                            cbochidoan.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ChucVu", cbochucvu.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm đoàn viên thành công!","Thông báo",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
