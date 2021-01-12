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
                Login.booking.Left = this.Left;
                Login.booking.Top = this.Top;
                Login.booking.Show();
                this.Hide();
            }
            else
            {
                Login.booking = new Booking();
                Login.booking.Left = this.Left;
                Login.booking.Top = this.Top;
                Login.booking.Show();
                this.Hide();
            }
        }

        private void peminjamanFasilitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.peminjaman_fasilitas != null)
            {
                Login.peminjaman_fasilitas.Left = this.Left;
                Login.peminjaman_fasilitas.Top = this.Top;
                Login.peminjaman_fasilitas.Show();
                this.Hide();
            }
            else
            {
                Login.peminjaman_fasilitas = new PeminjamanFasilitas();
                Login.peminjaman_fasilitas.Left = this.Left;
                Login.peminjaman_fasilitas.Top = this.Top;
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void StokFasilitas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fasilitasv2 rpt = new Fasilitasv2();
            rpt.SetDatabaseLogon("proyekbisnis1", "proyekbisnis1", "orcl", "");
            LaporanFasilitas table = new LaporanFasilitas();
            table.crystalReportViewer1.ReportSource = rpt;
            table.ShowDialog();
        }
    }
}
