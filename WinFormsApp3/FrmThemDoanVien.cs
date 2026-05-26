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
            string gioiTinh = rdnam.Checked ? "Nam" : "Nữ";
            string connStr = @"Server=localhost;
                       Database=QuanLyDoanVien;
                       Trusted_Connection=True;
                       TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                if (btnthemmoi.Text == "Sửa")
                {
                    string sql = @"UPDATE DoanVien
                           SET HoTen = @HoTen,
                               NgaySinh = @NgaySinh,
                               GioiTinh = @GioiTinh,
                               MaChiDoan = @MaChiDoan,
                               ChucVu = @ChucVu,
                               SoDienThoai = @SoDienThoai,
                               Email = @Email,
                               DiaChi = @DiaChi
                           WHERE MaSinhVien = @MaSinhVien";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaSinhVien", txtmasv.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txthoten.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpngaysinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@MaChiDoan", cbochidoan.SelectedValue);
                    cmd.Parameters.AddWithValue("@ChucVu", cbochucvu.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa đoàn viên thành công!");
                    this.Close();
                }
                else
                {
                    string sql = @"INSERT INTO DoanVien
                           VALUES(@MaDoanVien,
                                  @HoTen,
                                  @NgaySinh,
                                  @GioiTinh,
                                  @MaChiDoan,
                                  @ChucVu,
                                  @SoDienThoai,
                                  @Email,
                                  @DiaChi)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaSinhVien", txtmasv.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txthoten.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpngaysinh.Value);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@MaChiDoan", cbochidoan.SelectedValue);
                    cmd.Parameters.AddWithValue("@ChucVu", cbochucvu.Text);
                    cmd.Parameters.AddWithValue("@SoDienThoai", txtsdt.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm đoàn viên thành công!");
                    this.Close();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtmasv.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            txthoten.Clear();
            txtemail.Clear();
            rdnam.Checked = false;
            rdnu.Checked = false;
            cbochidoan.SelectedIndex = -1;
            cbochucvu.SelectedIndex = -1;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
