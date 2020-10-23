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
    public partial class AdminPregledRacuna : Form
    {
        public AdminPregledRacuna()
        {
            InitializeComponent();
        }
        private void AdminPregledRacuna_Load(object sender, EventArgs e)
        {
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlCommand naredba;
                SqlDataReader dataReader;
                string sql = "";
                sql = "select * from Racuni where placeno=0;";
                naredba = new SqlCommand(sql, db.cnn);
                dataReader = naredba.ExecuteReader();
                while (dataReader.Read())
                {
                    lbPregledRacuna.Items.Add("ID racuna: " + dataReader.GetValue(0) + "\r \n");
                    lbPregledRacuna.Items.Add("Naziv: " + dataReader.GetValue(1) + "\r \n");
                    lbPregledRacuna.Items.Add("ID korisnika: " + dataReader.GetValue(2) + "\r \n");
                    lbPregledRacuna.Items.Add("\r \n");
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
