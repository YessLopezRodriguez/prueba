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
    public class BusCadena
    {
        public BusCadena()
        {

        }

        public List<EntCadena> Mostrar()
        {
            List<EntCadena> lst = new List<EntCadena>();
            DataCadena datC = new DataCadena();
            DataTable dt = datC.Mostrar();

            foreach (DataRow c in dt.Rows)
            {
                EntCadena entC = new EntCadena();

                entC.Cadena = Convert.ToString(c["Cadena"]);
                entC.Encriptada = Convert.ToString(c["Encriptada"]);
                entC.Mayusculas = Convert.ToString(c["Mayusculas"]);
                entC.Minusculas = Convert.ToString(c["Minusculas"]);
                entC.Guion = Convert.ToString(c["Guion"]);
                entC.LetraCapital = Convert.ToString(c["Reves"]);
                entC.Reves = Convert.ToString(c["Reves"]);

                lst.Add(entC);
            }
            return lst;
        }



        //public void Insertar()
        //{
        //   foreach (EntCadena c in lstC)
        //    {
        //        string encritpado = "";

        //        foreach (char l in lstC)
        //        {
        //            char nuevo = Convert.ToChar(l + 3);
        //            encritpado += nuevo.ToString();
        //        }
        //        Console.WriteLine("{0} {1}", c.Cadena, encritpado);
        //    }            
        //}

        public void InsertaCadenas(string dato)
        {
            EntCadena c = new EntCadena();

            c.Mayusculas = dato.ToUpper();
            c.Minusculas = dato.ToLower();

            foreach (char l in dato)
            {
                char nuevo = Convert.ToChar(l + 1);
                c.Encriptada += nuevo.ToString();
            }

            foreach (char l in dato)
            {
                char nuevo = Convert.ToChar(l);
                c.Guion += nuevo.ToString();
            }

            DataCadena datC = new DataCadena();
            int cantI = datC.Insertar(dato, c.Encriptada, c.Mayusculas, c.Minusculas, dato, dato, dato);
        }
    }
}

