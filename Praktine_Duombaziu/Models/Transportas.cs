using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class Transportas
    {
        public int transportoId { get; set; }
        public string ValstybinisNumeris { get; set; }
        public string AutomobilioMarke { get; set; }

        public Transportas(int transportoId, string valstybinisNumeris, string automobilioMarke)
        {
            this.transportoId = transportoId;
            ValstybinisNumeris = valstybinisNumeris;
            AutomobilioMarke = automobilioMarke;
        }
    }
}
