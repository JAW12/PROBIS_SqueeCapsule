﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (Login.booking_ubah != null)
            {
                Login.booking_ubah.Show();
                this.Hide();
            }
            else
            {
                Login.booking_ubah = new BookingUbah();
                Login.booking_ubah.Show();
                this.Hide();
            }
        }

        private void Booking_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                loadDataBooking(tbSearch.Text, dateTglAwal.Value, dateTglAkhir.Value, cbFilter.Text);
                loadJmlKamarSingle();
                loadJmlKamarFamily();
            }
        }

        public void loadDGV(String kode, DateTime tglAwal, DateTime tglAkhir, String filter)
        {
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
                    $"trim(to_char(hb.insert_at, 'Mon DD, YYYY')) as Tgl, " +
                    $"t.nama_tamu as \"Nama Pemesan\", " +
                    $"hb.row_id_booking as \"Kode Booking\", " +
                    $"hb.jumlah_kamar_single as \"Jml Kamar Single\", " +
                    $"hb.jumlah_kamar_family as \"Jml Kamar Family\", " +
                    $"to_char(hb.tanggal_check_in, 'Mon DD, YYYY') as \"Tgl Check In\", " +
                    $"to_char(hb.tanggal_check_out, 'Mon DD, YYYY') as \"Tgl Check Out\", " +
                    $"case when hb.status_booking = -1 then 'Dibatalkan' " +
                    $"when hb.status_booking = 0 then 'Belum Check In' " +
                    $"when hb.status_booking = 1 then 'Sedang Menginap' " +
                    $"when hb.status_booking = 2 then 'Sudah Check Out' " +
                    $"end as \"Status Booking\" " +
                    $"from h_booking hb, tamu t " +
                    $"where t.row_id_tamu = hb.row_id_tamu " +
                    $"and hb.tanggal_check_out is null " +
                    $"and cast(hb.tanggal_check_in as date) <= :tglAkhir " +
                    $"and hb.row_id_booking like '%{kode}%' " +
                    queryf;
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add("tglAkhir", OracleDbType.Date).Value = tglAkhir;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(temp);
                dt.Merge(temp);

                temp = new DataTable();
                query = $"select " +
                    $"trim(to_char(hb.insert_at, 'Mon DD, YYYY')) as Tgl, " +
                    $"t.nama_tamu as \"Nama Pemesan\", " +
                    $"hb.row_id_booking as \"Kode Booking\", " +
                    $"hb.jumlah_kamar_single as \"Jml Kamar Single\", " +
                    $"hb.jumlah_kamar_family as \"Jml Kamar Family\", " +
                    $"to_char(hb.tanggal_check_in, 'Mon DD, YYYY') as \"Tgl Check In\", " +
                    $"to_char(hb.tanggal_check_out, 'Mon DD, YYYY') as \"Tgl Check Out\", " +
                    $"case when hb.status_booking = -1 then 'Dibatalkan' " +
                    $"when hb.status_booking = 0 then 'Belum Check In' " +
                    $"when hb.status_booking = 1 then 'Sedang Menginap' " +
                    $"when hb.status_booking = 2 then 'Sudah Check Out' " +
                    $"end as \"Status Booking\" " +
                    $"from h_booking hb, tamu t " +
                    $"where t.row_id_tamu = hb.row_id_tamu " +
                    $"and hb.tanggal_check_out is not null " +
                    $"and cast(hb.tanggal_check_in as date) <= :tglAkhir " +
                    $"and cast(hb.tanggal_check_out as date) >= :tglAwal " +
                    $"and hb.row_id_booking like '%{kode}%' " +
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
                if (dgvRow.Cells["Tgl Check Out"].Value.ToString() == "" && dgvRow.Cells["Status Booking"].Value.ToString() != "Dibatalkan")
                {
                    jml -= Convert.ToInt32(dgvRow.Cells["Jml Kamar Single"].Value);
                }
                //else if (dgvRow.Cells["Tgl Check Out"].Value != null  dgvRow.Cells["Status Booking"].Value.ToString() != "Dibatalkan")
                //{
                //    jml -= Convert.ToInt32(dgvRow.Cells["Jml Kamar Single"].Value);
                //}
            }
            lblSingle.Text = jml.ToString();
        }

        public void loadJmlKamarFamily()
        {
            int jml = Convert.ToInt32(Login.db.executeScalar("select count(*) from kamar where jenis_kamar = 1"));
            foreach (DataGridViewRow dgvRow in dgvBooking.Rows)
            {
                if (dgvRow.Cells["Tgl Check Out"].Value.ToString() == "" && dgvRow.Cells["Status Booking"].Value.ToString() != "Dibatalkan")
                {
                    jml -= Convert.ToInt32(dgvRow.Cells["Jml Kamar Family"].Value);
                }
                //else if (dgvRow.Cells["Tgl Check Out"].Value != null  dgvRow.Cells["Status Booking"].Value.ToString() != "Dibatalkan")
                //{
                //    jml -= Convert.ToInt32(dgvRow.Cells["Jml Kamar Single"].Value);
                //}
            }
            lblFamily.Text = jml.ToString();
        }

        public void loadDataBooking(String kode, DateTime tglAwal, DateTime tglAkhir, String filter)
        {
            loadDGV(kode, tglAwal, tglAkhir, filter);

        }

        private void dateTglAwal_ValueChanged(object sender, EventArgs e)
        {
            loadDataBooking(tbSearch.Text, dateTglAwal.Value, dateTglAkhir.Value, cbFilter.Text);
            loadJmlKamarSingle();
            loadJmlKamarFamily();
        }

        private void dateTglAkhir_ValueChanged(object sender, EventArgs e)
        {
            loadDataBooking(tbSearch.Text, dateTglAwal.Value, dateTglAkhir.Value, cbFilter.Text);
            loadJmlKamarSingle();
            loadJmlKamarFamily();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataBooking(tbSearch.Text, dateTglAwal.Value, dateTglAkhir.Value, cbFilter.Text);
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                loadDataBooking(tbSearch.Text, dateTglAwal.Value, dateTglAkhir.Value, cbFilter.Text);
            }
        }
    }
}
