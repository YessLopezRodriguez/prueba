using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTG.TresCapas.Business.Entity
{
    public class EntCadena
    {
        public EntCadena()
        {

        }

        public int ID { get; set; }
        public  string Cadena { get; set; }
        public string Encriptada { get; set; }
        public string Mayusculas { get; set; }
        public string Minusculas { get; set; }
        public string Guion { get; set; }
        public string LetraCapital { get; set; }
        public string Reves { get; set; }
    }
}
