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
    public partial class Home : Form
    {
        public Home()
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
            if (Login.booking!= null)
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

        private void stokFasilitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.stok_fasilitas != null)
            {
                Login.stok_fasilitas.Show();
                this.Hide();
            }
            else
            {
                Login.stok_fasilitas = new StokFasilitas();
                Login.stok_fasilitas.Show();
                this.Hide();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void laporanStokFasilitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fasilitas rpt = new Fasilitas();
            rpt.SetDatabaseLogon("proyekbisnis1", "proyekbisnis1", "orcl", "");
            LaporanFasilitas fasilitas = new LaporanFasilitas();
            fasilitas.crystalReportViewer1.ReportSource = rpt;
            fasilitas.ShowDialog();
        }
    }
}
