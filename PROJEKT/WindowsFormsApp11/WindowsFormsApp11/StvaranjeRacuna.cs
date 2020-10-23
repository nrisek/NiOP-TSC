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
    public partial class StvaranjeRacuna : Form
    {
        public StvaranjeRacuna()
        {
            InitializeComponent();
        }
        private void btnStvoriRacun_Click(object sender, EventArgs e)
        {
            string nazivRacuna = tbNazivRacuna.Text.ToString();
            int idKorisnika = Int32.Parse(tbIDKorisnika.Text.ToString());
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string naredba = "";
                naredba = "insert into Racuni (Naziv, id_korisnika, placeno) values('" + nazivRacuna + "'," + idKorisnika + ",0);";
                adapter.InsertCommand = new SqlCommand(naredba, db.cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Uspješno uneseno:\nNaziv: " + nazivRacuna + "\n" + "KorisnikID: " + idKorisnika);
                this.Close();
                db.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska! " + ex);
            }
        }
    }
}
