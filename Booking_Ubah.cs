using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PROBIS_SqueeCapsule
{
    public partial class BookingUbah : Form
    {
        //mode insert/update
        private String mode;

        //set variabel
        private int id_tamu = 0;

        private int id_booking;

        private Boolean tanggalValid;

        public BookingUbah()
        {
            InitializeComponent();
            this.mode = "Insert";
            btnAction.Text = "Tambah";
        }

        public BookingUbah(String mode, int idbooking)
        {
            InitializeComponent();
            this.mode = mode;
            this.id_booking = idbooking;

            setFormMode();
        }
        
        private void setFormMode()
        {
            if (mode == "Update")
            {
                lblKodeBooking.Text = "Kode Booking : " + id_booking + " - Update Data Tamu";

                //dateCIN.Enabled = false;
                //dateCOUT.Enabled = false;
                //numericSingle.Enabled = false;
                //numericFamily.Enabled = false;

                dateCIN.Visible = false;
                dateCOUT.Visible = false;
                lblSTgl.Visible = false;
                lblSCIN.Visible = false;
                lblSCOUT.Visible = false;
                numericSingle.Visible = false;
                numericFamily.Visible = false;
                lblSJumlah.Visible = false;
                lblSSingle.Visible = false;
                lblSFamily.Visible = false;
                btnPilihTamu.Visible = false;
                lblKeteranganTanggal.Visible = false;
                lblSPerkiraan.Visible = false;
                lblPerkiraan.Visible = false;
                

                btnAction.Text = "Simpan";

                this.id_tamu = getIdTamu();
                isiDataTamu();
            }
        }

        private int getIdTamu()
        {
            int id = -1;
            String query = $"select t.row_id_tamu from tamu t, h_booking hb where hb.ROW_ID_TAMU = t.ROW_ID_TAMU and hb.ROW_ID_BOOKING = {Login.id_booking}";
            try
            {
                id = Convert.ToInt32(Login.db.executeScalar(query));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return id;
        }

        private void isiDataTamu()
        {
            String query = $"select t.* from tamu t where row_id_tamu = {id_tamu}";
            DataTable dt = Login.db.executeDataTable(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbNama.Text = row["NAMA_TAMU"].ToString();
                tbTelepon.Text = row["NOMOR_TELEPON"].ToString();
                tbEmail.Text = row["EMAIL"].ToString();
            }
            else
            {
                MessageBox.Show("Error : data tamu tidak ditemukan");
            }
        }
       
        private void lblX_Click(object sender, EventArgs e)
        {
            if (mode == "Update")
            {                
                this.Close();
                Login.booking_detail.loadData();
            }
            else if (mode == "Insert")
            {
                // Application.Exit();
            }
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //regex untuk cek nama
        public bool validateName(String name)
        {
            string pattern = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
            Match match = Regex.Match(name, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //regex untuk cek no telepon
        public bool validatePhoneNum(String phoneNum)
        {
            string pattern = @"(\()?(\+\d{0,99}|\d{0,99}|0)(\d{2,3})?\)?[ .-]?\d{2,4}[ .-]?\d{2,4}[ .-]?\d{2,4}";
            Match match = Regex.Match(phoneNum, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //regex untuk cek email
        public bool validateEmail(String email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Match match = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tbNama_Leave(object sender, EventArgs e)
        {
            //cek regex
            bool cekUsername = validateName(tbNama.Text);
            if (!cekUsername)
            {
                tbNama.BackColor = Color.Red;
            }
            else
            {
                tbNama.BackColor = Color.White;
            }
        }

        private void tbTelepon_Leave(object sender, EventArgs e)
        {
            //cek regex
            bool cekTelepon = validatePhoneNum(tbTelepon.Text);
            if (!cekTelepon)
            {
                tbTelepon.BackColor = Color.Red;
            }
            else
            {
                tbTelepon.BackColor = Color.White;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            //cek regex
            bool cekEmail = validateEmail(tbEmail.Text);
            if (!cekEmail)
            {
                tbEmail.BackColor = Color.Red;
            }
            else
            {
                tbEmail.BackColor = Color.White;
            }
        }

        private void numericSingle_ValueChanged(object sender, EventArgs e)
        {
            //pangil fungsi
            totalHarga(Convert.ToInt32(numericSingle.Value), Convert.ToInt32(numericFamily.Value));
        }

        //mengganti isi text lblPerkiraan
        private void totalHarga(int single, int family)
        {
            String hasil = Convert.ToString((single * 250000) + (family * 750000));
            //berikan format uang
            // hasil = ;
            lblPerkiraan.Text = hasil;
        }

        private void numericFamily_ValueChanged(object sender, EventArgs e)
        {
            //pangil fungsi
            totalHarga(Convert.ToInt32(numericSingle.Value), Convert.ToInt32(numericFamily.Value));
        }
       

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (tbNama.BackColor == Color.Red || tbTelepon.BackColor == Color.Red || tbEmail.BackColor == Color.Red)
            {
                MessageBox.Show("Ditemukan data yang tidak sesuai");
            }
            else
            {
                //data valid, cek mode insert/update
                if (mode == "Insert")
                {
                    if (!tanggalValid)
                    {
                        MessageBox.Show("Tanggal check in tidak boleh melebihi tanggal check out");
                    }
                    else
                    {
                        bool cek = Insert(tbNama.Text, tbTelepon.Text, tbEmail.Text, Convert.ToInt32(numericSingle.Value), Convert.ToInt32(numericFamily.Value), dateCIN.Value.ToString(), dateCOUT.Value.ToString(), dateCOUT.Text);

                        if (cek)
                        {
                            MessageBox.Show("Insert Berhasil");
                            String query = "Select ROW_ID_BOOKING from H_BOOKING WHERE TANGGAL_CHECK_IN=" +
                            $"to_Date('{dateCIN.Value.ToString()}','dd/MM/yyyy hh24:mi:ss')";
                            int id_booking = Convert.ToInt32(Login.db.executeScalar(query));
                            Login.booking_detail = new BookingDetail();
                            Login.id_booking = id_booking;
                            Login.booking_detail.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Insert Gagal");
                        }
                    }
                    
                }
                else if (mode == "Update")
                {
                    ubahDataTamu();
                }
                
            }
        }

        private void ubahDataTamu()
        {
            String nama = tbNama.Text.ToString();
            String email = tbEmail.Text.ToString();
            String nohp = tbTelepon.Text.ToString();

            String query = $"update tamu set nama_tamu = '{nama}', nomor_telepon = '{nohp}', email = '{email}' where row_id_tamu = {id_tamu}";
            Boolean result = Login.db.executeNonQuery(query);

            if (result)
            {
                isiDataTamu();
                MessageBox.Show("Update data tamu berhasil");
            }
            else
            {
                MessageBox.Show("Update data tamu gagal");
            }
        }

        private void BookingUbah_VisibleChanged(object sender, EventArgs e)
        {
            // jangan dihard code insert gini. nanti update mode ku ga jalan - winda
            //mode = "Insert";
        }

        private bool Insert(String nama, String telp, String email, int single, int family, String checkindate, String checkoutdate, String cek)
        {
            String query = "Select * from kamar where STATUS_TERSEDIA = 1";
            DataTable dt = Login.db.executeDataTable(query);
            int jumlah = (single * 250000) + (family * 750000);
            string empty = "";
            //MessageBox.Show(id_tamu.ToString());
            //get kamar tersedia
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if(dt.Rows[i]["STATUS_TERSEDIA"].ToString() == "1")
            //    {
            //        if (dt.Rows[i]["JENIS_KAMAR"].ToString() == "0")
            //        {
            //            kamarSingle.Add(dt.Rows[i]["ROW_ID_KAMAR"].ToString());
            //        }
            //        else
            //        {
            //            kamarFamily.Add(dt.Rows[i]["ROW_ID_KAMAR"].ToString());
            //        }
            //    }
            //}
            //if((kamarSingle.Count < single)||(kamarFamily.Count < family)){
            //    return false;
            //}

            //insert hbooking
            if (cek == DateTime.Now.ToLongDateString())
            {
                query = "Insert into H_BOOKING(ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,TANGGAL_CHECK_IN, STATUS_BOOKING, SUBTOTAL,BIAYA_TAMBAHAN, KETERANGAN, TOTAL_HARGA) VALUES(" +
                    $"'{1}'," +
                    $"'{id_tamu.ToString()}'," +
                    $"'{single}'," +
                    $"'{family}'," +
                    $"to_Date('{checkindate}','dd/MM/yyyy hh24:mi:ss'), " +
                    $"'{0}'," +
                    $"'{jumlah}'," +
                    $"'{0}'," +
                    $"'{empty}'," +
                    $"'{jumlah}'" +
                     ")";
            }
            else
            {
                query = "Insert into H_BOOKING(ROW_ID_BOOKING, ROW_ID_TAMU, JUMLAH_KAMAR_SINGLE, JUMLAH_KAMAR_FAMILY,TANGGAL_CHECK_IN, TANGGAL_CHECK_OUT, STATUS_BOOKING, SUBTOTAL,BIAYA_TAMBAHAN, KETERANGAN, TOTAL_HARGA) VALUES(" +
                    $"'{1}'," +
                    $"'{id_tamu.ToString()}'," +
                    $"'{single}'," +
                    $"'{family}'," +
                    $"to_Date('{checkindate}','dd/MM/yyyy hh24:mi:ss'), " +
                    $"to_Date('{checkoutdate}','dd/MM/yyyy hh24:mi:ss'), " +
                    $"'{0}'," +
                    $"'{jumlah}'," +
                    $"'{0}'," +
                    $"'{empty}'," +
                    $"'{jumlah}'" +
                     ")";
            }
            Login.db.executeNonQuery(query);
            //insert kamar
            //for (int i = 0; i < single; i++)
            //{
            //    query = "UPDATE KAMAR SET STATUS_TERSEDIA="+
            //    $"'{1}' WHERE ROW_ID_KAMAR=" +
            //    $"'{kamarSingle.Count}'," +
            //    ")";
            //    Login.db.executeNonQuery(query);
            //}
            return true;
        }

        private void btnPilihTamu_Click(object sender, EventArgs e)
        {
            id_tamu = cekTamu(tbNama.Text,tbTelepon.Text,tbEmail.Text);
            //MessageBox.Show(id_tamu.ToString());
        }

        private int cekTamu(string nama,string telp, string email)
        {
            string query = "";
            //select id yg baru diinsert
            query = "Select COUNT(ROW_ID_TAMU) from TAMU where NAMA_TAMU=" + $"'{nama}' AND NOMOR_TELEPON=" + $"'{telp}' AND EMAIL=" + $"'{email}'" + "";
            int jumlah_tamu = Convert.ToInt32(Login.db.executeScalar(query));
            if(jumlah_tamu > 0)
            {
                query = "Select ROW_ID_TAMU as count from TAMU where NAMA_TAMU=" + $"'{nama}' AND NOMOR_TELEPON=" + $"'{telp}' AND EMAIL=" + $"'{email}'" + "";
                int id_tamu = Convert.ToInt32(Login.db.executeScalar(query));
                return id_tamu;
            }
            else
            {
                //insert into tamu
                query = "Insert into TAMU(ROW_ID_TAMU,NAMA_TAMU,NOMOR_TELEPON,EMAIL) VALUES(" +
                 $"'{1}'," +
                $"'{nama}'," +
                $"'{telp}'," +
                $"'{email}'" + ")";
                Login.db.executeNonQuery(query);
                query = "Select ROW_ID_TAMU as count from TAMU where NAMA_TAMU=" + $"'{nama}' AND NOMOR_TELEPON=" + $"'{telp}' AND EMAIL=" + $"'{email}'" + "";
                int id_tamu = Convert.ToInt32(Login.db.executeScalar(query));
                return id_tamu;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isiDataTamu();
        }

        private void compareDates()
        {
            /* DateTime.Compare(d1,d2)
                < 0 − If date1 is earlier than date2
                = 0 − If date1 is the same as date2
                > 0 − If date1 is later than date2
             */

            DateTime dcin = Convert.ToDateTime(dateCIN.Value);
            DateTime dcout = Convert.ToDateTime(dateCOUT.Value);

            int result = DateTime.Compare(dcin, dcout);
            if (result > 0)
            {
                tanggalValid = false;
            }
            else
            {
                tanggalValid = true;
            }
        }

        private void dateCIN_ValueChanged(object sender, EventArgs e)
        {
                        
        }

        private void dateCOUT_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
