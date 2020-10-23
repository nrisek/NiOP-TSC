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
    public partial class Admin : Form
    {
        public Admin(string id)
        {
            InitializeComponent();
            prijavljeniID = Int32.Parse(id);
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlCommand naredba;
                SqlDataReader dataReader;
                string sql, output = "";
                sql = "select ime, prezime from Korisnicki_podaci where ID="+prijavljeniID+"";
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

        int prijavljeniID = 0;
       
        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosKorisnika UnosKorisnikaForm = new UnosKorisnika();
            UnosKorisnikaForm.ShowDialog();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledKorisnika pregled = new PregledKorisnika();
            pregled.ShowDialog();
        }

        private void brisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrisanjeKorisnika BrisanjeKorisnikaForm = new BrisanjeKorisnika();
            BrisanjeKorisnikaForm.ShowDialog();
        }

        private void stvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StvaranjeRacuna stvrac = new StvaranjeRacuna();
            stvrac.ShowDialog();
        }

        private void btnNatragNaPrijavu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void pregledRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPregledRacuna pregrac = new AdminPregledRacuna();
            pregrac.ShowDialog();
        }

        private void označiSPlaćenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdredivanjePlacenog placeno = new OdredivanjePlacenog();
            placeno.ShowDialog();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Konfiguracije konf = new Konfiguracije();
            konf.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        private void inboksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InboksAdmin ia = new InboksAdmin();
            ia.ShowDialog();
        }

        private void novaPorukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaPorukaAdmin npa = new NovaPorukaAdmin();
            npa.ShowDialog();
        }
    }
}
