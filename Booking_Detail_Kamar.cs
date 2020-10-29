using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROBIS_SqueeCapsule
{
    public partial class BookingDetailKamar : Form
    {
        private int row_id_booking;
        private int nomor_kamar;

        private int totalpeminjaman;
        private int hargakamar;

        public BookingDetailKamar()
        {
            InitializeComponent();
        }

        public BookingDetailKamar(int row_id_booking, int nomor_kamar)
        {
            InitializeComponent();
            this.row_id_booking = row_id_booking;
            this.nomor_kamar = nomor_kamar;

            this.totalpeminjaman = 0;
            this.hargakamar = 0;

            loadData();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            Login.booking_detail.loadData();
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private String formatSeparator(int input)
        {
            return String.Format("{0:#,##0}", input);
        }

        private void loadData()
        {
            loadDataKamar();
            loadDataPeminjaman();

            int totalsemuabiaya = totalpeminjaman + hargakamar;
            lblTotal.Text = "Rp. " + formatSeparator(totalsemuabiaya);
        }

        private void loadDataKamar()
        {
            String query = $"select * from kamar where nomor_kamar = {nomor_kamar}";
            DataTable dt = Login.db.executeDataTable(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                lblNo.Text = nomor_kamar.ToString();
                hargakamar = Convert.ToInt32(row["HARGA_KAMAR"].ToString());
                lblHarga.Text = "Rp. " + formatSeparator(hargakamar);
                lblHargakamar.Text = "Rp. " + formatSeparator(hargakamar);

                String jeniskamar = row["JENIS_KAMAR"].ToString();
                if (jeniskamar == "0")
                {
                    lblJenis.Text = "Single";
                }
                else if (jeniskamar == "1")
                {
                    lblJenis.Text = "Family";
                }
            }
        }

        private void loadDataPeminjaman()
        {
            //datagridview
            String query = $"SELECT NAMA_FASILITAS AS \"Nama Fasilitas\", JUMLAH_PEMINJAMAN AS \"Jumlah\", BIAYA_PEMINJAMAN AS \"Biaya Peminjaman\", SUBTOTAL AS \"Subtotal\" FROM V_DETAIL_FASILITAS_KAMAR WHERE ROW_ID_BOOKING = {row_id_booking} AND NOMOR_KAMAR = {nomor_kamar}";
            DataTable dt = Login.db.executeDataTable(query);
            dgvPeminjaman.DataSource = dt;

            //label total
            query = $"SELECT NVL(SUM(SUBTOTAL), 0) AS TOTAL FROM V_DETAIL_FASILITAS_KAMAR WHERE ROW_ID_BOOKING = {row_id_booking} AND NOMOR_KAMAR = {nomor_kamar}";

            try
            {
                totalpeminjaman = Convert.ToInt32(Login.db.executeScalar(query));
                lblTotalPeminjaman.Text = "Rp. " + formatSeparator(totalpeminjaman);
            }
            catch (Exception x)
            {
                lblTotalPeminjaman.Text = "Rp. 0";
                MessageBox.Show(x.ToString());
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
