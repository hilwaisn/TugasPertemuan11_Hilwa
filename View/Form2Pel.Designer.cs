namespace TugasPertemuan11_Hilwa
{
    partial class Form2Pel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Pel));
            this.lblJudul = new System.Windows.Forms.Label();
            this.btnAddPlth = new System.Windows.Forms.Button();
            this.btnUpdatePlth = new System.Windows.Forms.Button();
            this.btnDeletePlth = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewPlt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.Color.Gray;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJudul.Location = new System.Drawing.Point(325, 54);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(274, 52);
            this.lblJudul.TabIndex = 6;
            this.lblJudul.Text = "PELATIHAN";
            // 
            // btnAddPlth
            // 
            this.btnAddPlth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddPlth.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlth.Location = new System.Drawing.Point(75, 470);
            this.btnAddPlth.Name = "btnAddPlth";
            this.btnAddPlth.Size = new System.Drawing.Size(130, 60);
            this.btnAddPlth.TabIndex = 7;
            this.btnAddPlth.Text = "ADD";
            this.btnAddPlth.UseVisualStyleBackColor = false;
            this.btnAddPlth.Click += new System.EventHandler(this.btnAddPlth_Click);
            // 
            // btnUpdatePlth
            // 
            this.btnUpdatePlth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdatePlth.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlth.Location = new System.Drawing.Point(537, 470);
            this.btnUpdatePlth.Name = "btnUpdatePlth";
            this.btnUpdatePlth.Size = new System.Drawing.Size(188, 60);
            this.btnUpdatePlth.TabIndex = 8;
            this.btnUpdatePlth.Text = "UPDATE";
            this.btnUpdatePlth.UseVisualStyleBackColor = false;
            this.btnUpdatePlth.Click += new System.EventHandler(this.btnUpdatePlth_Click);
            // 
            // btnDeletePlth
            // 
            this.btnDeletePlth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeletePlth.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlth.Location = new System.Drawing.Point(290, 470);
            this.btnDeletePlth.Name = "btnDeletePlth";
            this.btnDeletePlth.Size = new System.Drawing.Size(165, 60);
            this.btnDeletePlth.TabIndex = 9;
            this.btnDeletePlth.Text = "DELETE";
            this.btnDeletePlth.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(727, 557);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 49);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridViewPlt
            // 
            this.dataGridViewPlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlt.Location = new System.Drawing.Point(67, 137);
            this.dataGridViewPlt.Name = "dataGridViewPlt";
            this.dataGridViewPlt.RowHeadersWidth = 62;
            this.dataGridViewPlt.RowTemplate.Height = 28;
            this.dataGridViewPlt.Size = new System.Drawing.Size(791, 309);
            this.dataGridViewPlt.TabIndex = 11;
            // 
            // Form2Pel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPertemuan11_Hilwa.Properties.Resources.f4f74b53_9f89_4c18_8572_05ca589ff6b6;
            this.ClientSize = new System.Drawing.Size(944, 668);
            this.Controls.Add(this.dataGridViewPlt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeletePlth);
            this.Controls.Add(this.btnUpdatePlth);
            this.Controls.Add(this.btnAddPlth);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2Pel";
            this.Text = "Pelatihan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridViewPlt;
        public System.Windows.Forms.Button btnAddPlth;
        public System.Windows.Forms.Button btnUpdatePlth;
        public System.Windows.Forms.Button btnDeletePlth;
    }
}