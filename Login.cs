﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROBIS_SqueeCapsule
{
    public partial class Login : Form
    {
        bool Eye = false;
        public static Database db;


        public static Login login;
        public static Home home;
        public static Booking booking;
        public static BookingCheckIn booking_checkin;
        public static BookingCheckOut booking_checkout;
        public static BookingDetail booking_detail;
        public static BookingDetailKamar booking_detail_kamar;
        public static BookingUbah booking_ubah;
        public static PeminjamanFasilitas peminjaman_fasilitas;
        public static PeminjamanFasilitasInput peminjaman_fasilitas_input;
        public static StokFasilitas stok_fasilitas;

        public Login()
        {
            login = this;
            InitializeComponent();
            db = new Database();

            //KamarModel m = new KamarModel();
            //m.nomor = "301";    
            //m.jenis = "1";
            //m.harga = "300000";
            //m.status = "1";
            //bool berhasil = m.save();
            //if (berhasil)
            //{
            //    MessageBox.Show("berhasil");
            //}
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            if (Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eyehide;
                tbPassword.PasswordChar = '*';
                Eye = !Eye;
            }
            else if (!Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eye;
                tbPassword.PasswordChar = '\0';
                Eye = !Eye;
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbEye_MouseEnter(object sender, EventArgs e)
        {
            if (Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eyehover;
            }
            else if (!Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eyehidehover;
            }
        }

        private void pbEye_MouseLeave(object sender, EventArgs e)
        {
            if (Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eye;
            }
            else if (!Eye)
            {
                pbEye.BackgroundImage = Properties.Resources.eyehide;
            }
        }

        public void reset()
        {
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = tbUsername.Text.ToString();
            String password = tbPassword.Text.ToString();
            if(username == "admin")
            {
                if(password == "admin")
                {
                    if (home != null)
                    {
                        reset();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        reset();
                        home = new Home();
                        home.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Password salah");
                }
            }
            else
            {
                MessageBox.Show("User tidak ada");
            }
            
        }
    }
}
