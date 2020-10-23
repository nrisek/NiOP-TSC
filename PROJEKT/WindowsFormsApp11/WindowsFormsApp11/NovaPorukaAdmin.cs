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
    public partial class NovaPorukaAdmin : Form
    {
        public NovaPorukaAdmin()
        {
            InitializeComponent();
        }

        private void btnSalji_Click(object sender, EventArgs e)
        {
            try
            {
                int idKorisnika = Int32.Parse(tbID.Text.ToString());
                string txt = tbTekst.Text.ToString();
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string naredba = "";
                naredba = "insert into Inboks (ID_uloge, ID_osobe, tekst) values (2, " + idKorisnika + ", '" + txt + "');";
                adapter.InsertCommand = new SqlCommand(naredba, db.cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Uspješno poslano:\nID: " + idKorisnika + "\n" + "Sadržaj: "+ txt+"");
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
