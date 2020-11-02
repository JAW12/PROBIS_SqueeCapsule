namespace PROBIS_SqueeCapsule
{
    partial class BookingDetailKamar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDetailKamar));
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblSHarga = new System.Windows.Forms.Label();
            this.lblSJenis = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.dgvPeminjaman = new System.Windows.Forms.DataGridView();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSJudul = new System.Windows.Forms.Label();
            this.lblTotalPeminjaman = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHargakamar = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(739, 9);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(25, 25);
            this.lbl_.TabIndex = 2;
            this.lbl_.Text = "_";
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(762, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblH1
            // 
            this.lblH1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblH1.Location = new System.Drawing.Point(18, 94);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(772, 2);
            this.lblH1.TabIndex = 15;
            // 
            // lblSHarga
            // 
            this.lblSHarga.AutoSize = true;
            this.lblSHarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSHarga.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHarga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSHarga.Location = new System.Drawing.Point(443, 54);
            this.lblSHarga.Name = "lblSHarga";
            this.lblSHarga.Size = new System.Drawing.Size(130, 20);
            this.lblSHarga.TabIndex = 16;
            this.lblSHarga.Text = "Harga Kamar:";
            // 
            // lblSJenis
            // 
            this.lblSJenis.AutoSize = true;
            this.lblSJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSJenis.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJenis.Location = new System.Drawing.Point(15, 54);
            this.lblSJenis.Name = "lblSJenis";
            this.lblSJenis.Size = new System.Drawing.Size(122, 20);
            this.lblSJenis.TabIndex = 16;
            this.lblSJenis.Text = "Jenis Kamar:";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(587, 54);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(105, 20);
            this.lblHarga.TabIndex = 16;
            this.lblHarga.Text = "Rp. 50.000";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenis.Location = new System.Drawing.Point(143, 54);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(63, 20);
            this.lblJenis.TabIndex = 16;
            this.lblJenis.Text = "Single";
            // 
            // dgvPeminjaman
            // 
            this.dgvPeminjaman.AllowUserToAddRows = false;
            this.dgvPeminjaman.AllowUserToDeleteRows = false;
            this.dgvPeminjaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeminjaman.Location = new System.Drawing.Point(18, 135);
            this.dgvPeminjaman.Name = "dgvPeminjaman";
            this.dgvPeminjaman.ReadOnly = true;
            this.dgvPeminjaman.RowHeadersWidth = 51;
            this.dgvPeminjaman.RowTemplate.Height = 24;
            this.dgvPeminjaman.Size = new System.Drawing.Size(772, 432);
            this.dgvPeminjaman.TabIndex = 0;
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblSTotal.Location = new System.Drawing.Point(394, 646);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(132, 25);
            this.lblSTotal.TabIndex = 21;
            this.lblSTotal.Text = "Total Biaya:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotal.Location = new System.Drawing.Point(564, 642);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(226, 33);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Rp. 1.000.000.000";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSJudul
            // 
            this.lblSJudul.AutoSize = true;
            this.lblSJudul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSJudul.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSJudul.Location = new System.Drawing.Point(15, 109);
            this.lblSJudul.Name = "lblSJudul";
            this.lblSJudul.Size = new System.Drawing.Size(236, 20);
            this.lblSJudul.TabIndex = 23;
            this.lblSJudul.Text = "List Peminjaman Fasilitas:";
            // 
            // lblTotalPeminjaman
            // 
            this.lblTotalPeminjaman.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPeminjaman.Location = new System.Drawing.Point(564, 573);
            this.lblTotalPeminjaman.Name = "lblTotalPeminjaman";
            this.lblTotalPeminjaman.Size = new System.Drawing.Size(226, 33);
            this.lblTotalPeminjaman.TabIndex = 20;
            this.lblTotalPeminjaman.Text = "Rp. 500.000.000";
            this.lblTotalPeminjaman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(210, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Biaya Peminjaman Fasilitas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(345, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Biaya Kamar:";
            // 
            // lblHargakamar
            // 
            this.lblHargakamar.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargakamar.Location = new System.Drawing.Point(564, 608);
            this.lblHargakamar.Name = "lblHargakamar";
            this.lblHargakamar.Size = new System.Drawing.Size(226, 33);
            this.lblHargakamar.TabIndex = 20;
            this.lblHargakamar.Text = "Rp. 500.000.000";
            this.lblHargakamar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(12, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(91, 25);
            this.lblJudul.TabIndex = 41;
            this.lblJudul.Text = "Kamar ";
            // 
            // BookingDetailKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblSJudul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSTotal);
            this.Controls.Add(this.lblHargakamar);
            this.Controls.Add(this.lblTotalPeminjaman);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvPeminjaman);
            this.Controls.Add(this.lblSJenis);
            this.Controls.Add(this.lblSHarga);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingDetailKamar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingDetailKamar";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookingDetailKamar_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeminjaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblSHarga;
        private System.Windows.Forms.Label lblSJenis;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.DataGridView dgvPeminjaman;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSJudul;
        private System.Windows.Forms.Label lblTotalPeminjaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHargakamar;
        private System.Windows.Forms.Label lblJudul;
    }
}