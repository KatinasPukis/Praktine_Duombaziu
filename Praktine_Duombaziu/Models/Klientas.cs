using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
   public class Klientas
    {
        public int KlientoID { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public string ElPastas { get; set; }
        public string TelNr { get; set; }
        public DateTime Gimtadienis { get; set; }

        public Klientas(int klientoID, string vardas, string pavarde, string elPastas, string telNr, DateTime gimtadienis)
        {
            KlientoID = klientoID;
            Vardas = vardas;
            Pavarde = pavarde;
            ElPastas = elPastas;
            TelNr = telNr;
            Gimtadienis = gimtadienis;
        }
    }

}
