using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan11_Hilwa.Controller
{
    internal class PesertaController : Model.Connection
    {
        public DataTable tampilPeserta()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT FROM * Peserta";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void tambahPeserta(string id, string namaPes, string email, string noTele)
        {
            string addPeserta = "insert into Peserta values(" + "@id, @nama_peserta, @email, @no_telepon)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(addPeserta, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = namaPes;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = noTele;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }

        }

        public void updatePeserta(string id, string namaPes, string email, string noTele)
        {
            string update = "update Peserta set " + "nama_peserta=@nama_peserta, email=@email, no_telepon=@no_telepon " + "where id=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = namaPes;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = noTele;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }

        }

        public void deletePeserta(string id)
        {
            string delete = "delete from Peserta where id=" + id;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal delete" + ex.Message);
            }

        }
    }
}