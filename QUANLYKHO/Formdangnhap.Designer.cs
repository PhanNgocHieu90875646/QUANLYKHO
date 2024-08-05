namespace QUANLYKHO
{
    partial class Formdangnhap
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
            login = new Button();
            MK = new TextBox();
            tk = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // login
            // 
            login.Anchor = AnchorStyles.None;
            login.BackColor = Color.Green;
            login.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = Color.White;
            login.Location = new Point(315, 330);
            login.Name = "login";
            login.Size = new Size(136, 43);
            login.TabIndex = 0;
            login.Text = "Đăng Nhập";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click_1;
            // 
            // MK
            // 
            MK.Anchor = AnchorStyles.None;
            MK.Location = new Point(277, 277);
            MK.Name = "MK";
            MK.PasswordChar = '*';
            MK.Size = new Size(274, 27);
            MK.TabIndex = 8;
            // 
            // tk
            // 
            tk.Anchor = AnchorStyles.None;
            tk.BackColor = SystemColors.Window;
            tk.Location = new Point(277, 218);
            tk.Name = "tk";
            tk.Size = new Size(274, 27);
            tk.TabIndex = 7;
            tk.TextChanged += tk_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dangnhap;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(765, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.nguoidung;
            pictureBox2.Location = new Point(230, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.KHOA;
            pictureBox3.Location = new Point(230, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Formdangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(763, 409);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(MK);
            Controls.Add(tk);
            Controls.Add(login);
            Name = "Formdangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PHẦN MỀM QUẢN LÝ KHO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private TextBox MK;
        private TextBox tk;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}