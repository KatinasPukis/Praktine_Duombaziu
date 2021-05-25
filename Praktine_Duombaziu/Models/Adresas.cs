using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class Adresas
    {
        public int AdresoID { get; set; }
        public string Salis { get; set; }
        public string Miestas { get; set; }
        public string Gatve { get; set; }
        public int NamoNr { get; set; }
        public int ButoNr { get; set; }
        public string PastoIndeksas { get; set; }
        public int KlientoID { get; set; }

        public Adresas(int adresoID, string salis, string miestas, string gatve, int namonr, int butonr, string pastoindeksas, int klientoid)
        {
            AdresoID = adresoID;
            Salis = salis;
            Miestas = miestas;
            Gatve = gatve;
            NamoNr = namonr;
            NamoNr = namonr;
            ButoNr = butonr;
            PastoIndeksas = pastoindeksas;
            KlientoID = klientoid;
        }


    }
}
