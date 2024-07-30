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
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Anchor = AnchorStyles.None;
            login.BackColor = Color.Green;
            login.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = Color.White;
            login.Location = new Point(181, 220);
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
            MK.Location = new Point(137, 157);
            MK.Name = "MK";
            MK.PasswordChar = '*';
            MK.Size = new Size(274, 27);
            MK.TabIndex = 8;
            // 
            // tk
            // 
            tk.Anchor = AnchorStyles.None;
            tk.BackColor = SystemColors.Window;
            tk.Location = new Point(137, 72);
            tk.Name = "tk";
            tk.Size = new Size(274, 27);
            tk.TabIndex = 7;
            tk.TextChanged += tk_TextChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 160);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 75);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 5;
            label1.Text = "Tài khoản:";
            // 
            // Formdangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(482, 301);
            Controls.Add(MK);
            Controls.Add(tk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(login);
            Name = "Formdangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PHẦN MỀM QUẢN LÝ KHO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private TextBox MK;
        private TextBox tk;
        private Label label2;
        private Label label1;
    }
}