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
    public partial class BookingTamu : Form
    {
        public BookingTamu()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        private void BookingTamu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BookingTamu_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData(String query = "Select * from TAMU")
        {
            dgvKamar.Rows.Clear();
            DataTable dt = new DataTable();
            dt = Login.db.executeDataTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvKamar.Rows.Add((i+1),dt.Rows[i]["NAMA_TAMU"].ToString(),dt.Rows[i]["NOMOR_TELEPON"].ToString(),dt.Rows[i]["EMAIL"].ToString());
            }
        }

        private void dgvKamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                BookingUbah.id_tamu = e.RowIndex+1;
                BookingUbah.nama = dgvKamar.Rows[e.RowIndex].Cells[1].Value.ToString();
                BookingUbah.telp = dgvKamar.Rows[e.RowIndex].Cells[2].Value.ToString();
                BookingUbah.email = dgvKamar.Rows[e.RowIndex].Cells[3].Value.ToString();
                string query = "Select ROW_ID_TAMU as count from TAMU where NAMA_TAMU=" + $"'{BookingUbah.nama}' AND NOMOR_TELEPON=" + $"'{BookingUbah.telp}' AND EMAIL=" + $"'{BookingUbah.email}'" + "";
                Login.booking_ubah.loadInsert();
                this.Hide();
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loadData($"Select * from TAMU where lower(NAMA_TAMU) like '%{tbSearch.Text.ToLower()}%'");
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
