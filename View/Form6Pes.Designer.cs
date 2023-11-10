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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDelIdPes = new System.Windows.Forms.TextBox();
            this.txtDelNMPes = new System.Windows.Forms.TextBox();
            this.txtDelNTPes = new System.Windows.Forms.TextBox();
            this.txtDelEmPes = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPes
            // 
            this.dataGridViewPes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPes.Location = new System.Drawing.Point(60, 141);
            this.dataGridViewPes.Name = "dataGridViewPes";
            this.dataGridViewPes.RowHeadersWidth = 62;
            this.dataGridViewPes.RowTemplate.Height = 28;
            this.dataGridViewPes.Size = new System.Drawing.Size(824, 309);
            this.dataGridViewPes.TabIndex = 17;
            this.dataGridViewPes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPes_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnDeletePes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeletePes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDeletePes.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePes.Location = new System.Drawing.Point(230, 474);
            this.btnDeletePes.Name = "btnDeletePes";
            this.btnDeletePes.Size = new System.Drawing.Size(165, 60);
            this.btnDeletePes.TabIndex = 15;
            this.btnDeletePes.Text = "DELETE";
            this.btnDeletePes.UseVisualStyleBackColor = false;
            this.btnDeletePes.Click += new System.EventHandler(this.btnDeletePes_Click);
            // 
            // btnUpdatePes
            // 
            this.btnUpdatePes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdatePes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdatePes.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePes.Location = new System.Drawing.Point(428, 474);
            this.btnUpdatePes.Name = "btnUpdatePes";
            this.btnUpdatePes.Size = new System.Drawing.Size(188, 60);
            this.btnUpdatePes.TabIndex = 14;
            this.btnUpdatePes.Text = "UPDATE";
            this.btnUpdatePes.UseVisualStyleBackColor = false;
            this.btnUpdatePes.Click += new System.EventHandler(this.btnUpdatePes_Click);
            // 
            // btnAddPes
            // 
            this.btnAddPes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.lblJudul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJudul.AutoSize = true;
            this.lblJudul.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblJudul.Location = new System.Drawing.Point(357, 58);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(233, 52);
            this.lblJudul.TabIndex = 12;
            this.lblJudul.Text = "PESERTA";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(645, 481);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 53);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDelIdPes
            // 
            this.txtDelIdPes.Location = new System.Drawing.Point(68, 58);
            this.txtDelIdPes.Name = "txtDelIdPes";
            this.txtDelIdPes.Size = new System.Drawing.Size(100, 26);
            this.txtDelIdPes.TabIndex = 19;
            // 
            // txtDelNMPes
            // 
            this.txtDelNMPes.Location = new System.Drawing.Point(68, 99);
            this.txtDelNMPes.Name = "txtDelNMPes";
            this.txtDelNMPes.Size = new System.Drawing.Size(100, 26);
            this.txtDelNMPes.TabIndex = 20;
            // 
            // txtDelNTPes
            // 
            this.txtDelNTPes.Location = new System.Drawing.Point(195, 99);
            this.txtDelNTPes.Name = "txtDelNTPes";
            this.txtDelNTPes.Size = new System.Drawing.Size(100, 26);
            this.txtDelNTPes.TabIndex = 21;
            // 
            // txtDelEmPes
            // 
            this.txtDelEmPes.Location = new System.Drawing.Point(195, 58);
            this.txtDelEmPes.Name = "txtDelEmPes";
            this.txtDelEmPes.Size = new System.Drawing.Size(100, 26);
            this.txtDelEmPes.TabIndex = 22;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(774, 487);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 42);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(803, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(613, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 26);
            this.textBox1.TabIndex = 25;
            // 
            // Form6Pes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPertemuan11_Hilwa.Properties.Resources.Uses___What_I_use_on_a_daily_basis__;
            this.ClientSize = new System.Drawing.Size(944, 668);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtDelEmPes);
            this.Controls.Add(this.txtDelNTPes);
            this.Controls.Add(this.txtDelNMPes);
            this.Controls.Add(this.txtDelIdPes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridViewPes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeletePes);
            this.Controls.Add(this.btnUpdatePes);
            this.Controls.Add(this.btnAddPes);
            this.Controls.Add(this.lblJudul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6Pes";
            this.Text = "Peserta";
            this.Load += new System.EventHandler(this.Form6Pes_Load);
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDelIdPes;
        private System.Windows.Forms.TextBox txtDelNMPes;
        private System.Windows.Forms.TextBox txtDelNTPes;
        private System.Windows.Forms.TextBox txtDelEmPes;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
    }
}