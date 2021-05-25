using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class Akcija
    {
        public int AkcijosID { get; set; }
        public int KlientoID { get; set; }
        public int Nuolaida { get; set; }
        public Akcija(int akcijosid, int klientoid, int nuolaida)
        {
            AkcijosID = akcijosid;
            KlientoID = klientoid;
            Nuolaida = nuolaida;
        }
    }
}
