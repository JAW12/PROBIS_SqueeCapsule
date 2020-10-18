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
    public partial class StokFasilitas : Form
    {
        public StokFasilitas()
        {
            InitializeComponent();
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
            Login.login.Show();
            this.Hide();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.booking != null)
            {
                Login.booking.Show();
                this.Hide();
            }
            else
            {
                Login.booking = new Booking();
                Login.booking.Show();
                this.Hide();
            }
        }

        private void peminjamanFasilitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.peminjaman_fasilitas != null)
            {
                Login.peminjaman_fasilitas.Show();
                this.Hide();
            }
            else
            {
                Login.peminjaman_fasilitas = new PeminjamanFasilitas();
                Login.peminjaman_fasilitas.Show();
                this.Hide();
            }
        }

        private void StokFasilitas_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                String query = "Select NAMA_FASILITAS as FASILITAS, JUMLAH_TERSEDIA as JUMLAH, 'Rp.'||TO_CHAR(BIAYA_PEMINJAMAN, '999G990D00', 'NLS_NUMERIC_CHARACTERS = '',.''')|| ' / ITEM' as HARGA from fasilitas";
                DataTable dt = Login.db.executeDataTable(query);
                dgvFasilitas.Columns.Clear();
                dgvFasilitas.DataSource = dt;
            }
        }
    }
}
