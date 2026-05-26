namespace WinFormsApp3
{
    partial class FrmThemChiDoan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtmachidoan = new TextBox();
            txttenchidoan = new TextBox();
            txtbithu = new TextBox();
            btnthemmoi = new Button();
            btnxoa = new Button();
            btndong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã chi Đoàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 90);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên chi Đoàn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Bí thư";
            // 
            // txtmachidoan
            // 
            txtmachidoan.Location = new Point(172, 27);
            txtmachidoan.Name = "txtmachidoan";
            txtmachidoan.Size = new Size(125, 27);
            txtmachidoan.TabIndex = 3;
            // 
            // txttenchidoan
            // 
            txttenchidoan.Location = new Point(172, 87);
            txttenchidoan.Name = "txttenchidoan";
            txttenchidoan.Size = new Size(209, 27);
            txttenchidoan.TabIndex = 4;
            // 
            // txtbithu
            // 
            txtbithu.Location = new Point(172, 147);
            txtbithu.Name = "txtbithu";
            txtbithu.Size = new Size(209, 27);
            txtbithu.TabIndex = 5;
            // 
            // btnthemmoi
            // 
            btnthemmoi.Location = new Point(37, 208);
            btnthemmoi.Name = "btnthemmoi";
            btnthemmoi.Size = new Size(94, 29);
            btnthemmoi.TabIndex = 6;
            btnthemmoi.Text = "Thêm mới";
            btnthemmoi.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(168, 208);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 7;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btndong
            // 
            btndong.Location = new Point(298, 208);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 8;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            // 
            // FrmThemChiDoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 265);
            Controls.Add(btndong);
            Controls.Add(btnxoa);
            Controls.Add(btnthemmoi);
            Controls.Add(txtbithu);
            Controls.Add(txttenchidoan);
            Controls.Add(txtmachidoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmThemChiDoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Chi Đoàn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtmachidoan;
        private TextBox txttenchidoan;
        private TextBox txtbithu;
        private Button btnthemmoi;
        private Button btnxoa;
        private Button btndong;
    }
}