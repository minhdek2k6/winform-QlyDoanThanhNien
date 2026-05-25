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
    public partial class UCDoanVien : UserControl
    {

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            FrmThemDoanVien frm = new FrmThemDoanVien();
            frm.Show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            FrmThemDoanVien frm = new FrmThemDoanVien();
            frm.Show();

        }
        private void LoadDoanVien()
        {
            string connStr = @"Server=localhost;
                       Database=QuanLyDoanVien;
                       Trusted_Connection=True;
                       TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM DoanVien";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvdoanvien.DataSource = dt;
                dgvdoanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        public UCDoanVien()
        {
            InitializeComponent();
            LoadDoanVien();
        }
    }
}
