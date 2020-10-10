using System;
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
        Database db;
        Model m;
        public Login()
        {
            InitializeComponent();
            db = new Database();
            //m = new BookingModel(db.getConnection());
            //List<Object[]> obj = m.getAll();
            //MessageBox.Show(obj.Count.ToString());
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
    }
}
