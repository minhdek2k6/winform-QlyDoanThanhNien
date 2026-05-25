using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class FrmTrangChu : Form
    {
        public FrmTrangChu()
        {
            InitializeComponent();
        }
        private void FrmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            panelquanly.Visible = !panelquanly.Visible;
        }

        private void btnhoatdong_Click(object sender, EventArgs e)
        {
            panelhoatdong.Visible = !panelhoatdong.Visible;
        }

        private void btnkhenthuongkyluat_Click(object sender, EventArgs e)
        {
            panelkhenthuongkyluat.Visible = !panelkhenthuongkyluat.Visible;
        }

        private void btnthongkebaocao_Click(object sender, EventArgs e)
        {
            panelthongkebaocao.Visible = !panelthongkebaocao.Visible;
        }

        private void btnthemdoanvien_Click(object sender, EventArgs e)
        {
            FrmThemDoanVien frm = new FrmThemDoanVien();
            frm.Show();
        }
        private UCDoanVien ucDoanVien;
        private void btndoanvien_Click(object sender, EventArgs e)
        {
            panelmain.Controls.Clear();

            if (ucDoanVien == null)
            {
                ucDoanVien = new UCDoanVien();
                ucDoanVien.Dock = DockStyle.Fill;
            }

            panelmain.Controls.Add(ucDoanVien);
        }
    }
}
