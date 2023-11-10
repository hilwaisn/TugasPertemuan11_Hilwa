namespace TugasPertemuan11_Hilwa
{
    partial class PelatihanPemrograman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PelatihanPemrograman));
            this.btnPelatihan = new System.Windows.Forms.Button();
            this.btnSertifikat = new System.Windows.Forms.Button();
            this.btnRegistrasi = new System.Windows.Forms.Button();
            this.btnPeserta = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPelatihan
            // 
            this.btnPelatihan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPelatihan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPelatihan.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPelatihan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPelatihan.Location = new System.Drawing.Point(41, 172);
            this.btnPelatihan.Name = "btnPelatihan";
            this.btnPelatihan.Size = new System.Drawing.Size(350, 200);
            this.btnPelatihan.TabIndex = 0;
            this.btnPelatihan.Text = "PELATIHAN";
            this.btnPelatihan.UseVisualStyleBackColor = false;
            this.btnPelatihan.Click += new System.EventHandler(this.btnPelatihan_Click);
            // 
            // btnSertifikat
            // 
            this.btnSertifikat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSertifikat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSertifikat.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSertifikat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSertifikat.Location = new System.Drawing.Point(102, 417);
            this.btnSertifikat.Name = "btnSertifikat";
            this.btnSertifikat.Size = new System.Drawing.Size(350, 200);
            this.btnSertifikat.TabIndex = 1;
            this.btnSertifikat.Text = "SERTIFIKAT";
            this.btnSertifikat.UseVisualStyleBackColor = false;
            // 
            // btnRegistrasi
            // 
            this.btnRegistrasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrasi.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnRegistrasi.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrasi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrasi.Location = new System.Drawing.Point(535, 417);
            this.btnRegistrasi.Name = "btnRegistrasi";
            this.btnRegistrasi.Size = new System.Drawing.Size(350, 200);
            this.btnRegistrasi.TabIndex = 2;
            this.btnRegistrasi.Text = "REGISTRASI";
            this.btnRegistrasi.UseVisualStyleBackColor = false;
            // 
            // btnPeserta
            // 
            this.btnPeserta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPeserta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPeserta.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeserta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPeserta.Location = new System.Drawing.Point(480, 172);
            this.btnPeserta.Name = "btnPeserta";
            this.btnPeserta.Size = new System.Drawing.Size(350, 200);
            this.btnPeserta.TabIndex = 3;
            this.btnPeserta.Text = "PESERTA\r\n";
            this.btnPeserta.UseVisualStyleBackColor = false;
            this.btnPeserta.Click += new System.EventHandler(this.btnPeserta_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Gray;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJudul.Location = new System.Drawing.Point(147, 44);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(652, 52);
            this.lblJudul.TabIndex = 4;
            this.lblJudul.Text = "PELATIHAN PEMROGRAMAN";
            // 
            // PelatihanPemrograman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPertemuan11_Hilwa.Properties.Resources._0c508311_d2cb_4c0f_8572_af89e239a2f7;
            this.ClientSize = new System.Drawing.Size(944, 668);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.btnPeserta);
            this.Controls.Add(this.btnRegistrasi);
            this.Controls.Add(this.btnSertifikat);
            this.Controls.Add(this.btnPelatihan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PelatihanPemrograman";
            this.Text = "Pelatihan Pemrograman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPelatihan;
        private System.Windows.Forms.Button btnSertifikat;
        private System.Windows.Forms.Button btnRegistrasi;
        private System.Windows.Forms.Button btnPeserta;
        private System.Windows.Forms.Label lblJudul;
    }
}

