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

        private void loadData()
        {
            loadDataKamar();
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


                lblNoKamar.Text = nomor_kamar + " - " + keteranganJenis;
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
