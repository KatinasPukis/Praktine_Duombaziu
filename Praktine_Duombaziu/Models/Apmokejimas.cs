using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class Apmokejimas
    {
        public int ApmokejimoID { get; set; }
        public string ApmokejimoTipas { get; set; }
        public double Suma { get; set; }
        public DateTime ApmokejimoLaikas { get; set; }

        public Apmokejimas(int apmokejimoid, string apmokejimoTipas, double suma, DateTime apmokejimoLaikas)
        {
            ApmokejimoID = apmokejimoid;
            ApmokejimoTipas = apmokejimoTipas;
            Suma = suma;
            ApmokejimoLaikas = apmokejimoLaikas;
        }
    }
}
