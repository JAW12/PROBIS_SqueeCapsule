﻿using System;
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
    public partial class BookingCheckIn : Form
    {
        List<String> kamarSingle = new List<string>();
        List<String> kamarFamily = new List<string>();
        List<String> namaKamarSingle = new List<string>();
        List<String> namaKamarFamily = new List<string>();
        int single = 0, family = 0, totalSingle = 0, totalFamily = 0;

        public BookingCheckIn()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            this.Hide();
        }

        private void lbl__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dgvKamar.Rows[e.RowIndex].Cells[3].Value == null || dgvKamar.Rows[e.RowIndex].Cells[3].Value.ToString() == "False")
                {
                    dgvKamar.Rows[e.RowIndex].Cells[3].Value = true;
                    if(dgvKamar.Rows[e.RowIndex].Cells[2].Value.ToString() == "Single")
                    {
                        //kamarSingle.Add(dt.Rows[e.RowIndex]["ROW_ID_KAMAR"].ToString());
                        namaKamarSingle.Add(dgvKamar.Rows[e.RowIndex].Cells[1].Value.ToString());
                        totalSingle -= 1;
                        single -= 1;
                        lblJSingle.Text = totalSingle.ToString();
                        lblTSingle.Text = single.ToString();
                        //MessageBox.Show(kamarSingle[kamarSingle.Count-1]);
                        string temp = "";
                        for (int i = 0; i < namaKamarSingle.Count; i++)
                        {
                            if(i != namaKamarSingle.Count - 1)
                            {
                                temp += namaKamarSingle[i] + ", ";
                            }
                            else
                            {
                                temp += namaKamarSingle[i] + " (" + (namaKamarSingle.Count).ToString() + ")";
                            }
                        }
                        lblPSingle.Text = temp;
                    }
                    else
                    {
                        //kamarFamily.Add(dt.Rows[e.RowIndex]["ROW_ID_KAMAR"].ToString());
                        namaKamarFamily.Add(dgvKamar.Rows[e.RowIndex].Cells[1].Value.ToString());
                        //MessageBox.Show(kamarFamily[kamarFamily.Count - 1]);
                        totalFamily -= 1;
                        family -= 1;
                        lblJFamily.Text = totalFamily.ToString();
                        lblTFamily.Text = family.ToString();
                        string temp = "";
                        for (int i = 0; i < namaKamarFamily.Count; i++)
                        {
                            if (i != namaKamarFamily.Count - 1)
                            {
                                temp += namaKamarFamily[i] + ", ";
                            }
                            else
                            {
                                temp += namaKamarFamily[i] + " (" + (namaKamarFamily.Count).ToString() + ")";
                            }
                        }
                        lblPFamily.Text = temp;
                    }
                }
                else
                {
                    dgvKamar.Rows[e.RowIndex].Cells[3].Value = false;
                    if (dgvKamar.Rows[e.RowIndex].Cells[2].Value.ToString() == "Single")
                    {
                        for (int i = 0; i < namaKamarSingle.Count; i++)
                        {
                            if(namaKamarSingle[i] == dgvKamar.Rows[e.RowIndex].Cells[1].Value.ToString())
                            {
                                namaKamarSingle.RemoveAt(i);
                                break;
                            }
                        }
                        totalSingle += 1;
                        single += 1;
                        lblJSingle.Text = totalSingle.ToString();
                        lblTSingle.Text = single.ToString();
                        //MessageBox.Show(kamarSingle[kamarSingle.Count-1]);
                        string temp = "";
                        for (int i = 0; i < namaKamarSingle.Count; i++)
                        {
                            if (i != namaKamarSingle.Count - 1)
                            {
                                temp += namaKamarSingle[i] + ", ";
                            }
                            else
                            {
                                temp += namaKamarSingle[i] + " (" + (namaKamarSingle.Count).ToString() + ")";
                            }
                        }
                        lblPSingle.Text = temp;
                        if(namaKamarSingle.Count <= 0)
                            lblPSingle.Text = "(" + kamarSingle.Count().ToString() + ")";
                    }
                    else
                    {
                        for (int i = 0; i < namaKamarFamily.Count; i++)
                        {
                            if (namaKamarFamily[i] == dgvKamar.Rows[e.RowIndex].Cells[1].Value.ToString())
                            {
                                namaKamarFamily.RemoveAt(i);
                                break;
                            }
                        }
                        totalFamily += 1;
                        family += 1;
                        lblJFamily.Text = totalFamily.ToString();
                        lblTFamily.Text = family.ToString();
                        //MessageBox.Show(kamarSingle[kamarSingle.Count-1]);
                        string temp = "";
                        for (int i = 0; i < namaKamarFamily.Count; i++)
                        {
                            if (i != namaKamarFamily.Count - 1)
                            {
                                temp += namaKamarFamily[i] + ", ";
                            }
                            else
                            {
                                temp += namaKamarFamily[i] + " (" + (namaKamarFamily.Count).ToString() + ")";
                            }
                        }
                        lblPFamily.Text = temp;
                        if (namaKamarFamily.Count <= 0)
                            lblPFamily.Text = "(" + kamarFamily.Count().ToString() + ")";
                    }
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void dgvKamar_VisibleChanged(object sender, EventArgs e)
        {
            loadData();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BookingCheckIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(tbSearch.Text.Contains("S") || tbSearch.Text.Contains("s"))
                loadData("Select NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR from KAMAR K where STATUS_TERSEDIA = 1" + " AND JENIS_KAMAR = 0");
                else if (tbSearch.Text.Contains("F") || tbSearch.Text.Contains("f"))
                    loadData("Select NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR from KAMAR K where STATUS_TERSEDIA = 1" + " AND JENIS_KAMAR = 1");
                else
                    loadData();
            }
        }

        public void loadData(String query2 = "")
        {
            dgvKamar.Rows.Clear();
            string query = "Select distinct * from H_BOOKING H where ROW_ID_BOOKING=" + $"'{Login.id_booking}'";
            DataTable dt = Login.db.executeDataTable(query);
            single = Convert.ToInt32(dt.Rows[0]["JUMLAH_KAMAR_SINGLE"]);
            family = Convert.ToInt32(dt.Rows[0]["JUMLAH_KAMAR_FAMILY"]);
            totalSingle = 0;
            totalFamily = 0;
            kamarSingle.Clear();
            kamarFamily.Clear();
            namaKamarSingle.Clear();
            namaKamarFamily.Clear();
            if (query2 == "")
                query2 = "Select NOMOR_KAMAR, JENIS_KAMAR, HARGA_KAMAR from KAMAR K where STATUS_TERSEDIA = 1";
            dt = Login.db.executeDataTable(query2);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["JENIS_KAMAR"].ToString() == "0")
                {
                    dgvKamar.Rows.Add(i,dt.Rows[i]["NOMOR_KAMAR"].ToString(), "Single");
                    totalSingle += 1;
                }
                if (dt.Rows[i]["JENIS_KAMAR"].ToString() == "1")
                {
                    dgvKamar.Rows.Add(i,dt.Rows[i]["NOMOR_KAMAR"].ToString(), "Family");
                    totalFamily += 1;
                }
            }
            lblJSingle.Text = totalSingle.ToString();
            lblJFamily.Text = totalFamily.ToString();
            lblTSingle.Text = single.ToString();
            lblTFamily.Text = family.ToString();
            lblPSingle.Text = "(" + kamarSingle.Count().ToString() + ")";
            lblPFamily.Text = "(" + kamarFamily.Count().ToString() + ")";
        }

        public void insert()
        {
            string query = "";
            for (int i = 0; i < namaKamarSingle.Count; i++)
            {
                query = "Select ROW_ID_KAMAR FROM KAMAR WHERE NOMOR_KAMAR ="+namaKamarSingle[i]+"";
                string result = Login.db.executeScalar(query).ToString();
                kamarSingle.Add(result);
            }
            for (int i = 0; i < namaKamarFamily.Count; i++)
            {
                query = "Select ROW_ID_KAMAR FROM KAMAR WHERE NOMOR_KAMAR =" + namaKamarFamily[i] + "";
                string result = Login.db.executeScalar(query).ToString();
                kamarFamily.Add(result);
            }
            for (int i = 0; i < kamarSingle.Count; i++)
            {
                query = $"Insert into D_BOOKING_KAMAR VALUES({Login.id_booking},{kamarSingle[i]})";
                Login.db.executeNonQuery(query);
                query = $"Update KAMAR SET STATUS_TERSEDIA=0 WHERE NOMOR_KAMAR =" + namaKamarSingle[i] + "";
                Login.db.executeNonQuery(query);
            }
            for (int i = 0; i < kamarFamily.Count; i++)
            {
                query = $"Insert into D_BOOKING_KAMAR VALUES({Login.id_booking},{kamarFamily[i]})";
                Login.db.executeNonQuery(query);
                query = $"Update KAMAR SET STATUS_TERSEDIA=0 WHERE NOMOR_KAMAR =" + namaKamarFamily[i] + "";
                Login.db.executeNonQuery(query);
            }
            query = $"Update H_Booking set STATUS_BOOKING=1 where ROW_ID_BOOKING=" + $"'{Login.id_booking}'";
            Login.db.executeNonQuery(query);
            MessageBox.Show("Insert Successful");
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
