using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace WinFormsApp3
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtmatkhau.UseSystemPasswordChar = true;

            pican.Visible = false;
            pichien.Visible = false;

            lbltendangnhap.Parent = txttendangnhap;
            lbltendangnhap.BackColor = Color.Transparent;
            lbltendangnhap.Location = new Point(5, 2);

            lblmatkhau.Parent = txtmatkhau;
            lblmatkhau.BackColor = Color.Transparent;
            lblmatkhau.Location = new Point(5, 2);
        }

        private void txttendangnhap_Enter(object sender, EventArgs e)
        {
            lbltendangnhap.Visible = false;
        }

        private void txtmatkhau_Enter(object sender, EventArgs e)
        {
            lblmatkhau.Visible = false;
        }

        private void txttendangnhap_Leave(object sender, EventArgs e)
        {
            if (txttendangnhap.Text == "")
            {
                lbltendangnhap.Visible = true;
            }
        }

        private void txtmatkhau_Leave(object sender, EventArgs e)
        {
            if (txtmatkhau.Text == "")
            {
                lblmatkhau.Visible = true;
            }
        }

        private void lbltendangnhap_Click(object sender, EventArgs e)
        {
            txttendangnhap.Focus();
        }

        private void lblmatkhau_Click(object sender, EventArgs e)
        {
            txtmatkhau.Focus();
        }

        private void pican_Click(object sender, EventArgs e)
        {
            txtmatkhau.UseSystemPasswordChar = false;

            pican.Visible = false;
            pichien.Visible = true;
        }

        private void pichien_Click(object sender, EventArgs e)
        {
            txtmatkhau.UseSystemPasswordChar = true;

            pichien.Visible = false;
            pican.Visible = true;
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            if (txtmatkhau.UseSystemPasswordChar)
            {
                pican.Visible = true;
                pichien.Visible = false;
            }
            else
            {
                pican.Visible = false;
                pichien.Visible = true;
            }
        }
        private void txtmatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndangnhap.PerformClick();
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=localhost;
                       Initial Catalog=QuanLyDoanVien;
                       Integrated Security=True;
                       TrustServerCertificate=True;";
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM TaiKhoan " +
                             "WHERE TenDangNhap = @tk AND MatKhau = @mk";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tk", txttendangnhap.Text);
                cmd.Parameters.AddWithValue("@mk", txtmatkhau.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");

                    FrmTrangChu frm = new FrmTrangChu();
                    frm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
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
