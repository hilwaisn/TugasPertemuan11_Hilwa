using MySqlConnector;
using TugasPertemuan11_Hilwa.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace TugasPertemuan11_Hilwa.View
{
    public partial class Form6Pes : Form
    {
        private PesertaController pescontroller;

        public Form6Pes()
        {
            pescontroller = new PesertaController();
            Validasi validasi = new Validasi();

            InitializeComponent();
            showTable();
        }
        bool verify()
        {
            if ((txtDelIdPes.Text == "") || (txtDelNMPes.Text == "") || (txtDelEmPes.Text == "") || (txtDelNTPes.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void showTable()
        {
            dataGridViewPes.DataSource = pescontroller.tampilPeserta();
            dataGridViewPes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3AddPlth frAddPlth = new Form3AddPlth();
            frAddPlth.Show();
            this.Hide();
        }

        private void btnAddPes_Click(object sender, EventArgs e)
        {
            Form7AddPes frPes = new Form7AddPes();
            frPes.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PelatihanPemrograman cl = new PelatihanPemrograman();
            cl.Show();
            this.Hide();
        }

        private void btnUpdatePes_Click(object sender, EventArgs e)
        {
            Form8UpPes cl = new Form8UpPes();
            cl.Show();
            this.Hide();
            cl.txtID.Text = this.dataGridViewPes.CurrentRow.Cells[0].Value.ToString();
            cl.txtNP.Text = this.dataGridViewPes.CurrentRow.Cells[1].Value.ToString();
            cl.txtEmail.Text = this.dataGridViewPes.CurrentRow.Cells[2].Value.ToString();
            cl.txtNT.Text = this.dataGridViewPes.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDeletePes_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    pescontroller.deletePeserta(txtDelIdPes.Text);
                    showTable();
                    btnClear.PerformClick();
                    MessageBox.Show("Peserta Deleted succesfully", "Delete Peserta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDelIdPes.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Peserta not delete", "Delete Peserta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewPes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDelIdPes.Text = dataGridViewPes.CurrentRow.Cells[0].Value.ToString();
            txtDelNMPes.Text = dataGridViewPes.CurrentRow.Cells[1].Value.ToString();
            txtDelEmPes.Text = dataGridViewPes.CurrentRow.Cells[2].Value.ToString();
            txtDelNTPes.Text = dataGridViewPes.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDelIdPes.Clear();
            txtDelNMPes.Clear();
            txtDelEmPes.Clear();
            txtDelNTPes.Clear();
        }

        private void Form6Pes_Load(object sender, EventArgs e)
        {
            showTable();
        }
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridViewPes.Width, this.dataGridViewPes.Height);
            dataGridViewPes.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridViewPes.Width, this.dataGridViewPes.Height));
            e.Graphics.DrawImage(btm, 100, 120);
            e.Graphics.DrawString(lblJudul.Text, new Font("Consolas", 23, FontStyle.Bold), Brushes.Black, new Point(310, 150));
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPes.DataSource = pescontroller.searchPeserta(textBox1.Text);
            dataGridViewPes.RowTemplate.Height = 80;
        }
    }
}