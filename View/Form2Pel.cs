using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11_Hilwa.Controller;

namespace TugasPertemuan11_Hilwa
{
    public partial class Form2Pel : Form
    {
        private PelatihanController pltcontroller;
        public Form2Pel()
        {
            pltcontroller = new PelatihanController();
            Validasi validasi = new Validasi();
            InitializeComponent();
            showTable();
        }
        bool verify()
        {
            if ((txtDelPelId.Text == "") || (txtDelPelNP.Text == "") || (txtDelPelDes.Text == "") || (txtDelPelTM.Text == "") || (txtDelPelTS.Text == "") || (txtDelPelIns.Text == "") || (txtDelPelLok.Text == "") || (txtDelPelHarga.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAddPlth_Click(object sender, EventArgs e)
        {
            Form3AddPlth frAddPlth = new Form3AddPlth();
            frAddPlth.Show();
            this.Hide();
        }

        private void btnCancelPlth_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Contiue or not", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.No)
                Application.Exit();
            Form2Pel cl = new Form2Pel();
            cl.Show();
            this.Hide();
        }
        private void Form2Pel_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            dataGridViewPlt.DataSource = pltcontroller.tampilPelatihan();
            dataGridViewPlt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PelatihanPemrograman clp = new PelatihanPemrograman();
            clp.Show();
            this.Hide();
        }

        private void btnUpdatePlth_Click(object sender, EventArgs e)
        {
            Form4UpPlh frAddPlth = new Form4UpPlh();
            frAddPlth.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewPlt.Width, this.dataGridViewPlt.Height);
            dataGridViewPlt.DrawToBitmap(btm, new Rectangle(0,0, this.dataGridViewPlt.Width, this.dataGridViewPlt.Height));
            e.Graphics.DrawImage(btm, 100, 120);
            e.Graphics.DrawString(lbl1.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(310, 150));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPlt.DataSource = pltcontroller.searchPelatihan(textBox1.Text);
            dataGridViewPlt.RowTemplate.Height = 80;
        }

        private void btnDeletePlth_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    pltcontroller.hapusPelatihan(txtDelPelId.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Pelatihan Deleted succesfully", "Delete Pelatihan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDelPelId.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Pelatihan not delete", "Delete Pelatihan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDelPelId.Clear();
            txtDelPelNP.Clear();
            txtDelPelDes.Clear();
            txtDelPelTM.Clear();
            txtDelPelTS.Clear();
            txtDelPelIns.Clear();
            txtDelPelLok.Clear();
            txtDelPelHarga.Clear();
        }

        private void dataGridViewPlt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDelPelId.Text = dataGridViewPlt.CurrentRow.Cells[0].Value.ToString();
            txtDelPelNP.Text = dataGridViewPlt.CurrentRow.Cells[1].Value.ToString();
            txtDelPelDes.Text = dataGridViewPlt.CurrentRow.Cells[2].Value.ToString();
            txtDelPelTM.Text = dataGridViewPlt.CurrentRow.Cells[3].Value.ToString();
            txtDelPelTS.Text = dataGridViewPlt.CurrentRow.Cells[4].Value.ToString();
            txtDelPelIns.Text = dataGridViewPlt.CurrentRow.Cells[5].Value.ToString();
            txtDelPelLok.Text = dataGridViewPlt.CurrentRow.Cells[6].Value.ToString();
            txtDelPelHarga.Text= dataGridViewPlt.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
