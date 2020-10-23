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
    public partial class Inboks : Form
    {
        public Inboks(int id)
        {
            InitializeComponent();
            idPrijavljenog = id;
        }
        public int idPrijavljenog = 0;
        private void Inboks_Load(object sender, EventArgs e)
        {
            try
            {
                SpajanjeNaBazu db = SpajanjeNaBazu.getSpajanjeNaBazu();
                db.cnn.Open();
                SqlCommand naredba;
                SqlDataReader dataReader;
                string sql = "";
                sql = "select * from Inboks where ID_osobe=" + idPrijavljenog + "and ID_uloge=2";
                naredba = new SqlCommand(sql, db.cnn);
                dataReader = naredba.ExecuteReader();
                while (dataReader.Read())
                {
                    lbInboks.Items.Add("Poruka: " + dataReader.GetValue(3) + "\r \n");
                    lbInboks.Items.Add("\r \n");
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
