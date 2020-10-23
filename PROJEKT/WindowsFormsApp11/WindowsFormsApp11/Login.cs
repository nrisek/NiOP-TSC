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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        public string imePrijavljenog = "";
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = (tbKorisnickoIme.Text).ToString();
            string lozinka = (tbLozinka.Text).ToString();

            SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();

            string naredba = "select * from Korisnicki_podaci where korisnicko_ime='" + korisnickoIme + "' AND lozinka='" + lozinka + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, db.cnn);
            DataTable tablicaPodataka = new DataTable();
            adapter.Fill(tablicaPodataka);
            if (tablicaPodataka.Rows.Count == 1)
            {
                imePrijavljenog = korisnickoIme;
                //if ID_uloge 1 onda admin forma, else korisnik forma   
                string naredba2 = "select ID,ID_uloge from Korisnicki_podaci where korisnicko_ime='" + korisnickoIme + "';";
                SqlDataAdapter adapter2 = new SqlDataAdapter(naredba2, db.cnn);
                DataTable tablicaPodataka2 = new DataTable();
                adapter2.Fill(tablicaPodataka2);
                foreach (DataRow row in tablicaPodataka2.Rows)
                {
                    string uloga = row["ID_uloge"].ToString();
                    string id = row["ID"].ToString();
                    if (uloga == "1")
                    {
                        this.Hide();
                        Admin AdminForm = new Admin(id);
                        AdminForm.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        Korisnik KorisnikForm = new Korisnik(id);
                        KorisnikForm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
            }
            db.cnn.Close();
        }
    }
}
