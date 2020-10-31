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
        private int row_id_booking;

        //lempar data dari booking_ubah
        public BookingDetail()
        {
            InitializeComponent();
        }

        public BookingDetail(int row_id_booking)
        {
            InitializeComponent();
            this.row_id_booking = row_id_booking;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private String formatSeparator(int input)
        {
            return String.Format("{0:#,##0}", input);
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

        public void resetDGV(ref DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Visible = true;
            }
        }

        public void loadSuggestionKamar(int single, int family)
        {
            String query;
            DataTable dt;

            //reset dgv
            resetDGV(ref dgvDetail);
            dgvDetail.Columns["Subtotal"].Visible = false;

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
                if (single == 0 && family == 0)
                {
                    break;
                }
            }
        }

        public void loadBookedRooms()
        {
            String query;
            DataTable dt;

            //reset dgv
            resetDGV(ref dgvDetail);

            //get data
            query = $"SELECT * FROM V_DETAIL_BOOKING_KAMAR WHERE ROW_ID_BOOKING = {Login.id_booking}";
            dt = Login.db.executeDataTable(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int harga = Convert.ToInt32(dt.Rows[i]["SUBTOTAL"]) + Convert.ToInt32(dt.Rows[i]["HARGA_KAMAR"]);

                dgvDetail.Rows.Add(
                    (i + 1).ToString(),
                    dt.Rows[i]["NOMOR_KAMAR"],
                    dt.Rows[i]["JENIS_KAMAR"],
                    formatSeparator(harga)
                );
            }

            //dgvDetail.DataSource = dt;
        }

        public void loadData()
        {
            int single, family;
            String query = "Select * from H_BOOKING H,TAMU T where ROW_ID_BOOKING=" + $"'{Login.id_booking}' AND H.ROW_ID_TAMU = T.ROW_ID_TAMU";
            DataTable dt = Login.db.executeDataTable(query);
            lblCIN.Text = dt.Rows[0]["TANGGAL_CHECK_IN"].ToString();

            //cek apakah null
            if(dt.Rows[0]["TANGGAL_CHECK_OUT"] == DBNull.Value)
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
            if (dt.Rows[0]["TOTAL_HARGA"] == DBNull.Value)
            {
                lblTotal.Text = "Rp. 0,-";
            }
            else
            {
                lblTotal.Text = "Rp. " + formatSeparator(Convert.ToInt32(dt.Rows[0]["TOTAL_HARGA"]));
            }
            lblNama.Text = dt.Rows[0]["NAMA_TAMU"].ToString();
            lblEmail.Text = dt.Rows[0]["EMAIL"].ToString();
            lblTelepon.Text = dt.Rows[0]["NOMOR_TELEPON"].ToString();

            // atur judul
            String kodebooking = dt.Rows[0]["ROW_ID_BOOKING"].ToString();
            String tglInsert = dt.Rows[0]["INSERT_AT"].ToString();
            String judul = "Kode Booking #" + kodebooking + " - " + tglInsert;
            lblJudul.Text = judul;

            //atur status
            String statusbooking = dt.Rows[0]["STATUS_BOOKING"].ToString();
            if (statusbooking == "0")
            {
                lblStatus.Text = "Belum Check In";

                //tampilkan suggestion kamar apabila belum check in
                loadSuggestionKamar(single, family);
            }
            else
            {
                if (statusbooking == "-1")
                {
                    lblStatus.Text = "Dibatalkan";
                }
                else if (statusbooking == "1")
                {
                    lblStatus.Text = "Sedang Menginap";
                }
                else if (statusbooking == "2")
                {
                    lblStatus.Text = "Sudah Check Out";
                }

                //tampilkan kamar yang dibooking apabila sudah checkin / dibatalkan
                loadBookedRooms();
            }

            //MessageBox.Show("Status Booking : " + statusbooking);
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

        private void pbEdit_Click(object sender, EventArgs e)
        {
            BookingUbah formUbah = new BookingUbah("Update", Login.id_booking);

            formUbah.Show();
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String nomorkamar_str = dgvDetail.Rows[e.RowIndex].Cells["NoKamar"].Value.ToString();
                int nokamar = Convert.ToInt32(nomorkamar_str);

                BookingDetailKamar detailkamar = new BookingDetailKamar(Login.id_booking, nokamar);
                detailkamar.Show();
            }
        }
    }
}
