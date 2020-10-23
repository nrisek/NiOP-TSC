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
    public partial class Korisnik : Form
    {
        public Korisnik(string id)
        {
            InitializeComponent();
            idPrijavljenog = Int32.Parse(id);
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlCommand naredba;
                SqlDataReader dataReader;
                string sql, output = "";
                sql = "select ime, prezime from Korisnicki_podaci where ID=" + idPrijavljenog + "";
                naredba = new SqlCommand(sql, db.cnn);
                dataReader = naredba.ExecuteReader();
                while (dataReader.Read())
                {
                    output += "Prijavljeni ste kao: " + dataReader.GetValue(0) + " " + dataReader.GetValue(1);
                }
                tbPrijavljeni.Text = output;
                naredba.Dispose();
                db.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska! " + ex);
            }
        }
        public int idPrijavljenog = 0;
        private void plaćenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlCommand naredba;
                SqlDataReader dataReader;
                string sql = "";
                sql = "select * from Racuni where id_korisnika="+idPrijavljenog+" AND placeno=1;"; 
                naredba = new SqlCommand(sql, db.cnn);
                dataReader = naredba.ExecuteReader();
                while (dataReader.Read())
                {
                    lbPlaceno.Items.Add(dataReader.GetValue(1) + "\r \n");
                }
                naredba.Dispose();
                db.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska! " + ex);
            }
        }

        private void zaPlatitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlCommand naredba;
                SqlDataReader dataReader;
                string sql = "";
                sql = "select * from Racuni where id_korisnika=" + idPrijavljenog + " AND placeno=0;";
                naredba = new SqlCommand(sql, db.cnn);
                dataReader = naredba.ExecuteReader();
                while (dataReader.Read())
                {
                    lbRacuni.Items.Add(dataReader.GetValue(1) + "\r \n");
                }
                naredba.Dispose();
                db.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska! " + ex);
            }
        }

        private void btnNatragNaPrijavu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Korisnik_Load(object sender, EventArgs e)
        {

        }
        private void inboksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inboks inb = new Inboks(idPrijavljenog);
            inb.ShowDialog();
        }

        private void novaPorukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaPoruka np = new NovaPoruka(idPrijavljenog);
            np.ShowDialog();
        }
    }
}
