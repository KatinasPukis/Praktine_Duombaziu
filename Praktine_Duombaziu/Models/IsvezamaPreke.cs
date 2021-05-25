using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class IsvezamaPreke
    {
        public int OpreacijosNr { get; set; }
        public string IsvezamosTechnikosPav { get; set; }
        public int Kiekis { get; set; }
        public int UzsakymoID { get; set; }
        public int IsvezimoID { get; set; }

        public IsvezamaPreke(int opreacijosNr, string isvezamostechPav, int kiekis, int uzsakymoid, int isvezimoid)
        {
            OpreacijosNr = opreacijosNr;
            IsvezamosTechnikosPav = isvezamostechPav;
            Kiekis = kiekis;
            UzsakymoID = uzsakymoid;
            IsvezamosTechnikosPav = isvezamostechPav;
        }
    }
}
