using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PROBIS_SqueeCapsule
{
    public partial class PeminjamanFasilitasInput : Form
    {
        private int row_id_booking;
        private int nomor_kamar;

        private int totalpeminjaman;
        private int hargakamar;

        public PeminjamanFasilitasInput()
        {
            InitializeComponent();
        }

        public PeminjamanFasilitasInput(int row_id_booking, int nomor_kamar)
        {
            InitializeComponent();
            this.row_id_booking = row_id_booking;
            this.nomor_kamar = nomor_kamar;

            loadData();
        }

        private String formatSeparator(int input)
        {
            return String.Format("{0:#,##0}", input);
        }

        public void loadData()
        {
            //reset dgv
            dgvFasilitas.DataSource = null;
            dgvFasilitas.Columns.Clear();

            // isi data
            loadDataKamar();
            loadDataPeminjamanFasilitas();
            setUpDGV();
            setLabelTotalValue();
        }

        private void setUpDGV()
        {
            // disable editing
            foreach (DataGridViewColumn column in dgvFasilitas.Columns)
            {
                column.ReadOnly = true;
            }

            // add textbox
            DataGridViewTextBoxColumn colJumlah = new DataGridViewTextBoxColumn();
            colJumlah.HeaderText = "Jumlah Pemesanan";
            colJumlah.Name = "JumlahPemesanan";
            colJumlah.DefaultCellStyle.NullValue = "0";

            dgvFasilitas.Columns.Add(colJumlah);

            //hide column row id
            dgvFasilitas.Columns["ROW_ID_FASILITAS"].Visible = false;
        }

        private void loadDataKamar()
        {
            String query = $"select * from kamar where nomor_kamar = {nomor_kamar}";
            DataTable dt = Login.db.executeDataTable(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                hargakamar = Convert.ToInt32(row["HARGA_KAMAR"].ToString());

                String jeniskamar = row["JENIS_KAMAR"].ToString();
                String keteranganJenis = "";
                if (jeniskamar == "0")
                {
                    keteranganJenis = "Single";
                }
                else if (jeniskamar == "1")
                {
                    keteranganJenis = "Family";
                }


                lblJudul.Text = "Input Fasilitas Kamar " + nomor_kamar + " - " + keteranganJenis;
            }
        }

        private void loadDataPeminjamanFasilitas()
        {
            String query = 
            $"SELECT " +
                $"F.ROW_ID_FASILITAS," +
                $"F.NAMA_FASILITAS AS \"Nama Fasilitas\"," +
                $"F.JUMLAH_TERSEDIA AS \"Jumlah Tersedia\"," +
                $" F.BIAYA_PEMINJAMAN AS \"Biaya\"," +
                $"NVL(SUM(V.JUMLAH_PEMINJAMAN), 0) AS \"Jumlah Sudah Dipinjam\"," +
                $"F.BIAYA_PEMINJAMAN* NVL(V.JUMLAH_PEMINJAMAN, 0) AS \"Subtotal\"  " +
            $"FROM FASILITAS F " +
            $"LEFT JOIN  " +
                $"V_DETAIL_FASILITAS_KAMAR V " +
            $"ON" +
                 $" V.ROW_ID_FASILITAS = F.ROW_ID_FASILITAS AND V.NOMOR_KAMAR = {nomor_kamar} AND V.ROW_ID_BOOKING = {row_id_booking}" +
            $"GROUP BY " +
                $"V.ROW_ID_BOOKING, " +
                $"V.STATUS_BOOKING, " +
                $"V.NOMOR_KAMAR, " +
                $"F.NAMA_FASILITAS, " +
                $"F.BIAYA_PEMINJAMAN, " +
                $"F.JUMLAH_TERSEDIA, " +
                $"F.ROW_ID_FASILITAS, " +
                $"V.JUMLAH_PEMINJAMAN " +
            $"ORDER BY F.NAMA_FASILITAS ASC";
            DataTable dt = Login.db.executeDataTable(query);

            //add kolom textbox untuk ngerubah
            //DataColumn columnInputPeminjaman = new DataColumn("Jumlah", typeof(TextBoxBase));
            //dt.Columns.Add(columnInputPeminjaman);
            
            dgvFasilitas.DataSource = dt;
        }

        private void setLabelTotalValue()
        {
            totalpeminjaman = 0;

            foreach (DataGridViewRow row in dgvFasilitas.Rows)
            {
                int biaya = Convert.ToInt32(row.Cells["Biaya"].Value.ToString());
                int jumlahPeminjaman = Convert.ToInt32(row.Cells["Jumlah Sudah Dipinjam"].Value.ToString());
                                
                int jumlahPemesanan = 0;
                if (dgvFasilitas.Columns.Contains("JumlahPemesanan") && row.Cells["JumlahPemesanan"].Value != null)
                {
                    jumlahPemesanan = Convert.ToInt32(row.Cells["JumlahPemesanan"].Value.ToString());
                }

                totalpeminjaman += biaya * (jumlahPeminjaman + jumlahPemesanan);
            }
            lblTotal.Text = "Rp. " + formatSeparator(totalpeminjaman);
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Login.peminjaman_fasilitas.loadData();
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void changeDGV(int jumlahPemesanan, int rowIndex)
        {
            int currJumlahTersedia = Convert.ToInt32(dgvFasilitas.Rows[rowIndex].Cells["Jumlah Tersedia"].Value.ToString());

            int currSubtotal = Convert.ToInt32(dgvFasilitas.Rows[rowIndex].Cells["Subtotal"].Value.ToString());

            int currJumlahSudahDipinjam = Convert.ToInt32(dgvFasilitas.Rows[rowIndex].Cells["Jumlah Sudah Dipinjam"].Value.ToString());

            int biayaPeminjaman = Convert.ToInt32(dgvFasilitas.Rows[rowIndex].Cells["Biaya"].Value.ToString());


            //atur value baru
            dgvFasilitas.Rows[rowIndex].Cells["Jumlah Tersedia"].Value = currJumlahTersedia - jumlahPemesanan;
            dgvFasilitas.Rows[rowIndex].Cells["Subtotal"].Value = biayaPeminjaman * (currJumlahSudahDipinjam + jumlahPemesanan);
        }

        private void dgvFasilitas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {       
            //buat pastikan bahwa yg diedit adalah kolom JumlahPemesanan
            if (e.RowIndex >= 0)
            {
                int columnIndex = dgvFasilitas.CurrentCell.ColumnIndex;
                string columnName = dgvFasilitas.Columns[columnIndex].Name;
                               
                if (columnName == "JumlahPemesanan")
                {
                    int jumlahPemesanan = 0;

                    if (dgvFasilitas.Rows[e.RowIndex].Cells[columnName].Value != null)
                    {
                        jumlahPemesanan = Convert.ToInt32(dgvFasilitas.Rows[e.RowIndex].Cells[columnName].Value.ToString());
                    }
                    

                    if (jumlahPemesanan < 0)
                    {
                        MessageBox.Show("Jumlah Pemesanan tidak boleh kurang dari 0");
                    }
                    else 
                    {
                        changeDGV(jumlahPemesanan, e.RowIndex);
                        setLabelTotalValue();
                    }
                }
            }
        }

        private void dgvFasilitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dgvFasilitas.CurrentCell.ColumnIndex;
            string columnName = dgvFasilitas.Columns[columnIndex].Name;
            MessageBox.Show(columnName);
        }

        private void dgvFasilitas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // buat supaya kolom jumlah pemesanan cuma menerima input numeric
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnJumlahPemesanan_KeyPress);

            int columnIndex = dgvFasilitas.CurrentCell.ColumnIndex;
            string columnName = dgvFasilitas.Columns[columnIndex].Name;

            if (columnName == "JumlahPemesanan")
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnJumlahPemesanan_KeyPress);
                }
            }
        }

        private void ColumnJumlahPemesanan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // buat supaya kolom jumlah pemesanan cuma menerima input numeric
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void RunOracleTransaction(OracleConnection connection)
        {
            connection.Close();
            connection.Open();

            OracleCommand command = connection.CreateCommand();
            OracleTransaction transaction;

            // Start a local transaction
            transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

            // Assign transaction object for a pending local transaction
            command.Transaction = transaction;

            try
            {
                updateDataPeminjamanFasilitas(ref command);
                transaction.Commit();

                // load ulang data
                loadData();

                MessageBox.Show("Perubahan data berhasil dicatat");
            }
            catch (Exception e)
            {
                transaction.Rollback();
                MessageBox.Show(e.ToString());
            }
        }

        private void updateDataPeminjamanFasilitas(ref OracleCommand command)
        {
            String query;

            //dapatkan id kamar
            query = $"SELECT ROW_ID_KAMAR FROM KAMAR WHERE NOMOR_KAMAR = '{nomor_kamar}'";
            command.CommandText = query;
            int row_id_kamar = Convert.ToInt32(command.ExecuteScalar());

            int totalBiayaPeminjaman = 0;
            foreach (DataGridViewRow row in dgvFasilitas.Rows)
            {
                int row_id_fasilitas = Convert.ToInt32(row.Cells["ROW_ID_FASILITAS"].Value.ToString());

                int currJumlahTersedia = Convert.ToInt32(row.Cells["Jumlah Tersedia"].Value.ToString());

                int currSubtotal = Convert.ToInt32(row.Cells["Subtotal"].Value.ToString());

                int biayaPeminjaman = Convert.ToInt32(row.Cells["Biaya"].Value.ToString());

                //default jumlah sudah dipinjam = 0
                int currJumlahSudahDipinjam = 0;
                if (row.Cells["Jumlah Sudah Dipinjam"].Value != null)
                {
                    currJumlahSudahDipinjam = Convert.ToInt32(row.Cells["Jumlah Sudah Dipinjam"].Value.ToString());
                }

                // default jumlah pemesanan = 0
                int jumlahPemesanan = 0;
                if (row.Cells["JumlahPemesanan"].Value != null)
                {
                    jumlahPemesanan = Convert.ToInt32(row.Cells["JumlahPemesanan"].Value.ToString());
                }

                int subtotal = biayaPeminjaman * (currJumlahSudahDipinjam + jumlahPemesanan);

                totalBiayaPeminjaman += subtotal;

                //kurangi stok fasilitas
                query = $"UPDATE FASILITAS SET JUMLAH_TERSEDIA = {currJumlahTersedia} WHERE ROW_ID_FASILITAS = {row_id_fasilitas}";
                command.CommandText = query;
                command.ExecuteNonQuery();

                //tambah subtotal di h_booking
                query = $"UPDATE H_BOOKING SET SUBTOTAL = SUBTOTAL + {biayaPeminjaman} WHERE ROW_ID_BOOKING = {row_id_booking}";
                command.CommandText = query;
                command.ExecuteNonQuery();

                //cek apakah row peminjaman sudah ada di db
                query =
                    $"SELECT NVL(COUNT(ROW_ID_BOOKING),0) FROM D_BOOKING_FASILITAS " +
                    $"WHERE ROW_ID_BOOKING = {row_id_booking} AND ROW_ID_KAMAR = {row_id_kamar} AND ROW_ID_FASILITAS = {row_id_fasilitas}";
                command.CommandText = query;
                int resultcount = Convert.ToInt32(command.ExecuteScalar());

                if (command.Connection.State == ConnectionState.Closed)
                {
                    command.Connection.Open();
                }

                if (resultcount > 0)
                {
                    // kalo sudah ada berarti update
                    query = $"UPDATE D_BOOKING_FASILITAS SET JUMLAH_PEMINJAMAN = JUMLAH_PEMINJAMAN + {jumlahPemesanan}, SUBTOTAL = {subtotal} WHERE ROW_ID_BOOKING = {row_id_booking} AND ROW_ID_FASILITAS = {row_id_fasilitas} AND ROW_ID_KAMAR = {row_id_kamar}";

                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
                else
                {
                    // kalo belum ada berarti insert
                    query = $"INSERT INTO D_BOOKING_FASILITAS" +
                        $"(ROW_ID_BOOKING, ROW_ID_FASILITAS, ROW_ID_KAMAR, JUMLAH_PEMINJAMAN, BIAYA_PEMINJAMAN, SUBTOTAL) " +
                        $"VALUES({row_id_booking},{row_id_fasilitas},{row_id_kamar},{jumlahPemesanan},{biayaPeminjaman},{subtotal})";

                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
        }


        private void btnKumpul_Click(object sender, EventArgs e)
        {
            RunOracleTransaction(Login.db.getConnection());
            Login.peminjaman_fasilitas.loadData();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void PeminjamanFasilitasInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
