using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTG.TresCapas.Data
{
    public class DataCadena
    {
        public DataCadena()
        {

        }

        public DataTable Mostrar()
        {
            string cadCon = "Initial Catalog = YES; Data Source = (local); User Id = sa; Password = 12345;";
            SqlConnection con = new SqlConnection(cadCon);

            string sent = "select id, cadena, encriptada, mayusculas, minusculas, guion, letracapital, reves from cadenas";
            SqlDataAdapter da = new SqlDataAdapter(sent, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public int Insertar(string cadena, string encriptada, string mayusculas, string minusculas, string guion, string letraCapital, string reves)
        {
            string cadCon = "Initial Catalog = YES; Data Source = (local); User Id = sa; Password = 12345;";
            SqlConnection con = new SqlConnection(cadCon);
            string sent = string.Format("insert into cadenas (Cadena, Encriptada, Mayusculas, Minusculas, Guion, LetraCapital, Reves) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", cadena, encriptada, mayusculas, minusculas, guion, letraCapital, reves);
            SqlCommand com = new SqlCommand(sent, con);

            con.Open();

                int cantInsert = com.ExecuteNonQuery();
                con.Close();
                return cantInsert;
        }
    }
}
