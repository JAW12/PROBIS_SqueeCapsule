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
    public partial class BookingCheckOut : Form
    {
        int harga;
        public BookingCheckOut()
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

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BookingCheckOut_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BookingCheckOut_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private String formatSeparator(int input)
        {
            return String.Format("{0:#,##0}", input);
        }

        public void loadData()
        {
            String query = "Select * from H_BOOKING H,TAMU T where ROW_ID_BOOKING=" + $"'{Login.id_booking}' AND H.ROW_ID_TAMU = T.ROW_ID_TAMU";
            DataTable dt = Login.db.executeDataTable(query);
            lblJudul.Text = Login.id_booking.ToString();
            harga = Convert.ToInt32(dt.Rows[0]["TOTAL_HARGA"]);
            lblHarga.Text = formatSeparator(harga);
            reset();
            lblTotal.Text = formatSeparator(harga + Convert.ToInt32(tbTambahan.Text));
            lblKembalian.Text = formatSeparator(Convert.ToInt32(tbPembayaran.Text) - Convert.ToInt32(lblTotal.Text));
        }

        public void reset()
        {
            tbTambahan.Text = "";
            tbKeterangan.Text = "";
            tbPembayaran.Text = "";
        }

        private void tbTambahan_TextChanged(object sender, EventArgs e)
        {
            lblTotal.Text = formatSeparator(harga + Convert.ToInt32(tbTambahan.Text));
        }

        private void tbPembayaran_TextChanged(object sender, EventArgs e)
        {
            lblKembalian.Text = formatSeparator(Convert.ToInt32(tbPembayaran.Text) - Convert.ToInt32(lblTotal.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            String query = $"Update H_Booking set TANGGAL_CHECK_OUT={DateTime.Now}, STATUS_BOOKING=2, SUBTOTAL={harga}, BIAYA_TAMBAHAN={Convert.ToInt32(tbTambahan.Text)}, KETERANGAN={tbKeterangan.Text}, TOTAL_HARGA={harga + Convert.ToInt32(tbTambahan.Text)} where ROW_ID_BOOKING=" + $"'{Login.id_booking}' AND H.ROW_ID_TAMU = T.ROW_ID_TAMU";
        }
    }
}
