namespace QUANLYKHO
{
    partial class Formdonvido
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textmadvd = new TextBox();
            label2 = new Label();
            texttendvd = new TextBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(773, 175);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 40);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 3;
            label1.Text = "Mã đơn vị do :";
            label1.Click += label1_Click;
            // 
            // textmadvd
            // 
            textmadvd.Anchor = AnchorStyles.Top;
            textmadvd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textmadvd.Location = new Point(187, 40);
            textmadvd.Name = "textmadvd";
            textmadvd.Size = new Size(470, 24);
            textmadvd.TabIndex = 4;
            textmadvd.TextChanged += textmadvd_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 85);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 5;
            label2.Text = "Tên đơn vị đo :";
            // 
            // texttendvd
            // 
            texttendvd.Anchor = AnchorStyles.Top;
            texttendvd.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            texttendvd.Location = new Point(187, 82);
            texttendvd.Name = "texttendvd";
            texttendvd.Size = new Size(470, 24);
            texttendvd.TabIndex = 6;
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Top;
            btn_them.BackColor = Color.Green;
            btn_them.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_them.ForeColor = Color.White;
            btn_them.Location = new Point(62, 26);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(119, 44);
            btn_them.TabIndex = 7;
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
            btn_sua.Location = new Point(217, 26);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(119, 44);
            btn_sua.TabIndex = 8;
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
            btn_xoa.Location = new Point(369, 26);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(119, 44);
            btn_xoa.TabIndex = 9;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(texttendvd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textmadvd);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(111, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 138);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đơn vị đo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_xoa);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Location = new Point(209, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 82);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // Formdonvido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(944, 541);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Formdonvido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formdvd";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textmadvd;
        private Label label2;
        private TextBox texttendvd;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}