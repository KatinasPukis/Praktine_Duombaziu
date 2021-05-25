using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class Isvezimas
    {
        public int IsvezimoID { get; set; }
        public string NurodytasAdresas { get; set; }
        public DateTime NurodytasLaikas { get; set; }
        public int KurjerioID { get; set; }
        public Isvezimas(int isvezimoid, string nurodytasadresas, DateTime nurodytaslaikas, int kurjerioid)
        {
            IsvezimoID = isvezimoid;
            NurodytasAdresas = nurodytasadresas;
            NurodytasLaikas = nurodytaslaikas;
            KurjerioID = kurjerioid;
        }
    }
}
