using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public sealed class SpajanjeNaBazu
    {
        private static SpajanjeNaBazu instanca = null;
        private string cs;
        public SqlConnection cnn;
        private SpajanjeNaBazu()
        {
            cs= @"Data Source=NIKOLAPC\SQLEXPRESS;
                    Initial Catalog=wirelessISPRisek;User ID=nikola;Password=nikola";
            cnn = new SqlConnection(cs);
            cnn.Open();
            cnn.Close();
        }
        public static SpajanjeNaBazu getSpajanjeNaBazu()
        {
            if (instanca == null)
            {
                instanca = new SpajanjeNaBazu();
            }
            return instanca;
        }
    }
}
