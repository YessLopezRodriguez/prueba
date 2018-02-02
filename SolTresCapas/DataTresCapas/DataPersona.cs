using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTG.TresCapas.Data
{
    public class DataPersona
    {
        public DataPersona()
        {

        }

        public DataTable Mostrar()
        {
            string cadCon = "Initial Catalog = YES; Data Source = (local); User Id = sa; Password = 12345;";
            SqlConnection con = new SqlConnection(cadCon);

            string sent = "select per.ID, per.Nombre, Paterno, Materno, FechaNacimiento, Sueldo, Estatus, per.ID_Sexo, sex.ID_Sexo Sexo_ID, sex.Nombre Sexo_Nombre, Descripcion Sexo_Descripcion from persona per inner join sexo sex on per.ID_Sexo = sex.ID_Sexo";
            SqlDataAdapter da = new SqlDataAdapter(sent, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int CrearPersona(string nombre, string paterno, string materno, string fechanacimiento, double sueldo, int estatus, int sexo)
        {
            string cadCon = "Initial Catalog = YES; Data Source = (local); User Id = sa; Password = 12345";
            SqlConnection con = new SqlConnection(cadCon);

            string sentencia = string.Format("insert into persona (Nombre, Paterno, Materno, FechaNacimiento, Sueldo, Estatus, ID_Sexo) values ('{0}', '{1}', '{2}', '{3}', {4}, {5}, {6} )", nombre, paterno, materno, fechanacimiento, sueldo, estatus, sexo);
            SqlCommand com = new SqlCommand(sentencia, con);

            con.Open();

            try
            {
                int cantRow = com.ExecuteNonQuery();
                con.Close();
                return cantRow;
            }
            catch (Exception ex)
            {
                con.Close();
                throw ex;
            }
        }

    }
}       
