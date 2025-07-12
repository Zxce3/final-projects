namespace Zakatin
{
    partial class ZakatForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZakatForm));
            button7 = new Button();
            button6 = new Button();
            ZakatGv = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog2 = new PrintPreviewDialog();
            button4 = new Button();
            button1 = new Button();
            ZnameTb = new TextBox();
            ZuangTb = new TextBox();
            ZberasTb = new TextBox();
            ZtotalTb = new TextBox();
            button3 = new Button();
            ZtanggalTb = new TextBox();
            ZjenisTb = new TextBox();
            button2 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)ZakatGv).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(173, 426);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(50, 30);
            button7.TabIndex = 19;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(173, 464);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(50, 34);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ZakatGv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            ZakatGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ZakatGv.BackgroundColor = Color.White;
            ZakatGv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ZakatGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ZakatGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ZakatGv.DefaultCellStyle = dataGridViewCellStyle3;
            ZakatGv.Dock = DockStyle.Right;
            ZakatGv.EditMode = DataGridViewEditMode.EditOnKeystroke;
            ZakatGv.GridColor = Color.LightGray;
            ZakatGv.Location = new Point(429, 0);
            ZakatGv.Margin = new Padding(3, 4, 3, 4);
            ZakatGv.Name = "ZakatGv";
            ZakatGv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ZakatGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ZakatGv.RowHeadersWidth = 51;
            ZakatGv.ShowCellErrors = false;
            ZakatGv.Size = new Size(571, 600);
            ZakatGv.TabIndex = 3;
            ZakatGv.CellContentClick += ZakatGv_CellContentClick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument2
            // 
            printDocument2.PrintPage += printDocument2_PrintPage;
            // 
            // printPreviewDialog2
            // 
            printPreviewDialog2.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog2.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog2.ClientSize = new Size(400, 300);
            printPreviewDialog2.Enabled = true;
            printPreviewDialog2.Icon = (Icon)resources.GetObject("printPreviewDialog2.Icon");
            printPreviewDialog2.Name = "printPreviewDialog2";
            printPreviewDialog2.Visible = false;
            printPreviewDialog2.Load += printPreviewDialog2_Load;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(106, 516);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(178, 30);
            button4.TabIndex = 10;
            button4.Text = "Kembali";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(106, 426);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(49, 30);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // ZnameTb
            // 
            ZnameTb.BackColor = Color.White;
            ZnameTb.BorderStyle = BorderStyle.None;
            ZnameTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZnameTb.ForeColor = Color.Black;
            ZnameTb.Location = new Point(67, 88);
            ZnameTb.Margin = new Padding(3, 4, 3, 4);
            ZnameTb.Name = "ZnameTb";
            ZnameTb.Size = new Size(250, 23);
            ZnameTb.TabIndex = 1;
            ZnameTb.TextChanged += textBox1_TextChanged;
            // 
            // ZuangTb
            // 
            ZuangTb.BackColor = Color.White;
            ZuangTb.BorderStyle = BorderStyle.None;
            ZuangTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZuangTb.ForeColor = Color.Black;
            ZuangTb.Location = new Point(67, 265);
            ZuangTb.Margin = new Padding(3, 4, 3, 4);
            ZuangTb.Name = "ZuangTb";
            ZuangTb.Size = new Size(250, 23);
            ZuangTb.TabIndex = 5;
            ZuangTb.TextChanged += textBox5_TextChanged;
            // 
            // ZberasTb
            // 
            ZberasTb.BackColor = Color.White;
            ZberasTb.BorderStyle = BorderStyle.None;
            ZberasTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZberasTb.ForeColor = Color.Black;
            ZberasTb.Location = new Point(67, 322);
            ZberasTb.Margin = new Padding(3, 4, 3, 4);
            ZberasTb.Name = "ZberasTb";
            ZberasTb.Size = new Size(250, 23);
            ZberasTb.TabIndex = 4;
            // 
            // ZtotalTb
            // 
            ZtotalTb.BackColor = Color.White;
            ZtotalTb.BorderStyle = BorderStyle.None;
            ZtotalTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZtotalTb.ForeColor = Color.Black;
            ZtotalTb.Location = new Point(67, 378);
            ZtotalTb.Margin = new Padding(3, 4, 3, 4);
            ZtotalTb.Name = "ZtotalTb";
            ZtotalTb.Size = new Size(250, 23);
            ZtotalTb.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(234, 464);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(50, 34);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ZtanggalTb
            // 
            ZtanggalTb.BackColor = Color.White;
            ZtanggalTb.BorderStyle = BorderStyle.None;
            ZtanggalTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZtanggalTb.ForeColor = Color.Black;
            ZtanggalTb.Location = new Point(67, 146);
            ZtanggalTb.Margin = new Padding(3, 4, 3, 4);
            ZtanggalTb.Name = "ZtanggalTb";
            ZtanggalTb.Size = new Size(250, 23);
            ZtanggalTb.TabIndex = 2;
            // 
            // ZjenisTb
            // 
            ZjenisTb.BackColor = Color.White;
            ZjenisTb.BorderStyle = BorderStyle.None;
            ZjenisTb.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ZjenisTb.ForeColor = Color.Black;
            ZjenisTb.Location = new Point(67, 205);
            ZjenisTb.Margin = new Padding(3, 4, 3, 4);
            ZjenisTb.Name = "ZjenisTb";
            ZjenisTb.Size = new Size(250, 23);
            ZjenisTb.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(234, 426);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(50, 30);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(106, 464);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(49, 34);
            button5.TabIndex = 18;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // ZakatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1000, 600);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(ZjenisTb);
            Controls.Add(button7);
            Controls.Add(ZtanggalTb);
            Controls.Add(button6);
            Controls.Add(ZakatGv);
            Controls.Add(ZtotalTb);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(ZberasTb);
            Controls.Add(ZnameTb);
            Controls.Add(ZuangTb);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ZakatForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += ZakatForm_Load;
            ((System.ComponentModel.ISupportInitialize)ZakatGv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView ZakatGv;
        private Button button6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button7;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private PrintPreviewDialog printPreviewDialog2;
        private Button button4;
        private Button button1;
        private TextBox ZnameTb;
        private TextBox ZuangTb;
        private TextBox ZberasTb;
        private TextBox ZtotalTb;
        private Button button3;
        private TextBox ZtanggalTb;
        private TextBox ZjenisTb;
        private Button button2;
        private Button button5;
    }
}