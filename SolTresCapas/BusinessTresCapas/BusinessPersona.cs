using FTG.TresCapas.Business.Entity;
using FTG.TresCapas.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTG.TresCapas.Business
{
    public class BusinessPersona
    {
        public BusinessPersona()
        {

        }

        public List<EntPersona> Mostrar() 
        {
            List<EntPersona> lst = new List<EntPersona>();
            DataPersona datP = new DataPersona(); //Entidad
            DataTable dt = datP.Mostrar();

            foreach (DataRow p in dt.Rows)
            {
                EntPersona ent = new EntPersona();

                ent.NombreCompleto.ToString();
                ent.Nombre = Convert.ToString(p["Nombre"]);
                ent.Paterno = Convert.ToString(p["Paterno"]);
                ent.Materno = Convert.ToString(p["Materno"]);
                ent.FechaNacimiento = Convert.ToDateTime(p["FechaNacimiento"]);
                ent.Sueldo = Convert.ToDouble(p["Sueldo"]);
                ent.Estatus = Convert.ToBoolean(p["Estatus"]);
                ent.Sexo_ID = Convert.ToInt32(p["Sexo_ID"]);
                ent.Sexo_Nombre = Convert.ToString(p["Sexo_Nombre"]);
                ent.Sexo_Descripcion = Convert.ToString(p["Sexo_Descripcion"]);
                lst.Add(ent);
            }

            return lst;
        }

        public void Crear(EntPersona p)
        {
            DataPersona datP = new DataPersona();

            if (p.Sexo_Nombre == "Masculino")
            {
                p.ID_Sexo = 1;
            }
            else
            {
                p.ID_Sexo = 2;
            }

            int cantR = datP.CrearPersona(p.Nombre, p.Paterno, p.Materno, p.FechaNacimiento.ToString("MM/dd/yyyy"), p.Sueldo, Convert.ToInt32(p.Estatus), p.ID_Sexo);

            if (cantR != 1)
            {
                throw new Exception("Ya valio");
            }

        }

    }
}
