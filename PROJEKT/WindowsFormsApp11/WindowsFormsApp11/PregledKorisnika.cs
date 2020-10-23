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
    public partial class PregledKorisnika : Form
    {
        public PregledKorisnika()
        {
            InitializeComponent();
        }
        private void PregledKorisnika_Load(object sender, EventArgs e)
        {
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlCommand naredba;
                SqlDataReader dataReader;
                string sql = "";
                sql = "select * from Korisnicki_podaci";
                naredba = new SqlCommand(sql, db.cnn);
                dataReader = naredba.ExecuteReader();
                while (dataReader.Read())
                {
                    lbKorisnici.Items.Add("ID: " + dataReader.GetValue(0) + "\r \n");
                    lbKorisnici.Items.Add("Ime: " + dataReader.GetValue(1) + "\r \n");
                    lbKorisnici.Items.Add("Prezime: " + dataReader.GetValue(2) + "\r \n");
                    lbKorisnici.Items.Add("Korisničko ime: " + dataReader.GetValue(3) + "\r \n");
                    lbKorisnici.Items.Add("Lozinka: " + dataReader.GetValue(4) + "\r \n");
                    lbKorisnici.Items.Add("\r \n");
                }
                naredba.Dispose();
                db.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska! " + ex);
            }
        }
    }
}
