using System.Data;
using System.Data.SqlClient;
namespace Zakatin
{
    public partial class ZakatForm : Form
    {
        int rowIndex = 0; // ✅ Tambahkan baris ini
        string selectedName = ""; // ✅ Menyimpan nama Muzakki yang dipilih

        public ZakatForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Downloads\Zakatin\Zakatindb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
        }
        void populate()
        {
            try
            {
                con.Open();
                string myquery = "select * from ZakatTbl";
                SqlDataAdapter da = new SqlDataAdapter(myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ZakatGv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch { }
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ZakatForm_Load(object sender, EventArgs e)
        {
            populate();
            ZakatGv.DefaultCellStyle.Font = new Font("Segoe UI", 10); // untuk isi sel
            ZakatGv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold); // untuk header kolom
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ZakatTbl values('" + ZnameTb.Text + "','" + ZtanggalTb.Text + "','" + ZjenisTb.Text + "','" + ZberasTb.Text + "','" + ZuangTb.Text + "','" + ZtotalTb.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Telah Disimpan");
                con.Close();
                populate();
            }
            catch { }
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void ZakatGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ZakatGv.Rows[e.RowIndex];
                ZnameTb.Text = row.Cells[0].Value.ToString();
                ZtanggalTb.Text = row.Cells[1].Value.ToString();
                ZjenisTb.Text = row.Cells[2].Value.ToString();
                ZberasTb.Text = row.Cells[3].Value.ToString();
                ZuangTb.Text = row.Cells[4].Value.ToString();
                ZtotalTb.Text = row.Cells[5].Value.ToString();

                selectedName = row.Cells[0].Value.ToString(); // ✅ Simpan nama yang dipilih
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ZnameTb.Text == "")
            {
                MessageBox.Show("Masukan Nama Muzakki");
            }
            else
            {
                con.Open();
                string myquery = "delete from ZakatTbl where [Nama Muzakki]= '" + ZnameTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Muzakki Telah Dihapus");
                con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update ZakatTbl set [Nama Muzakki]='" + ZnameTb.Text + "',[Tanggal Pembayaran]='" + ZtanggalTb.Text + "',[Jenis Zakat]='" + ZjenisTb.Text + "',[Jumlah Beras]='" + ZberasTb.Text + "',[Jumlah Uang]='" + ZuangTb.Text + "',[Total Zakat]='" + ZtotalTb.Text + "' where [Nama Muzakki]='" + ZnameTb.Text + "'", con);
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // This will close the whole application
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // This will close the whole application
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZnameTb.Clear();
            ZtanggalTb.Clear();
            ZjenisTb.Clear();
            ZberasTb.Clear();
            ZuangTb.Clear();
            ZtotalTb.Clear();
        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ZnameTb.Clear();
            ZtanggalTb.Clear();
            ZjenisTb.Clear();
            ZberasTb.Clear();
            ZuangTb.Clear();
            ZtotalTb.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            int startX = 50;
            int startY = 50;
            int offsetY = 0;

            // Judul
            e.Graphics.DrawString("Laporan Pembayaran Zakat", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);
            offsetY += 40;

            // Header kolom
            for (int i = 0; i < ZakatGv.Columns.Count; i++)
            {
                string headerText = ZakatGv.Columns[i].HeaderText;
                e.Graphics.DrawString(headerText, font, Brushes.Black, startX + (i * 100), startY + offsetY);
            }

            offsetY += 30;

            // Isi data
            while (rowIndex < ZakatGv.Rows.Count)
            {
                DataGridViewRow row = ZakatGv.Rows[rowIndex];
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < ZakatGv.Columns.Count; i++)
                    {
                        object value = row.Cells[i].Value;
                        string cellText = value != null ? value.ToString() : "";
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

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            int startX = 50;
            int startY = 50;

            // Judul
            e.Graphics.DrawString("Laporan Zakat Individu", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, startX, startY);
            startY += 40;

            // Cari baris berdasarkan nama
            foreach (DataGridViewRow row in ZakatGv.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString() == selectedName)
                {
                    for (int i = 0; i < ZakatGv.Columns.Count; i++)
                    {
                        string label = ZakatGv.Columns[i].HeaderText;
                        string value = row.Cells[i].Value.ToString();
                        e.Graphics.DrawString(label + ": " + value, font, Brushes.Black, startX, startY);
                        startY += 25;
                    }
                    break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedName))
            {
                MessageBox.Show("Pilih dulu data muzakki yang ingin dicetak.");
                return;
            }

            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }
    }
}
