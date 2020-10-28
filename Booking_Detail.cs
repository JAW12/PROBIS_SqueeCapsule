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
    public partial class BookingDetail : Form
    {
        //lempar data dari booking_ubah
        public BookingDetail()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string query = "Select ROW_ID_TAMU from H_BOOKING where ROW_ID_BOOKING=" + $"'{Login.id_booking}'";
            int idTamu = Convert.ToInt32(Login.db.executeScalar(query));
            query = "Delete from H_BOOKING where ROW_ID_BOOKING=" + $"'{Login.id_booking}'";
            Login.db.executeNonQuery(query);
            query = "Delete from TAMU where ROW_ID_TAMU = " + idTamu;
            Login.db.executeNonQuery(query);
            MessageBox.Show("Insert dibatalkan");
            Login.id_booking = -1;
            Login.booking = new Booking();
            Login.booking.Show();
            this.Hide();
        }

        public void loadData()
        {
            int single, family;
            String query = "Select * from H_BOOKING H,TAMU T where ROW_ID_BOOKING=" + $"'{Login.id_booking}' AND H.ROW_ID_TAMU = T.ROW_ID_TAMU";
            DataTable dt = Login.db.executeDataTable(query);
            lblCIN.Text = dt.Rows[0]["TANGGAL_CHECK_IN"].ToString();
            if(dt.Rows[0]["TANGGAL_CHECK_OUT"].ToString() == null)
            {
                lblCOUT.Text = "Belum diketahui";
            }
            else
            {
                lblCOUT.Text = dt.Rows[0]["TANGGAL_CHECK_OUT"].ToString();
            }
            lblSingle.Text = dt.Rows[0]["JUMLAH_KAMAR_SINGLE"].ToString();
            single = Convert.ToInt32(dt.Rows[0]["JUMLAH_KAMAR_SINGLE"]);
            lblFamily.Text = dt.Rows[0]["JUMLAH_KAMAR_FAMILY"].ToString();
            family = Convert.ToInt32(dt.Rows[0]["JUMLAH_KAMAR_FAMILY"]);
            lblTotal.Text = dt.Rows[0]["TOTAL_HARGA"].ToString();
            lblNama.Text = dt.Rows[0]["NAMA_TAMU"].ToString();
            lblEmail.Text = dt.Rows[0]["NOMOR_TELEPON"].ToString();
            lblTelepon.Text = dt.Rows[0]["EMAIL"].ToString();
            dgvDetail.Columns[3].Visible = false;
            dgvDetail.Columns[4].Visible = false;
            query = "Select NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR from KAMAR K where STATUS_TERSEDIA = 1";
            dt = Login.db.executeDataTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["JENIS_KAMAR"].ToString() == "0" && single > 0)
                {
                    dgvDetail.Rows.Add(dt.Rows[i]["NOMOR_KAMAR"].ToString(), "Single", dt.Rows[i]["HARGA_KAMAR"].ToString());
                    single -= 1;
                }
                if (dt.Rows[i]["JENIS_KAMAR"].ToString() == "1" && family > 0)
                {
                    dgvDetail.Rows.Add(dt.Rows[i]["NOMOR_KAMAR"].ToString(), "Family", dt.Rows[i]["HARGA_KAMAR"].ToString());
                    family -= 1;
                }
                if(single == 0 && family == 0)
                {
                    break;
                }
            }
        }

        private void BookingDetail_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Login.booking_checkin = new BookingCheckIn();
            Login.booking_checkin.Show();
            this.Hide();
        }
    }
}
