using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Oracle.ManagedDataAccess.Client;

namespace PROBIS_SqueeCapsule
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (Login.booking_ubah != null)
            {
                Login.booking_ubah.Show();
            }
            else
            {
                Login.booking_ubah = new BookingUbah();
                Login.booking_ubah.Show();
            }
        }

        private void Booking_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                loadDGV();
                loadJmlKamarSingle();
                loadJmlKamarFamily();
                cekEnableTambahBooking();
            }
        }

        public void loadDGV()
        {
            String kode = tbSearch.Text;
            DateTime tglAwal = dateTglAwal.Value;
            DateTime tglAkhir = dateTglAkhir.Value;
            String filter = cbFilter.Text;
            String awal = tglAwal.ToString("dd/MM/yyyy");
            String akhir = tglAkhir.ToString("dd/MM/yyyy");
            String queryf = "";
            if (filter == "Dibatalkan")
            {
                queryf = " and status_booking = -1";
            }
            else if (filter == "Belum Check In")
            {
                queryf = " and status_booking = 0";
            }
            else if (filter == "Sedang Menginap")
            {
                queryf = " and status_booking = 1";
            }
            else if (filter == "Sudah Check Out")
            {
                queryf = " and status_booking = 2";
            }

            OracleConnection conn = Login.db.getConnection();
            conn.Close();
            conn.Open();
            try
            {
                DataTable dt = new DataTable();
                DataTable temp = new DataTable();
                String query = $"select " +
                    $"hb.row_id_booking as \"Id Booking\", " + 
                    $"trim(to_char(hb.insert_at, 'Mon DD, YYYY')) as \"Tgl\", " +
                    $"t.nama_tamu as \"Nama Pemesan\", " +
                    $"hb.kode_booking as \"Kode Booking\", " +
                    $"hb.jumlah_kamar_single as \"Jml Kamar Single\", " +
                    $"hb.jumlah_kamar_family as \"Jml Kamar Family\", " +
                    $"to_char(hb.tanggal_check_in, 'DD/MM/YYYY') as \"Tgl Check In\", " +
                    $"to_char(hb.tanggal_check_out, 'DD/MM/YYYY') as \"Tgl Check Out\", " +
                    $"case when hb.status_booking = -1 then 'Dibatalkan' " +
                    $"when hb.status_booking = 0 then 'Belum Check In' " +
                    $"when hb.status_booking = 1 then 'Sedang Menginap' " +
                    $"when hb.status_booking = 2 then 'Sudah Check Out' " +
                    $"end as \"Status Booking\" " +
                    $"from h_booking hb, tamu t " +
                    $"where t.row_id_tamu = hb.row_id_tamu " +
                    $"and hb.tanggal_check_out is null " +
                    $"and hb.tanggal_check_in <= to_date('{akhir}', 'DD/MM/YYYY') " +
                    $"and (hb.kode_booking like '%{kode}%' or lower(t.nama_tamu) like '%{kode.ToLower()}%') " +
                    queryf;
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("tglAkhir", OracleDbType.Date).Value = tglAkhir;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(temp);
                dt.Merge(temp);

                temp = new DataTable();
                query = $"select " +
                    $"hb.row_id_booking as \"Id Booking\", " +
                    $"trim(to_char(hb.insert_at, 'Mon DD, YYYY')) as \"Tgl\", " +
                    $"t.nama_tamu as \"Nama Pemesan\", " +
                    $"hb.kode_booking as \"Kode Booking\", " +
                    $"hb.jumlah_kamar_single as \"Jml Kamar Single\", " +
                    $"hb.jumlah_kamar_family as \"Jml Kamar Family\", " +
                    $"to_char(hb.tanggal_check_in, 'DD/MM/YYYY') as \"Tgl Check In\", " +
                    $"to_char(hb.tanggal_check_out, 'DD/MM/YYYY') as \"Tgl Check Out\", " +
                    $"case when hb.status_booking = -1 then 'Dibatalkan' " +
                    $"when hb.status_booking = 0 then 'Belum Check In' " +
                    $"when hb.status_booking = 1 then 'Sedang Menginap' " +
                    $"when hb.status_booking = 2 then 'Sudah Check Out' " +
                    $"end as \"Status Booking\" " +
                    $"from h_booking hb, tamu t " +
                    $"where t.row_id_tamu = hb.row_id_tamu " +
                    $"and hb.tanggal_check_out is not null " +
                    $"and hb.tanggal_check_in <= to_date('{akhir}', 'DD/MM/YYYY') " +
                    $"and hb.tanggal_check_out >= to_date('{awal}', 'DD/MM/YYYY') " +
                    $"and (hb.kode_booking like '%{kode}%' or lower(t.nama_tamu) like '%{kode.ToLower()}%') " +
                    queryf;
                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("tglAwal", OracleDbType.Date).Value = tglAwal;
                cmd.Parameters.Add("tglAkhir", OracleDbType.Date).Value = tglAkhir;
                da = new OracleDataAdapter(cmd);
                da.Fill(temp);
                dt.Merge(temp);

                conn.Close();
                dgvBooking.Columns.Clear();
                dgvBooking.DataSource = dt;
                dgvBooking.Columns["Id Booking"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void loadJmlKamarSingle()
        {
            int jml = Convert.ToInt32(Login.db.executeScalar("select count(*) from kamar where jenis_kamar = 0"));
            foreach (DataGridViewRow dgvRow in dgvBooking.Rows)
            {
                DateTime dcheckout = DateTime.Now;
                String checkout = dgvRow.Cells["Tgl Check Out"].Value.ToString();
                if(checkout != "")
                {
                    dcheckout = DateTime.ParseExact(checkout, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                if (dgvRow.Cells["Tgl Check Out"].Value.ToString() == "" && dgvRow.Cells["Status Booking"].Value.ToString() != "Dibatalkan" && dgvRow.Cells["Status Booking"].Value.ToString() != "Sudah Check Out")
                {
                    jml -= Convert.ToInt32(dgvRow.Cells["Jml Kamar Single"].Value);
                }
                else if (dgvRow.Cells["Tgl Check Out"].Value != null && dcheckout.ToShortDateString() != dateTglAwal.Value.ToShortDateString() && dgvRow.Cells["Status Booking"].Value.ToString() != "Dibatalkan" && dgvRow.Cells["Status Booking"].Value.ToString() != "Sudah Check Out")
                {
                    jml -= Convert.ToInt32(dgvRow.Cells["Jml Kamar Single"].Value);
                }
            }
            lblSingle.Text = jml.ToString();
        }

        public void loadJmlKamarFamily()
        {
            int jml = Convert.ToInt32(Login.db.executeScalar("select count(*) from kamar where jenis_kamar = 1"));
            foreach (DataGridViewRow dgvRow in dgvBooking.Rows)
            {
                DateTime dcheckout = DateTime.Now;
                String checkout = dgvRow.Cells["Tgl Check Out"].Value.ToString();
                if (checkout != "")
                {
                    dcheckout = DateTime.ParseExact(checkout, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }

                if (dgvRow.Cells["Tgl Check Out"].Value.ToString() == "" && dgvRow.Cells["Status Booking"].Value.ToString() != "Dibatalkan" && dgvRow.Cells["Status Booking"].Value.ToString() != "Sudah Check Out")
                {
                    jml -= Convert.ToInt32(dgvRow.Cells["Jml Kamar Family"].Value);
                }
                else if (dgvRow.Cells["Tgl Check Out"].Value != null && dcheckout.ToShortDateString() != dateTglAwal.Value.ToShortDateString() && dgvRow.Cells["Status Booking"].Value.ToString() != "Dibatalkan" && dgvRow.Cells["Status Booking"].Value.ToString() != "Sudah Check Out")
                {
                    jml -= Convert.ToInt32(dgvRow.Cells["Jml Kamar Family"].Value);
                }
            }
            lblFamily.Text = jml.ToString();
        }

        public void cekEnableTambahBooking()
        {
            int jmlSingle = int.Parse(lblSingle.Text.ToString());
            int jmlFamily = int.Parse(lblFamily.Text.ToString());
            btnTambah.Enabled = jmlSingle > 0 || jmlFamily > 0;
        }

        private void dateTglAwal_ValueChanged(object sender, EventArgs e)
        {
            loadDGV();
            loadJmlKamarSingle();
            loadJmlKamarFamily();
            cekEnableTambahBooking();
        }

        private void dateTglAkhir_ValueChanged(object sender, EventArgs e)
        {
            loadDGV();
            loadJmlKamarSingle();
            loadJmlKamarFamily();
            cekEnableTambahBooking();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDGV();
            if(cbFilter.SelectedIndex == 0)
            {
                loadJmlKamarSingle();
                loadJmlKamarFamily();
                cekEnableTambahBooking();
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                loadDGV();
            }
        }

        private void dgvBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String row_id_booking = dgvBooking.Rows[e.RowIndex].Cells["Id Booking"].Value.ToString();
                Login.id_booking = Convert.ToInt32(row_id_booking);

                if (Login.booking_detail != null)
                {
                    Login.booking_detail.Show();
                }
                else
                {
                    Login.booking_detail = new BookingDetail();
                    Login.booking_detail.Show();
                }
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Booking_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Booking_Shown(object sender, EventArgs e)
        {
            loadDGV();
            loadJmlKamarSingle();
            loadJmlKamarFamily();
            cekEnableTambahBooking();
        }

        private void Booking_Activated(object sender, EventArgs e)
        {
            loadDGV();
            loadJmlKamarSingle();
            loadJmlKamarFamily();
            cekEnableTambahBooking();
        }

        private void pbLaporan_Click(object sender, EventArgs e)
        {
            DateTime tglAwal1 = dateTglAwal.Value;
            DateTime tglAkhir1 = dateTglAkhir.Value;
            String awal = tglAwal1.ToString("dd/MM/yyyy");
            String akhir = tglAkhir1.ToString("dd/MM/yyyy");
            Crystagrafik rpt = new Crystagrafik();
            rpt.SetDatabaseLogon("proyekbisnis1", "proyekbisnis1", "orcl", "");
            
            rpt.SetParameterValue(0, awal);
            LaporanGrafik grafik = new LaporanGrafik();
            grafik.crystalReportViewer1.ReportSource = rpt;
            grafik.ShowDialog();
        }

        private void pbGrafik_Click(object sender, EventArgs e)
        {
            DateTime tglAwal1 = dateTglAwal.Value;
            String awal = tglAwal1.ToString("dd/MM/yyyy");
            CRlaporan rpt = new CRlaporan();
            rpt.SetDatabaseLogon("proyekbisnis1", "proyekbisnis1", "orcl", "");
            rpt.SetParameterValue(0, awal);
            Laporantable table = new Laporantable();
            table.crystalReportViewer1.ReportSource = rpt;
            table.ShowDialog();
        }
    }
}
