﻿namespace PROBIS_SqueeCapsule
{
    partial class PeminjamanFasilitasInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeminjamanFasilitasInput));
            this.lbl_ = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.btnKumpul = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvFasilitas = new System.Windows.Forms.DataGridView();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFasilitas)).BeginInit();
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
            this.lblH1.Location = new System.Drawing.Point(12, 74);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(772, 2);
            this.lblH1.TabIndex = 15;
            // 
            // btnKumpul
            // 
            this.btnKumpul.BackColor = System.Drawing.Color.Green;
            this.btnKumpul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKumpul.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKumpul.ForeColor = System.Drawing.Color.White;
            this.btnKumpul.Location = new System.Drawing.Point(588, 505);
            this.btnKumpul.Name = "btnKumpul";
            this.btnKumpul.Size = new System.Drawing.Size(200, 50);
            this.btnKumpul.TabIndex = 22;
            this.btnKumpul.Text = "Kumpul";
            this.btnKumpul.UseVisualStyleBackColor = false;
            this.btnKumpul.Click += new System.EventHandler(this.btnKumpul_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(12, 505);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 50);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvFasilitas
            // 
            this.dgvFasilitas.AllowUserToAddRows = false;
            this.dgvFasilitas.AllowUserToDeleteRows = false;
            this.dgvFasilitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFasilitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFasilitas.Location = new System.Drawing.Point(12, 91);
            this.dgvFasilitas.Name = "dgvFasilitas";
            this.dgvFasilitas.RowHeadersWidth = 51;
            this.dgvFasilitas.RowTemplate.Height = 24;
            this.dgvFasilitas.Size = new System.Drawing.Size(772, 393);
            this.dgvFasilitas.TabIndex = 0;
            this.dgvFasilitas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFasilitas_CellEndEdit);
            this.dgvFasilitas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvFasilitas_EditingControlShowing);
            // 
            // lblSTotal
            // 
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSTotal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSTotal.Location = new System.Drawing.Point(12, 44);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(59, 20);
            this.lblSTotal.TabIndex = 25;
            this.lblSTotal.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(97, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(116, 20);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Rp. 100.000";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(7, 9);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(84, 25);
            this.lblJudul.TabIndex = 41;
            this.lblJudul.Text = "Kamar";
            // 
            // PeminjamanFasilitasInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblSTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvFasilitas);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKumpul);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.lblX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PeminjamanFasilitasInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeminjamanFasilitasInput_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFasilitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Button btnKumpul;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvFasilitas;
        private System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblJudul;
    }
}