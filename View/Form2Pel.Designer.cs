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
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDelPelId = new System.Windows.Forms.TextBox();
            this.txtDelPelNP = new System.Windows.Forms.TextBox();
            this.txtDelPelDes = new System.Windows.Forms.TextBox();
            this.txtDelPelTM = new System.Windows.Forms.TextBox();
            this.txtDelPelTS = new System.Windows.Forms.TextBox();
            this.txtDelPelIns = new System.Windows.Forms.TextBox();
            this.txtDelPelLok = new System.Windows.Forms.TextBox();
            this.txtDelPelHarga = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnAddPlth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnUpdatePlth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdatePlth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdatePlth.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlth.Location = new System.Drawing.Point(419, 470);
            this.btnUpdatePlth.Name = "btnUpdatePlth";
            this.btnUpdatePlth.Size = new System.Drawing.Size(188, 60);
            this.btnUpdatePlth.TabIndex = 8;
            this.btnUpdatePlth.Text = "UPDATE";
            this.btnUpdatePlth.UseVisualStyleBackColor = false;
            this.btnUpdatePlth.Click += new System.EventHandler(this.btnUpdatePlth_Click);
            // 
            // btnDeletePlth
            // 
            this.btnDeletePlth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeletePlth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeletePlth.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlth.Location = new System.Drawing.Point(230, 470);
            this.btnDeletePlth.Name = "btnDeletePlth";
            this.btnDeletePlth.Size = new System.Drawing.Size(165, 60);
            this.btnDeletePlth.TabIndex = 9;
            this.btnDeletePlth.Text = "DELETE";
            this.btnDeletePlth.UseVisualStyleBackColor = false;
            this.btnDeletePlth.Click += new System.EventHandler(this.btnDeletePlth_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridViewPlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlt.Location = new System.Drawing.Point(67, 137);
            this.dataGridViewPlt.Name = "dataGridViewPlt";
            this.dataGridViewPlt.RowHeadersWidth = 62;
            this.dataGridViewPlt.RowTemplate.Height = 28;
            this.dataGridViewPlt.Size = new System.Drawing.Size(791, 309);
            this.dataGridViewPlt.TabIndex = 11;
            this.dataGridViewPlt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlt_CellContentClick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(775, 478);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 53);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Location = new System.Drawing.Point(47, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 20);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = " ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(636, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 26);
            this.textBox1.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(829, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDelPelId
            // 
            this.txtDelPelId.Location = new System.Drawing.Point(12, 24);
            this.txtDelPelId.Name = "txtDelPelId";
            this.txtDelPelId.Size = new System.Drawing.Size(100, 26);
            this.txtDelPelId.TabIndex = 20;
            // 
            // txtDelPelNP
            // 
            this.txtDelPelNP.Location = new System.Drawing.Point(118, 23);
            this.txtDelPelNP.Name = "txtDelPelNP";
            this.txtDelPelNP.Size = new System.Drawing.Size(100, 26);
            this.txtDelPelNP.TabIndex = 21;
            // 
            // txtDelPelDes
            // 
            this.txtDelPelDes.Location = new System.Drawing.Point(12, 53);
            this.txtDelPelDes.Name = "txtDelPelDes";
            this.txtDelPelDes.Size = new System.Drawing.Size(100, 26);
            this.txtDelPelDes.TabIndex = 22;
            // 
            // txtDelPelTM
            // 
            this.txtDelPelTM.Location = new System.Drawing.Point(118, 53);
            this.txtDelPelTM.Name = "txtDelPelTM";
            this.txtDelPelTM.Size = new System.Drawing.Size(100, 26);
            this.txtDelPelTM.TabIndex = 23;
            // 
            // txtDelPelTS
            // 
            this.txtDelPelTS.Location = new System.Drawing.Point(12, 82);
            this.txtDelPelTS.Name = "txtDelPelTS";
            this.txtDelPelTS.Size = new System.Drawing.Size(100, 26);
            this.txtDelPelTS.TabIndex = 24;
            // 
            // txtDelPelIns
            // 
            this.txtDelPelIns.Location = new System.Drawing.Point(118, 82);
            this.txtDelPelIns.Name = "txtDelPelIns";
            this.txtDelPelIns.Size = new System.Drawing.Size(100, 26);
            this.txtDelPelIns.TabIndex = 25;
            // 
            // txtDelPelLok
            // 
            this.txtDelPelLok.Location = new System.Drawing.Point(12, 110);
            this.txtDelPelLok.Name = "txtDelPelLok";
            this.txtDelPelLok.Size = new System.Drawing.Size(100, 26);
            this.txtDelPelLok.TabIndex = 26;
            // 
            // txtDelPelHarga
            // 
            this.txtDelPelHarga.Location = new System.Drawing.Point(118, 110);
            this.txtDelPelHarga.Name = "txtDelPelHarga";
            this.txtDelPelHarga.Size = new System.Drawing.Size(100, 26);
            this.txtDelPelHarga.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(636, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 53);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2Pel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::TugasPertemuan11_Hilwa.Properties.Resources.f4f74b53_9f89_4c18_8572_05ca589ff6b6;
            this.ClientSize = new System.Drawing.Size(944, 668);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDelPelHarga);
            this.Controls.Add(this.txtDelPelLok);
            this.Controls.Add(this.txtDelPelIns);
            this.Controls.Add(this.txtDelPelTS);
            this.Controls.Add(this.txtDelPelTM);
            this.Controls.Add(this.txtDelPelDes);
            this.Controls.Add(this.txtDelPelNP);
            this.Controls.Add(this.txtDelPelId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnPrint);
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
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDelPelId;
        private System.Windows.Forms.TextBox txtDelPelNP;
        private System.Windows.Forms.TextBox txtDelPelDes;
        private System.Windows.Forms.TextBox txtDelPelTM;
        private System.Windows.Forms.TextBox txtDelPelTS;
        private System.Windows.Forms.TextBox txtDelPelIns;
        private System.Windows.Forms.TextBox txtDelPelLok;
        private System.Windows.Forms.TextBox txtDelPelHarga;
        private System.Windows.Forms.Button btnClear;
    }
}