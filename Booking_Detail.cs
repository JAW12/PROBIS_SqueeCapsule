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
        public int id_booking;
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
            Login.booking = new Booking();
            Login.booking.Show();
            this.Hide();
        }

        private void dgvDetail_VisibleChanged(object sender, EventArgs e)
        {
            MessageBox.Show(id_booking.ToString());
            loadData();
        }

        public void loadData()
        {
            //String query = "Select * from H_BOOKING where ROW_ID_BOOKING="+$"'{id_booking}'";
            //DataTable dt = Login.db.executeDataTable(query);
            //lblCIN.Text = dt.Rows[0]["TANGGAL_CHECK_IN"].ToString();
            //lblCOUT.Text = dt.Rows[0]["TANGGAL_CHECK_OUT"].ToString();
            //lblSingle.Text = dt.Rows[0]["JUMLAH_KAMAR_SINGLE"].ToString();
            //lblFamily.Text = dt.Rows[0]["JUMLAH_KAMAR_FAMILY"].ToString();
        }
    }
}
