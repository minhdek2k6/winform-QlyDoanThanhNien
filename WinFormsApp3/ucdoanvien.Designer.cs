namespace WinFormsApp3
{
    partial class UCDoanVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cboloc = new ComboBox();
            btnlammoi = new Button();
            btntimkiem = new Button();
            txttimkiem = new TextBox();
            panel2 = new Panel();
            btnxoa = new Button();
            btnsua = new Button();
            btnthemmoi = new Button();
            panel3 = new Panel();
            dgvdoanvien = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdoanvien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cboloc);
            panel1.Controls.Add(btnlammoi);
            panel1.Controls.Add(btntimkiem);
            panel1.Controls.Add(txttimkiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1542, 85);
            panel1.TabIndex = 0;
            // 
            // cboloc
            // 
            cboloc.FormattingEnabled = true;
            cboloc.Location = new Point(50, 29);
            cboloc.Name = "cboloc";
            cboloc.Size = new Size(230, 28);
            cboloc.TabIndex = 3;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(1415, 30);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(94, 29);
            btnlammoi.TabIndex = 2;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(781, 28);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 1;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(322, 30);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(426, 27);
            txttimkiem.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnxoa);
            panel2.Controls.Add(btnsua);
            panel2.Controls.Add(btnthemmoi);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1373, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 676);
            panel2.TabIndex = 1;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(43, 158);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 2;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(43, 95);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 1;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthemmoi
            // 
            btnthemmoi.Location = new Point(43, 33);
            btnthemmoi.Name = "btnthemmoi";
            btnthemmoi.Size = new Size(94, 29);
            btnthemmoi.TabIndex = 0;
            btnthemmoi.Text = "Thêm mới";
            btnthemmoi.UseVisualStyleBackColor = true;
            btnthemmoi.Click += btnthemmoi_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvdoanvien);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(1373, 676);
            panel3.TabIndex = 2;
            // 
            // dgvdoanvien
            // 
            dgvdoanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdoanvien.Dock = DockStyle.Fill;
            dgvdoanvien.Location = new Point(0, 0);
            dgvdoanvien.Name = "dgvdoanvien";
            dgvdoanvien.RowHeadersWidth = 51;
            dgvdoanvien.Size = new Size(1373, 676);
            dgvdoanvien.TabIndex = 0;
            // 
            // UCDoanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCDoanVien";
            Size = new Size(1542, 761);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdoanvien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnlammoi;
        private Button btntimkiem;
        private TextBox txttimkiem;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvdoanvien;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthemmoi;
        private ComboBox cboloc;
    }
}
