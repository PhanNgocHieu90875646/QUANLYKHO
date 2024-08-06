namespace QUANLYKHO
{
    partial class Formnhaphang
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textmnh = new TextBox();
            textmvt = new TextBox();
            textncc = new TextBox();
            textsoluong = new TextBox();
            texttien = new TextBox();
            dateTimenh = new DateTimePicker();
            dataGridViewnk = new DataGridView();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_clearnk = new Button();
            IN = new Button();
            saveFileDialog1 = new SaveFileDialog();
            texttenvr = new TextBox();
            label7 = new Label();
            tb_manv = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewnk).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(122, 45);
            label1.Name = "label1";
            label1.Size = new Size(118, 18);
            label1.TabIndex = 0;
            label1.Text = "Mã nhập hàng:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(122, 94);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 1;
            label2.Text = "Mã vật tư :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(122, 201);
            label3.Name = "label3";
            label3.Size = new Size(146, 18);
            label3.TabIndex = 2;
            label3.Text = "Mã nhà cung cấp :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(122, 253);
            label4.Name = "label4";
            label4.Size = new Size(85, 18);
            label4.TabIndex = 3;
            label4.Text = "Số lượng :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(122, 303);
            label5.Name = "label5";
            label5.Size = new Size(96, 18);
            label5.TabIndex = 4;
            label5.Text = "Thành tiền :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(126, 397);
            label6.Name = "label6";
            label6.Size = new Size(138, 18);
            label6.TabIndex = 5;
            label6.Text = "Ngày nhập hàng :";
            label6.Click += label6_Click;
            // 
            // textmnh
            // 
            textmnh.Anchor = AnchorStyles.Top;
            textmnh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textmnh.Location = new Point(270, 42);
            textmnh.Name = "textmnh";
            textmnh.Size = new Size(338, 24);
            textmnh.TabIndex = 6;
            textmnh.TextChanged += textmnh_TextChanged;
            // 
            // textmvt
            // 
            textmvt.Anchor = AnchorStyles.Top;
            textmvt.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textmvt.Location = new Point(270, 91);
            textmvt.Name = "textmvt";
            textmvt.Size = new Size(338, 24);
            textmvt.TabIndex = 7;
            textmvt.TextChanged += textmvt_TextChanged;
            // 
            // textncc
            // 
            textncc.Anchor = AnchorStyles.Top;
            textncc.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textncc.Location = new Point(270, 198);
            textncc.Name = "textncc";
            textncc.Size = new Size(338, 24);
            textncc.TabIndex = 8;
            textncc.TextChanged += textncc_TextChanged;
            // 
            // textsoluong
            // 
            textsoluong.Anchor = AnchorStyles.Top;
            textsoluong.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textsoluong.Location = new Point(270, 250);
            textsoluong.Name = "textsoluong";
            textsoluong.Size = new Size(338, 24);
            textsoluong.TabIndex = 9;
            textsoluong.TextChanged += textsoluong_TextChanged;
            // 
            // texttien
            // 
            texttien.Anchor = AnchorStyles.Top;
            texttien.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            texttien.Location = new Point(270, 297);
            texttien.Name = "texttien";
            texttien.Size = new Size(338, 24);
            texttien.TabIndex = 10;
            texttien.TextChanged += texttien_TextChanged;
            // 
            // dateTimenh
            // 
            dateTimenh.Anchor = AnchorStyles.Top;
            dateTimenh.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimenh.Location = new Point(270, 392);
            dateTimenh.Name = "dateTimenh";
            dateTimenh.Size = new Size(338, 24);
            dateTimenh.TabIndex = 11;
            dateTimenh.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridViewnk
            // 
            dataGridViewnk.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewnk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewnk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewnk.Location = new Point(82, 451);
            dataGridViewnk.Name = "dataGridViewnk";
            dataGridViewnk.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewnk.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewnk.RowTemplate.Height = 29;
            dataGridViewnk.Size = new Size(898, 219);
            dataGridViewnk.TabIndex = 12;
            dataGridViewnk.CellClick += dataGridViewnk_CellClick;
            dataGridViewnk.CellContentClick += dataGridViewnk_CellContentClick;
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Top;
            btn_them.BackColor = Color.Green;
            btn_them.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_them.ForeColor = Color.White;
            btn_them.Location = new Point(758, 57);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(109, 43);
            btn_them.TabIndex = 13;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Anchor = AnchorStyles.Top;
            btn_sua.BackColor = Color.Green;
            btn_sua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.White;
            btn_sua.Location = new Point(758, 117);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(109, 41);
            btn_sua.TabIndex = 14;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Anchor = AnchorStyles.Top;
            btn_xoa.BackColor = Color.LightCoral;
            btn_xoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_xoa.ForeColor = Color.White;
            btn_xoa.Location = new Point(758, 177);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(109, 39);
            btn_xoa.TabIndex = 15;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_clearnk
            // 
            btn_clearnk.Anchor = AnchorStyles.Top;
            btn_clearnk.BackColor = Color.Green;
            btn_clearnk.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clearnk.ForeColor = Color.White;
            btn_clearnk.Location = new Point(758, 233);
            btn_clearnk.Name = "btn_clearnk";
            btn_clearnk.Size = new Size(109, 41);
            btn_clearnk.TabIndex = 16;
            btn_clearnk.Text = "Clear";
            btn_clearnk.UseVisualStyleBackColor = false;
            btn_clearnk.Click += btn_clearnk_Click;
            // 
            // IN
            // 
            IN.Anchor = AnchorStyles.Top;
            IN.BackColor = Color.Green;
            IN.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IN.ForeColor = Color.White;
            IN.Location = new Point(758, 340);
            IN.Name = "IN";
            IN.Size = new Size(109, 37);
            IN.TabIndex = 17;
            IN.Text = "IN";
            IN.UseVisualStyleBackColor = false;
            IN.Click += IN_Click;
            // 
            // texttenvr
            // 
            texttenvr.Anchor = AnchorStyles.Top;
            texttenvr.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            texttenvr.Location = new Point(270, 145);
            texttenvr.Name = "texttenvr";
            texttenvr.Size = new Size(338, 24);
            texttenvr.TabIndex = 19;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(122, 151);
            label7.Name = "label7";
            label7.Size = new Size(61, 18);
            label7.TabIndex = 18;
            label7.Text = "TenVT:";
            // 
            // tb_manv
            // 
            tb_manv.Anchor = AnchorStyles.Top;
            tb_manv.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tb_manv.Location = new Point(270, 346);
            tb_manv.Name = "tb_manv";
            tb_manv.Size = new Size(338, 24);
            tb_manv.TabIndex = 21;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(126, 352);
            label8.Name = "label8";
            label8.Size = new Size(54, 18);
            label8.TabIndex = 20;
            label8.Text = "MANV";
            // 
            // Formnhaphang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1086, 715);
            Controls.Add(tb_manv);
            Controls.Add(label8);
            Controls.Add(texttenvr);
            Controls.Add(label7);
            Controls.Add(IN);
            Controls.Add(btn_clearnk);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(dataGridViewnk);
            Controls.Add(dateTimenh);
            Controls.Add(texttien);
            Controls.Add(textsoluong);
            Controls.Add(textncc);
            Controls.Add(textmvt);
            Controls.Add(textmnh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formnhaphang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formnk";
            Load += Formnhaphang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewnk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridViewnk;
        private TextBox textmnh;
        private TextBox textmvt;
        private TextBox textncc;
        private TextBox textsoluong;
        private TextBox texttien;
        private DateTimePicker dateTimenh;
        private Button btn_them;
        private Button btn_sua;
        private Button button3;
        private Button btn_clearnk;
        private Button button4;
        private Button btn_xoa;
        private Button IN;
        private SaveFileDialog saveFileDialog1;
        private TextBox texttenvr;
        private Label label7;
        private TextBox tb_manv;
        private Label label8;
    }
}