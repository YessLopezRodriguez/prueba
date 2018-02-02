using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTG.TresCapas.Business.Entity
{
    public class EntPersona
    {

        public EntPersona()
        {

        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string NombreCompleto 
        {
            get
            {
                return string.Format("{0} {1} {2}", Nombre, Paterno, Materno);
            }
        }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }
        public bool Estatus { get; set; }
        public int ID_Sexo { get; set; }

        public int Sexo_ID { get; set; }
        public string Sexo_Nombre { get; set; }
        public string Sexo_Descripcion { get; set; }
    }   
}
