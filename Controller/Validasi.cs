using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan11_Hilwa.Controller
{
    internal class Validasi
    {
        public bool valName(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[0] == ' ' || name[name.Length - 1] == ' ' || name[a] == ':' ||
                    name[a] == ',' | name[0] == '-' || name[name.Length - 1] == '-' || name[a] == '/' || name[a] == '\\' ||
                    name[a] == '?')
                {
                    MessageBox.Show("Input Name field", "Add Peserta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valLokasi(string lokasi)
        {
            for (int a = 0; a < lokasi.Length; a++)
            {
                if ((lokasi[0] >= '0' && lokasi[0] <= '9') || lokasi[0] == ' ' || lokasi[lokasi.Length - 1] == ' ' || lokasi[a] == ':' ||
                    lokasi[a] == ',' | lokasi[0] == '-' || lokasi[lokasi.Length - 1] == '-' || lokasi[a] == '/' || lokasi[a] == '\\' ||
                    lokasi[a] == '?' || lokasi[0]== '*')
                {
                    MessageBox.Show("Input Lokasi field", "Add Pelatihan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
