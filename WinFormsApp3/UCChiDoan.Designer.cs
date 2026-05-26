namespace WinFormsApp3
{
    partial class UCChiDoan
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
            dgvchidoan = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvchidoan).BeginInit();
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
            panel1.TabIndex = 1;
            // 
            // cboloc
            // 
            cboloc.FormattingEnabled = true;
            cboloc.Location = new Point(55, 31);
            cboloc.Name = "cboloc";
            cboloc.Size = new Size(99, 28);
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
            btntimkiem.Location = new Point(688, 28);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 1;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(209, 28);
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
            panel2.TabIndex = 2;
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
            // dgvchidoan
            // 
            dgvchidoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvchidoan.Dock = DockStyle.Fill;
            dgvchidoan.Location = new Point(0, 85);
            dgvchidoan.Name = "dgvchidoan";
            dgvchidoan.RowHeadersWidth = 51;
            dgvchidoan.Size = new Size(1373, 676);
            dgvchidoan.TabIndex = 3;
            // 
            // UCChiDoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvchidoan);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCChiDoan";
            Size = new Size(1542, 761);
            Load += UCChiDoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvchidoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboloc;
        private Button btnlammoi;
        private Button btntimkiem;
        private TextBox txttimkiem;
        private Panel panel2;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthemmoi;
        private DataGridView dgvchidoan;
    }
}
