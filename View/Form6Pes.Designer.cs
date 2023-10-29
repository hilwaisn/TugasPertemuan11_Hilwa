namespace TugasPertemuan11_Hilwa.View
{
    partial class Form6Pes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6Pes));
            this.dataGridViewPes = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeletePes = new System.Windows.Forms.Button();
            this.btnUpdatePes = new System.Windows.Forms.Button();
            this.btnAddPes = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPes
            // 
            this.dataGridViewPes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPes.Location = new System.Drawing.Point(60, 141);
            this.dataGridViewPes.Name = "dataGridViewPes";
            this.dataGridViewPes.RowHeadersWidth = 62;
            this.dataGridViewPes.RowTemplate.Height = 28;
            this.dataGridViewPes.Size = new System.Drawing.Size(791, 309);
            this.dataGridViewPes.TabIndex = 17;
            this.dataGridViewPes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPes_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(720, 561);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 49);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeletePes
            // 
            this.btnDeletePes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeletePes.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePes.Location = new System.Drawing.Point(283, 474);
            this.btnDeletePes.Name = "btnDeletePes";
            this.btnDeletePes.Size = new System.Drawing.Size(165, 60);
            this.btnDeletePes.TabIndex = 15;
            this.btnDeletePes.Text = "DELETE";
            this.btnDeletePes.UseVisualStyleBackColor = false;
            this.btnDeletePes.Click += new System.EventHandler(this.btnDeletePes_Click);
            // 
            // btnUpdatePes
            // 
            this.btnUpdatePes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdatePes.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePes.Location = new System.Drawing.Point(530, 474);
            this.btnUpdatePes.Name = "btnUpdatePes";
            this.btnUpdatePes.Size = new System.Drawing.Size(188, 60);
            this.btnUpdatePes.TabIndex = 14;
            this.btnUpdatePes.Text = "UPDATE";
            this.btnUpdatePes.UseVisualStyleBackColor = false;
            this.btnUpdatePes.Click += new System.EventHandler(this.btnUpdatePes_Click);
            // 
            // btnAddPes
            // 
            this.btnAddPes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddPes.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPes.Location = new System.Drawing.Point(68, 474);
            this.btnAddPes.Name = "btnAddPes";
            this.btnAddPes.Size = new System.Drawing.Size(130, 60);
            this.btnAddPes.TabIndex = 13;
            this.btnAddPes.Text = "ADD";
            this.btnAddPes.UseVisualStyleBackColor = false;
            this.btnAddPes.Click += new System.EventHandler(this.btnAddPes_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJudul.Location = new System.Drawing.Point(369, 58);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(233, 52);
            this.lblJudul.TabIndex = 12;
            this.lblJudul.Text = "PESERTA";
            // 
            // Form6Pes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPertemuan11_Hilwa.Properties.Resources.Uses___What_I_use_on_a_daily_basis__;
            this.ClientSize = new System.Drawing.Size(944, 668);
            this.Controls.Add(this.dataGridViewPes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeletePes);
            this.Controls.Add(this.btnUpdatePes);
            this.Controls.Add(this.btnAddPes);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6Pes";
            this.Text = "Peserta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeletePes;
        private System.Windows.Forms.Button btnUpdatePes;
        private System.Windows.Forms.Button btnAddPes;
        private System.Windows.Forms.Label lblJudul;
    }
}