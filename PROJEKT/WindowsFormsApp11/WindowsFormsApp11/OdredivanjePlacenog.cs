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
    public partial class OdredivanjePlacenog : Form
    {
        public OdredivanjePlacenog()
        {
            InitializeComponent();
        }
        private void btnPlaceno_Click(object sender, EventArgs e)
        {
            try
            {
                int idRacuna = Int32.Parse(tbIDRacuna.Text.ToString());
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "";
                sql = "update Racuni set placeno=1 where ID="+idRacuna+";";
                adapter.UpdateCommand = new SqlCommand(sql, db.cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Uspješna transakcija. ID racuna: " + idRacuna);
                db.cnn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska! " + ex);
            }
        }
    }
}
