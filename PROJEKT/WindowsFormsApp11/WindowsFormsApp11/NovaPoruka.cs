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
    public partial class NovaPoruka : Form
    {
        public NovaPoruka(int id)
        {
            InitializeComponent();
            idPrijavljenog = id;
        }
        public int idPrijavljenog = 0;
        private void btnSalji_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = tbTekst.Text.ToString();
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string naredba = "";
                naredba = "insert into Inboks (ID_uloge, ID_osobe, tekst) values (1, " + idPrijavljenog + ", '" + txt + "');";
                adapter.InsertCommand = new SqlCommand(naredba, db.cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Uspješno poslano:\nSadržaj: " + txt + "\n" + "Admin će Vam odgovoriti u najkraćem roku");
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
