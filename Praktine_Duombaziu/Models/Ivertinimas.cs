using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class Ivertinimas
    {
        public int IvertinimoID { get; set; }
        public int KurjerioIvertinimas { get; set; }
        public int ProduktoIvertinimas { get; set; }
        public string Komentaras { get; set; }
        public int KlientoID { get; set; }
        public int UzsakymoID { get; set; }

        public Ivertinimas(int ivertinimoID, int kurjerioIvertinimas, int produktoIvertinimas, string komentaras, int klientoID, int uzsakymoID)
        {
            IvertinimoID = ivertinimoID;
            KurjerioIvertinimas = kurjerioIvertinimas;
            ProduktoIvertinimas = produktoIvertinimas;
            Komentaras = komentaras;
            KlientoID = klientoID;
            UzsakymoID = uzsakymoID;
        }
    }
}
