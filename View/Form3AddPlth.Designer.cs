namespace TugasPertemuan11_Hilwa
{
    partial class Form3AddPlth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3AddPlth));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNP = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblTM = new System.Windows.Forms.Label();
            this.lblTS = new System.Windows.Forms.Label();
            this.lblIns = new System.Windows.Forms.Label();
            this.lblLok = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtIns = new System.Windows.Forms.TextBox();
            this.txtLok = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(86, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 49);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(672, 556);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 49);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(474, 133);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(299, 34);
            this.txtID.TabIndex = 2;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Gray;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJudul.Location = new System.Drawing.Point(338, 43);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(274, 52);
            this.lblJudul.TabIndex = 5;
            this.lblJudul.Text = "PELATIHAN";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(135, 133);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(203, 33);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id                      :";
            // 
            // lblNP
            // 
            this.lblNP.AutoSize = true;
            this.lblNP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNP.Location = new System.Drawing.Point(135, 183);
            this.lblNP.Name = "lblNP";
            this.lblNP.Size = new System.Drawing.Size(205, 33);
            this.lblNP.TabIndex = 7;
            this.lblNP.Text = "Nama Pelatihan  :";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(135, 242);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(205, 33);
            this.lblDes.TabIndex = 8;
            this.lblDes.Text = "Deskripsi           :";
            // 
            // lblTM
            // 
            this.lblTM.AutoSize = true;
            this.lblTM.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTM.Location = new System.Drawing.Point(135, 295);
            this.lblTM.Name = "lblTM";
            this.lblTM.Size = new System.Drawing.Size(209, 33);
            this.lblTM.TabIndex = 9;
            this.lblTM.Text = "Tanggal Mulai     :";
            // 
            // lblTS
            // 
            this.lblTS.AutoSize = true;
            this.lblTS.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTS.Location = new System.Drawing.Point(135, 344);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(210, 33);
            this.lblTS.TabIndex = 10;
            this.lblTS.Text = "Tanggal Selesai  :";
            // 
            // lblIns
            // 
            this.lblIns.AutoSize = true;
            this.lblIns.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIns.Location = new System.Drawing.Point(135, 389);
            this.lblIns.Name = "lblIns";
            this.lblIns.Size = new System.Drawing.Size(210, 33);
            this.lblIns.TabIndex = 11;
            this.lblIns.Text = "Instruktur          :";
            // 
            // lblLok
            // 
            this.lblLok.AutoSize = true;
            this.lblLok.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLok.Location = new System.Drawing.Point(135, 437);
            this.lblLok.Name = "lblLok";
            this.lblLok.Size = new System.Drawing.Size(212, 33);
            this.lblLok.TabIndex = 12;
            this.lblLok.Text = "Lokasi                 :";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(135, 487);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(214, 33);
            this.lblHarga.TabIndex = 13;
            this.lblHarga.Text = "Harga                  :";
            // 
            // txtNP
            // 
            this.txtNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNP.Location = new System.Drawing.Point(474, 183);
            this.txtNP.Multiline = true;
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(299, 34);
            this.txtNP.TabIndex = 14;
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(474, 242);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(299, 34);
            this.txtDes.TabIndex = 15;
            this.txtDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDes_KeyPress);
            // 
            // txtIns
            // 
            this.txtIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIns.Location = new System.Drawing.Point(474, 389);
            this.txtIns.Multiline = true;
            this.txtIns.Name = "txtIns";
            this.txtIns.Size = new System.Drawing.Size(299, 34);
            this.txtIns.TabIndex = 18;
            this.txtIns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIns_KeyPress);
            // 
            // txtLok
            // 
            this.txtLok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLok.Location = new System.Drawing.Point(474, 437);
            this.txtLok.Multiline = true;
            this.txtLok.Name = "txtLok";
            this.txtLok.Size = new System.Drawing.Size(299, 34);
            this.txtLok.TabIndex = 19;
            this.txtLok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLok_KeyPress);
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(474, 487);
            this.txtHarga.Multiline = true;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(299, 34);
            this.txtHarga.TabIndex = 20;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(474, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " ";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(474, 344);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // Form3AddPlth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPertemuan11_Hilwa.Properties.Resources.f4f74b53_9f89_4c18_8572_05ca589ff6b6;
            this.ClientSize = new System.Drawing.Size(944, 668);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtLok);
            this.Controls.Add(this.txtIns);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNP);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblLok);
            this.Controls.Add(this.lblIns);
            this.Controls.Add(this.lblTS);
            this.Controls.Add(this.lblTM);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblNP);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3AddPlth";
            this.Text = "Add Pelatihan";
            this.Load += new System.EventHandler(this.Form3AddPlth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJudul;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblNP;
        public System.Windows.Forms.Label lblDes;
        public System.Windows.Forms.Label lblTM;
        public System.Windows.Forms.Label lblTS;
        public System.Windows.Forms.Label lblIns;
        public System.Windows.Forms.Label lblLok;
        public System.Windows.Forms.Label lblHarga;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtNP;
        public System.Windows.Forms.TextBox txtDes;
        public System.Windows.Forms.TextBox txtIns;
        public System.Windows.Forms.TextBox txtLok;
        public System.Windows.Forms.TextBox txtHarga;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}