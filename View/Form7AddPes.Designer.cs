namespace TugasPertemuan11_Hilwa.View
{
    partial class Form7AddPes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7AddPes));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNP = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNT = new System.Windows.Forms.Label();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNT = new System.Windows.Forms.TextBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(97, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 49);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(683, 566);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 49);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(485, 169);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(299, 34);
            this.txtID.TabIndex = 25;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 26;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(146, 169);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(203, 33);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "Id                      :";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // lblNP
            // 
            this.lblNP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNP.AutoSize = true;
            this.lblNP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNP.Location = new System.Drawing.Point(146, 219);
            this.lblNP.Name = "lblNP";
            this.lblNP.Size = new System.Drawing.Size(202, 33);
            this.lblNP.TabIndex = 29;
            this.lblNP.Text = "Nama Peserta    :";
            this.lblNP.Click += new System.EventHandler(this.lblNP_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(146, 278);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(207, 33);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email                 : ";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblNT
            // 
            this.lblNT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNT.AutoSize = true;
            this.lblNT.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNT.Location = new System.Drawing.Point(146, 331);
            this.lblNT.Name = "lblNT";
            this.lblNT.Size = new System.Drawing.Size(212, 33);
            this.lblNT.TabIndex = 31;
            this.lblNT.Text = "Nomor Telepon  : ";
            this.lblNT.Click += new System.EventHandler(this.lblNT_Click);
            // 
            // txtNP
            // 
            this.txtNP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNP.Location = new System.Drawing.Point(485, 219);
            this.txtNP.Multiline = true;
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(299, 34);
            this.txtNP.TabIndex = 36;
            this.txtNP.TextChanged += new System.EventHandler(this.txtNP_TextChanged);
            this.txtNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNP_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(485, 278);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(299, 34);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtNT
            // 
            this.txtNT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNT.Location = new System.Drawing.Point(485, 331);
            this.txtNT.Multiline = true;
            this.txtNT.Name = "txtNT";
            this.txtNT.Size = new System.Drawing.Size(299, 34);
            this.txtNT.TabIndex = 38;
            this.txtNT.TextChanged += new System.EventHandler(this.txtNT_TextChanged);
            this.txtNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNT_KeyPress);
            // 
            // lblJudul
            // 
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJudul.Location = new System.Drawing.Point(356, 50);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(233, 52);
            this.lblJudul.TabIndex = 43;
            this.lblJudul.Text = "PESERTA";
            this.lblJudul.Click += new System.EventHandler(this.lblJudul_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(356, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 52);
            this.label2.TabIndex = 44;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form7AddPes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPertemuan11_Hilwa.Properties.Resources.Uses___What_I_use_on_a_daily_basis__;
            this.ClientSize = new System.Drawing.Size(944, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.txtNT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNP);
            this.Controls.Add(this.lblNT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNP);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7AddPes";
            this.Text = "Add Peserta";
            this.Load += new System.EventHandler(this.Form7AddPes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblNP;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Label lblNT;
        public System.Windows.Forms.TextBox txtNP;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNT;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label label2;
    }
}