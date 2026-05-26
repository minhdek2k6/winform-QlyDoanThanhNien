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
    public partial class UCChiDoan : UserControl
    {
        string connStr = @"Server=localhost;
                           Database=QuanLyDoanVien;
                           Trusted_Connection=True;
                           TrustServerCertificate=True";

        public UCChiDoan()
        {
            InitializeComponent();
        }

        void LoadChiDoan()
        {
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM ChiDoan";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvchidoan.DataSource = dt;
                dgvchidoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvchidoan.AllowUserToAddRows = false;
                dgvchidoan.ReadOnly = true;
                dgvchidoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void UCChiDoan_Load(object sender, EventArgs e)
        {
            LoadChiDoan();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            FrmThemChiDoan frm = new FrmThemChiDoan();
            frm.Show();
        }
    }
}
