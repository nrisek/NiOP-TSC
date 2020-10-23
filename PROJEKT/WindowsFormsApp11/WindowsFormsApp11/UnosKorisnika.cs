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
    public partial class UnosKorisnika : Form
    {
        public UnosKorisnika()
        {
            InitializeComponent();
        }
        private void btnUnos_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text.ToString();
            string prezime = tbPrezime.Text.ToString();
            string korisnicko_ime = tbKorisnickoIme.Text.ToString();
            string lozinka = tbLozinka.Text.ToString();
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string naredba = "";
                naredba = "insert into Korisnicki_podaci (ime, prezime, korisnicko_ime, lozinka, ID_uloge) values ('" + ime + "', '" + prezime + "', '" + korisnicko_ime + "', '" + lozinka + "', 2);";
                adapter.InsertCommand = new SqlCommand(naredba, db.cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Uspješno uneseno:\nIme: " + ime + "\n" + "Prezime: " + prezime + "\n"
                    + "Korisničko ime: " + korisnicko_ime + "\n" + "Lozinka: " + lozinka);
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
