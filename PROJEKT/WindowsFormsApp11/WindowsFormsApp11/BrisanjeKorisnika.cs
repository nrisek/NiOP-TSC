using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class BrisanjeKorisnika : Form
    {
        public BrisanjeKorisnika()
        {
            InitializeComponent();
        }
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            int idZaBrisati = Int32.Parse(tbID.Text.ToString());
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "";
                sql = "delete from Korisnicki_podaci where ID=" + idZaBrisati + ";";
                adapter.DeleteCommand = new SqlCommand(sql, db.cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Uspješno obrisano, ID = " + idZaBrisati);
                db.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska! " + ex);
            }
        }
    }
}
