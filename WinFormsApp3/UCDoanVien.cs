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
        bool daLoadXong = false;
        string connStr = @"Server=localhost;
                           Database=QuanLyDoanVien;
                           Trusted_Connection=True;
                           TrustServerCertificate=True";
        public UCDoanVien()
        {
            InitializeComponent();

            LoadDoanVien();
            LoadLocChiDoan();

            daLoadXong = true;
        }
        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            FrmThemDoanVien frm = new FrmThemDoanVien();
            frm.Show();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvdoanvien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đoàn viên cần sửa!");
                return;
            }
            FrmThemDoanVien frm = new FrmThemDoanVien();
            frm.Text = "Sửa Đoàn viên";
            frm.btnthemmoi.Text = "Sửa";
            frm.btnxoa.Visible = false;
            frm.txtmasv.Text = dgvdoanvien.CurrentRow.Cells["MaSinhVien"].Value.ToString();
            frm.txthoten.Text = dgvdoanvien.CurrentRow.Cells["HoTen"].Value.ToString();
            frm.dtpngaysinh.Value =
                Convert.ToDateTime(dgvdoanvien.CurrentRow.Cells["NgaySinh"].Value);
            string maChiDoan =
                dgvdoanvien.CurrentRow.Cells["MaChiDoan"].Value.ToString();
            frm.cbochidoan.SelectedValue = maChiDoan;
            frm.txtsdt.Text =
                dgvdoanvien.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            frm.txtemail.Text =
                dgvdoanvien.CurrentRow.Cells["Email"].Value.ToString();
            frm.txtdiachi.Text =
                dgvdoanvien.CurrentRow.Cells["DiaChi"].Value.ToString();
            frm.cbochucvu.Text =
                dgvdoanvien.CurrentRow.Cells["ChucVu"].Value.ToString();
            string gioiTinh =
                dgvdoanvien.CurrentRow.Cells["GioiTinh"].Value.ToString();

            if (gioiTinh == "Nam")
            {
                frm.rdnam.Checked = true;
            }
            else
            {
                frm.rdnu.Checked = true;
            }
            frm.txtmasv.Enabled = false;

            frm.ShowDialog();
            LoadDoanVien();
        }
        private void LoadDoanVien()
        {
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
        private void LoadLocChiDoan()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT DISTINCT MaChiDoan FROM DoanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboloc.DataSource = dt;
                cboloc.DisplayMember = "MaChiDoan";
                cboloc.ValueMember = "MaChiDoan";
                cboloc.SelectedIndex = -1;
            }
        }

        private void cboloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!daLoadXong)
                return;
            LocDuLieu();
            if (cboloc.SelectedValue == null)
                return;
            string maChiDoan = cboloc.SelectedValue.ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM DoanVien WHERE MaChiDoan = @MaChiDoan";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaChiDoan", maChiDoan);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdoanvien.DataSource = dt;
            }
        }
        private void LocDuLieu()
        {
            string tuKhoa = txttimkiem.Text.Trim();
            string maChiDoan = "";
            if (cboloc.SelectedValue != null)
                maChiDoan = cboloc.SelectedValue.ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"
                 SELECT * FROM DoanVien
                 WHERE 
                 (@MaChiDoan = '' OR MaChiDoan = @MaChiDoan)
                 AND
                 (
                 MaSinhVien LIKE @TuKhoa
                 OR HoTen LIKE @TuKhoa
                 OR GioiTinh LIKE @TuKhoa
                 OR SoDienThoai LIKE @TuKhoa
                 OR DiaChi LIKE @TuKhoa
                 OR ChucVu LIKE @TuKhoa
                 )";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaChiDoan", maChiDoan);
                cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdoanvien.DataSource = dt;
            }
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (!daLoadXong)
                return;
            LocDuLieu();
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            cboloc.SelectedIndex = -1;
            LoadDoanVien();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvdoanvien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đoàn viên cần xóa!");
                return;
            }
            string maSinhVien =
                dgvdoanvien.CurrentRow.Cells["MaSinhVien"].Value.ToString();
            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa đoàn viên này?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                return;
            string connStr = @"Server=localhost;
                       Database=QuanLyDoanVien;
                       Trusted_Connection=True;
                       TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql1 = @"DELETE FROM ThamGiaHoatDong
                    WHERE MaSinhVien = @MaSinhVien";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                cmd1.ExecuteNonQuery();
                string sql2 = @"DELETE FROM KhenThuongKyLuat
                    WHERE MaSinhVien = @MaSinhVien";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                cmd2.ExecuteNonQuery();
                string sql3 = @"DELETE FROM DoanVien
                    WHERE MaSinhVien = @MaSinhVien";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd3.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                cmd3.ExecuteNonQuery();
            }
            MessageBox.Show("Xóa đoàn viên thành công!");
            LoadDoanVien();
        }
    }
}