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
    public partial class Konfiguracije : Form
    {
        public Konfiguracije()
        {
            InitializeComponent();
        }
        private void Konfiguracije_Load(object sender, EventArgs e)
        {
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlCommand naredba;
                SqlDataReader dataReader;
                string sql = "";
                sql = "select * from Konfiguracije";
                naredba = new SqlCommand(sql, db.cnn);
                dataReader = naredba.ExecuteReader();
                while (dataReader.Read())
                {
                    lbKonfiguracije.Items.Add("ID: " + dataReader.GetValue(0) + "\r \n");
                    lbKonfiguracije.Items.Add("ID korisnika: " + dataReader.GetValue(1) + "\r \n");
                    lbKonfiguracije.Items.Add("Korisničko ime: " + dataReader.GetValue(2) + "\r \n");
                    lbKonfiguracije.Items.Add("Lozinka: " + dataReader.GetValue(3) + "\r \n");
                    lbKonfiguracije.Items.Add("Javni IP: " + dataReader.GetValue(4) + "\r \n");
                    lbKonfiguracije.Items.Add("Skup portova: " + dataReader.GetValue(5) + "\r \n");
                    lbKonfiguracije.Items.Add("ID pristupne točke: " + dataReader.GetValue(6) + "\r \n");     
                    lbKonfiguracije.Items.Add("\r \n");
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
