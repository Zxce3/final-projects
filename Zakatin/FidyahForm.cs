using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Zakatin
{
    public partial class FidyahForm : Form
    {
        int rowIndex = 0; // ✅ Tambahkan baris ini
        string selectedName = ""; // ✅ Menyimpan nama Muzakki yang dipilih

        public FidyahForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Downloads\Zakatin\Zakatindb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                con.Open();
                string myquery = "select * from FidyahTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                FidyahGv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch { }
            {
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into FidyahTbl values('" + FnameTb.Text + "','" + FtanggalTb.Text + "','" + FberasTb.Text + "','" + FuangTb.Text + "','" + FtotalTb.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Telah Disimpan");
                con.Close();
                populate();
            }
            catch { }
            {

            }
        }

        private void FidyahForm_Load(object sender, EventArgs e)
        {
            populate();
            FidyahGv.DefaultCellStyle.Font = new Font("Segoe UI", 10); // untuk isi sel
            FidyahGv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold); // untuk header kolom
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FnameTb.Text == "")
            {
                MessageBox.Show("Masukan Nama Pembayar");
            }
            else
            {
                con.Open();
                string myquery = "delete from FidyahTbl where [Nama Pembayar]='" + FnameTb.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Telah Dihapus");
                con.Close();
                populate();
            }
        }

        private void FidyahGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.FidyahGv.Rows[e.RowIndex];
                FnameTb.Text = row.Cells[0].Value.ToString();
                FtanggalTb.Text = row.Cells[1].Value.ToString();
                FberasTb.Text = row.Cells[2].Value.ToString();
                FuangTb.Text = row.Cells[3].Value.ToString();
                FtotalTb.Text = row.Cells[4].Value.ToString();
                selectedName = FnameTb.Text; // Simpan nama yang dipilih
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update FidyahTbl set [Nama Pembayar]='" + FnameTb.Text + "',[Tanggal Pembayaran]='" + FtanggalTb.Text + "',[Jumlah Beras]='" + FberasTb.Text + "',[Jumlah Uang]='" + FuangTb.Text + "',[Total Pembayaran]='" + FtotalTb.Text + "' where [Nama Pembayar]='" + FnameTb.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Telah Diedit");
                con.Close();
                populate();
            }
            catch { }
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide(); // atau this.Close(); jika kamu ingin menutup form ZakatForm
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FnameTb.Clear();
            FtanggalTb.Clear();
            FberasTb.Clear();
            FuangTb.Clear();
            FtotalTb.Clear();
        }

        private void ZnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FtanggalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FberasTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FtanggalTb_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit(); // This will close the whole application
        }

        private void FnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            int startX = 50;
            int startY = 50;
            int offsetY = 0;

            // Judul
            e.Graphics.DrawString("Laporan Pembayaran Fidyah", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);
            offsetY += 40;

            // Header kolom
            for (int i = 0; i < FidyahGv.Columns.Count; i++)
            {
                string headerText = FidyahGv.Columns[i].HeaderText;
                e.Graphics.DrawString(headerText, font, Brushes.Black, startX + (i * 100), startY + offsetY);
            }

            offsetY += 30;

            // Isi data
            while (rowIndex < FidyahGv.Rows.Count)
            {
                DataGridViewRow row = FidyahGv.Rows[rowIndex];
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < FidyahGv.Columns.Count; i++)
                    {
                        object value = row.Cells[i].Value;
                        string cellText = value != null ? value.ToString() : string.Empty;
                        e.Graphics.DrawString(cellText, font, Brushes.Black, startX + (i * 100), startY + offsetY);
                    }

                    offsetY += 25;

                    // Jika halaman penuh
                    if (offsetY > e.MarginBounds.Height)
                    {
                        rowIndex++;
                        e.HasMorePages = true;
                        return;
                    }
                }

                rowIndex++;
            }

            // Selesai
            rowIndex = 0;
            e.HasMorePages = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedName))
            {
                MessageBox.Show("Pilih dulu data Pembayar yang ingin dicetak.");
                return;
            }

            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            int startX = 50;
            int startY = 50;

            // Judul
            e.Graphics.DrawString("Laporan Fidyah Individu", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);
            startY += 40;

            // Cari baris berdasarkan nama
            foreach (DataGridViewRow row in FidyahGv.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString() == selectedName)
                {
                    for (int i = 0; i < FidyahGv.Columns.Count; i++)
                    {
                        string label = FidyahGv.Columns[i].HeaderText;
                        string value = row.Cells[i].Value.ToString();
                        e.Graphics.DrawString(label + ": " + value, font, Brushes.Black, startX, startY);
                        startY += 25;
                    }
                    break;
                }
            }
        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void FtotalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FtanggalTb_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
