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
    public partial class Help : Form
    {

        public Help()
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

        public void setHelp(String petunjuk)
        {
            lblJudul.Text = petunjuk;
            if (petunjuk == "Halaman Login")
            {
                pbHelp.BackgroundImage = new Bitmap(PROBIS_SqueeCapsule.Properties.Resources.login);
                lblDeskripsi.Text =
                    "Halaman login bertujuan untuk memastikan orang yang mengakses aplikasi ini\n" +
                    "memang merupakan resepsionis dari hotel kapsul yang bersangkutan.\n\n" +
                    "Maka dari itu, isikan username dan password yang telah diberikan kepada Anda\n" +
                    "untuk mengakses aplikasi ini.";
                lblKiri.Text =
                    "1. Isi username Anda. \n" +
                    "2. Isi password Anda.";
                lblKanan.Text =
                    "3. Melihat / Menyembunyikan tulisan password. \n" +
                    "4. Kumpul untuk mencoba login.";
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void Help_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
