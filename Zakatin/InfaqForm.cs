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
    public partial class InfaqForm : Form
    {
        public InfaqForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Downloads\Zakatin\Zakatindb.mdf"";Integrated Security=True;Connect Timeout=30");
        private string? selectedname;

        public static int rowIndex { get; private set; }

        void populate()
        {
            try
            {
                con.Open();
                string myquery = "select * from InfaqTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                InfaqGv.DataSource = ds.Tables[0];
                con.Close();

            }
            catch { }
            {
            }
        }
        private void FidyahGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = InfaqGv.Rows[e.RowIndex];
                InameTb.Text = row.Cells[0].Value.ToString();
                ItanggalTb.Text = row.Cells[1].Value.ToString();
                ItotalTb.Text = row.Cells[2].Value.ToString();

                selectedname = row.Cells[0].Value.ToString(); // ✅ Simpan nama yang dipilih
            }
        }

        private void InameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItanggalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void IberasTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into InfaqTbl values('" + InameTb.Text + "','" + ItanggalTb.Text + "','" + ItotalTb.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Telah Disimpan");
                con.Close();
                populate();
            }
            catch { }
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InameTb.Clear();
            ItanggalTb.Clear();
            ItotalTb.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedname))
            {
                MessageBox.Show("Pilih dulu data Pembayar yang ingin dicetak.");
                return;
            }

            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update InfaqTbl set [Nama Pembayar]='" + InameTb.Text + "',[Tanggal Pembayaran]='" + ItanggalTb.Text + "',[Jumlah Beras]='" + ItotalTb.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Telah Diedit");
                con.Close();
                populate();
            }
            catch { }
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (InameTb.Text == "")
            {
                MessageBox.Show("Masukan Nama Muzakki");
            }
            else
            {
                con.Open();
                string myquery = "delete from InfaqTbl where [Nama Pembayar]= '" + InameTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Pembayar Telah Dihapus");
                con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void InfaqForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            int startX = 50;
            int startY = 50;
            int offsetY = 0;

            // Judul
            e.Graphics.DrawString("Laporan Pembayaran Fidyah", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);
            offsetY += 40;

            // Header kolom
            for (int i = 0; i < InfaqGv.Columns.Count; i++)
            {
                string headerText = InfaqGv.Columns[i].HeaderText;
                e.Graphics.DrawString(headerText, font, Brushes.Black, startX + (i * 100), startY + offsetY);
            }

            offsetY += 30;

            // Isi data
            while (rowIndex < InfaqGv.Rows.Count)
            {
                DataGridViewRow row = InfaqGv.Rows[rowIndex];
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < InfaqGv.Columns.Count; i++)
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

                NewMethod();
            }
        }

        private static void NewMethod()
        {
            rowIndex++;
        }

        private void printPreviewDialog1_Load_1(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            int startX = 50;
            int startY = 50;

            // Judul
            e.Graphics.DrawString("Laporan Fidyah Individu", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);
            startY += 40;

            // Cari baris berdasarkan nama
            foreach (DataGridViewRow row in InfaqGv.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString() == selectedname)
                {
                    for (int i = 0; i < InfaqGv.Columns.Count; i++)
                    {
                        string label = InfaqGv.Columns[i].HeaderText;
                        string value = row.Cells[i].Value.ToString();
                        e.Graphics.DrawString(label + ": " + value, font, Brushes.Black, startX, startY);
                        startY += 25;
                    }
                    break;
                }
            }
        }

        private void printPreviewDialog2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
