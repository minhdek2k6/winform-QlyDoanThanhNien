namespace WinFormsApp3
{
    partial class FrmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            panel2 = new Panel();
            pichien = new PictureBox();
            lblmatkhau = new Label();
            pican = new PictureBox();
            lbltendangnhap = new Label();
            txtmatkhau = new TextBox();
            txttendangnhap = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btndangnhap = new Button();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pichien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pican).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pichien);
            panel2.Controls.Add(lblmatkhau);
            panel2.Controls.Add(pican);
            panel2.Controls.Add(lbltendangnhap);
            panel2.Controls.Add(txtmatkhau);
            panel2.Controls.Add(txttendangnhap);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(btndangnhap);
            panel2.Location = new Point(240, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 360);
            panel2.TabIndex = 3;
            // 
            // pichien
            // 
            pichien.BackColor = Color.Transparent;
            pichien.Image = (Image)resources.GetObject("pichien.Image");
            pichien.Location = new Point(486, 177);
            pichien.Name = "pichien";
            pichien.Size = new Size(40, 27);
            pichien.SizeMode = PictureBoxSizeMode.Zoom;
            pichien.TabIndex = 8;
            pichien.TabStop = false;
            pichien.Click += pichien_Click;
            // 
            // lblmatkhau
            // 
            lblmatkhau.AutoSize = true;
            lblmatkhau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblmatkhau.ForeColor = Color.Gray;
            lblmatkhau.Location = new Point(180, 180);
            lblmatkhau.Name = "lblmatkhau";
            lblmatkhau.Size = new Size(70, 20);
            lblmatkhau.TabIndex = 7;
            lblmatkhau.Text = "Mật khẩu";
            lblmatkhau.Click += lblmatkhau_Click;
            // 
            // pican
            // 
            pican.BackColor = Color.Transparent;
            pican.Image = (Image)resources.GetObject("pican.Image");
            pican.Location = new Point(486, 177);
            pican.Name = "pican";
            pican.Size = new Size(40, 27);
            pican.SizeMode = PictureBoxSizeMode.Zoom;
            pican.TabIndex = 9;
            pican.TabStop = false;
            pican.Click += pican_Click;
            // 
            // lbltendangnhap
            // 
            lbltendangnhap.AutoSize = true;
            lbltendangnhap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbltendangnhap.ForeColor = Color.Gray;
            lbltendangnhap.Location = new Point(180, 80);
            lbltendangnhap.Name = "lbltendangnhap";
            lbltendangnhap.Size = new Size(107, 20);
            lbltendangnhap.TabIndex = 6;
            lbltendangnhap.Text = "Tên đăng nhập";
            lbltendangnhap.Click += lbltendangnhap_Click;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(180, 177);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(300, 27);
            txtmatkhau.TabIndex = 5;
            txtmatkhau.UseSystemPasswordChar = true;
            txtmatkhau.TextChanged += txtmatkhau_TextChanged;
            txtmatkhau.Enter += txtmatkhau_Enter;
            txtmatkhau.KeyDown += txtmatkhau_KeyDown;
            txtmatkhau.Leave += txtmatkhau_Leave;
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(180, 77);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(300, 27);
            txttendangnhap.TabIndex = 4;
            txttendangnhap.Enter += txttendangnhap_Enter;
            txttendangnhap.KeyDown += txttendangnhap_KeyDown;
            txttendangnhap.Leave += txttendangnhap_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(60, 160);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(60, 60);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(60, 60);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.DodgerBlue;
            btndangnhap.FlatStyle = FlatStyle.Flat;
            btndangnhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndangnhap.ForeColor = Color.White;
            btndangnhap.Location = new Point(20, 280);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(500, 60);
            btndangnhap.TabIndex = 0;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(180, 263);
            label1.Name = "label1";
            label1.Size = new Size(660, 124);
            label1.TabIndex = 4;
            label1.Text = "CHÀO MỪNG QUAY TRỞ LẠI QUẢN TRỊ VIÊN!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(240, 389);
            label2.Name = "label2";
            label2.Size = new Size(540, 50);
            label2.TabIndex = 5;
            label2.Text = "Vui lòng đăng nhập!";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDangNhap";
            Text = "Phần mềm quản lý Đoàn thanh niên trường Đại học Thái Bình";
            WindowState = FormWindowState.Maximized;
            Load += FrmDangNhap_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pichien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pican).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pichien;
        private Label lblmatkhau;
        private PictureBox pican;
        private Label lbltendangnhap;
        private TextBox txtmatkhau;
        private TextBox txttendangnhap;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btndangnhap;
        private Label label1;
        private Label label2;
    }
}
