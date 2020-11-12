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
    public partial class PeminjamanFasilitas : Form
    {
        public PeminjamanFasilitas()
        {
            InitializeComponent();
            loadData();
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

        }

        private void stokFasilitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.stok_fasilitas != null)
            {
                Login.stok_fasilitas.Left = this.Left;
                Login.stok_fasilitas.Top = this.Top;
                Login.stok_fasilitas.Show();
                this.Hide();
            }
            else
            {
                Login.stok_fasilitas = new StokFasilitas();
                Login.stok_fasilitas.Left = this.Left;
                Login.stok_fasilitas.Top = this.Top;
                Login.stok_fasilitas.Show();
                this.Hide();
            }
        }

        public void loadData()
        {
            //ambil data penginapan yang status bookingnya = 1 (sedang menginap)
            String query = "SELECT ROW_ID_BOOKING, NOMOR_KAMAR AS \"Nomor Kamar\", NAMA_TAMU AS \"Nama Tamu\" FROM V_DATA_PENGINAPAN WHERE STATUS_BOOKING = 1";
            DataTable dt = Login.db.executeDataTable(query);
            dgvKamar.DataSource = dt;

            dgvKamar.Columns["ROW_ID_BOOKING"].Visible = false;
        }

        private void dgvKamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String nokamar_str = dgvKamar.Rows[e.RowIndex].Cells["Nomor Kamar"].Value.ToString();
                String row_id_booking_str = dgvKamar.Rows[e.RowIndex].Cells["ROW_ID_BOOKING"].Value.ToString();

                int nokamar = Convert.ToInt32(nokamar_str);
                int row_id_booking = Convert.ToInt32(row_id_booking_str);

                //buka form input peminjaman
                PeminjamanFasilitasInput inputPeminjaman = new PeminjamanFasilitasInput(row_id_booking, nokamar);
                inputPeminjaman.Show();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PeminjamanFasilitas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PeminjamanFasilitas_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                String keyword = tbSearch.Text.ToString().ToUpper();
                if (keyword.Length == 0)
                {
                    loadData();
                }
                else
                {
                    String query = $"SELECT ROW_ID_BOOKING, NOMOR_KAMAR AS \"Nomor Kamar\", NAMA_TAMU AS \"Nama Tamu\" FROM V_DATA_PENGINAPAN WHERE STATUS_BOOKING = 1 AND UPPER(NAMA_TAMU) LIKE '%{keyword}%' OR STATUS_BOOKING = 1 AND NOMOR_KAMAR LIKE '%{keyword}%'";
                    DataTable dt = Login.db.executeDataTable(query);
                    dgvKamar.DataSource = dt;

                    dgvKamar.Columns["ROW_ID_BOOKING"].Visible = false;
                }
            }
        }
    }
}
