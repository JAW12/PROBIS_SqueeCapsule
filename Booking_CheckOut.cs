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
        int harga,total;
        public int totalFasilitas;
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
            lblJudul.Text = "Kode Booking " + dt.Rows[0]["KODE_BOOKING"].ToString();

            // KASIH PENGECEKAN APAKAH DIA NULL
            // KALO GAADA NTAR ERROR - winda
            //if (dt.Rows[0]["TOTAL_HARGA"] == DBNull.Value)
            //{
            //    harga = 0;
            //}
            //else
            //{
            //    harga = Convert.ToInt32(dt.Rows[0]["TOTAL_HARGA"]);
            //}
            DateTime checkIn = (DateTime)dt.Rows[0]["TANGGAL_CHECK_IN"];
            DateTime checkOut;
            if (dt.Rows[0]["TANGGAL_CHECK_OUT"] == DBNull.Value)
            {
                checkOut = DateTime.Now.ToLocalTime();
            }
            else
            {
                checkOut = (DateTime)dt.Rows[0]["TANGGAL_CHECK_OUT"];
            }
            int ycheckin = Convert.ToInt32(checkIn.ToString("yyyy"));
            int ycheckout = Convert.ToInt32(checkOut.ToString("yyyy"));
            int mcheckin = Convert.ToInt32(checkIn.ToString("MM"));
            int mcheckout = Convert.ToInt32(checkOut.ToString("MM"));
            int dcheckin = Convert.ToInt32(checkIn.ToString("dd"));
            int dcheckout = Convert.ToInt32(checkOut.ToString("dd"));
            int hour = DateTime.Now.ToLocalTime().Hour;
            int minute = DateTime.Now.ToLocalTime().Minute;
            harga = 2;
            if (hour > 12 && minute > 0)
            {
                harga = ((Convert.ToInt32(dt.Rows[0]["JUMLAH_KAMAR_SINGLE"]) * 250000) + (Convert.ToInt32(dt.Rows[0]["JUMLAH_KAMAR_FAMILY"]) * 750000)) * ((ycheckout - ycheckin) + (mcheckout - mcheckin) + (dcheckout - dcheckin) + 1);
            }
            else
            {
                harga = ((Convert.ToInt32(dt.Rows[0]["JUMLAH_KAMAR_SINGLE"]) * 250000) + (Convert.ToInt32(dt.Rows[0]["JUMLAH_KAMAR_FAMILY"]) * 750000)) * ((ycheckout - ycheckin) + (mcheckout - mcheckin) + (dcheckout - dcheckin));
            }
            total = harga;
            lblHarga.Text = "Rp. " + formatSeparator(total);
            reset();
            total = total + totalFasilitas;
            lblTotal.Text = "Rp. " + formatSeparator(total);
            lblKembalian.Text = "Rp. " + formatSeparator(0);
        }

        public void reset()
        {
            tbTambahan.Text = "";
            tbKeterangan.Text = "";
            tbPembayaran.Text = "";
        }

        private void tbTambahan_TextChanged(object sender, EventArgs e)
        {
            if (tbTambahan.Text != "")
            {
                total = harga + Convert.ToInt32(tbTambahan.Text);
                lblTotal.Text = "Rp. "  + formatSeparator(total);
            }
            else
            {
                lblTotal.Text = "Rp. " + formatSeparator(total);
            }
        }

        private void tbPembayaran_TextChanged(object sender, EventArgs e)
        {
            if (tbPembayaran.Text != "")
                lblKembalian.Text = "Rp. " + formatSeparator(Convert.ToInt32(tbPembayaran.Text) - total);
            else
                lblKembalian.Text = "Rp. " + formatSeparator(0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            String query = $"Update H_Booking set TANGGAL_CHECK_OUT=to_Date('{DateTime.Now.ToLocalTime()}','dd/MM/yyyy hh24:mi:ss'),STATUS_BOOKING=2,TOTAL_HARGA={total} where ROW_ID_BOOKING={Login.id_booking}";
            Login.db.executeNonQuery(query);
            query = $"Select ROW_ID_KAMAR FROM D_BOOKING_KAMAR WHERE ROW_ID_BOOKING={Login.id_booking}";
            DataTable dt = Login.db.executeDataTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                query = $"Update KAMAR SET STATUS_TERSEDIA=1 WHERE ROW_ID_KAMAR={dt.Rows[i]["ROW_ID_KAMAR"].ToString()}";
                Login.db.executeNonQuery(query);
            }
            MessageBox.Show("Checkout Successful");
            if(tbTambahan.Text!="" && tbKeterangan.Text != "")
            {
                query = $"Update H_Booking set KETERANGAN='{tbKeterangan.Text}', BIAYA_TAMBAHAN={Convert.ToInt32(tbTambahan.Text)} where ROW_ID_BOOKING=//{Login.id_booking}";
                Login.db.executeNonQuery(query);
            }
            Login.booking.loadDGV();
            this.Hide();
            MessageBox.Show(Login.id_booking+"");
            //CRNota rpt = new CRNota();
            //rpt.SetDatabaseLogon("proyekbisnis1", "proyekbisnis1", "orcl", "");
            //Nota nota = new Nota();
            //rpt.SetParameterValue(0, Login.id_booking);
            //nota.crystalReportViewer1.ReportSource = rpt;
            //nota.ShowDialog();
        }
    }
}
