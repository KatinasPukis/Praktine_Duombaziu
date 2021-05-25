using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class UzsakymoIstorija
    {
        public int istorijosId { get; set; }
        public int uzsakymoId { get; set; }
        public int klientoId { get; set; }
        public int kurjerioId { get; set; }
        public int apmokejimoId { get; set; }

        public UzsakymoIstorija(int istorijosId, int uzsakymoId, int klientoId, int kurjerioId, int apmokejimoId)
        {
            this.istorijosId = istorijosId;
            this.uzsakymoId = uzsakymoId;
            this.klientoId = klientoId;
            this.kurjerioId = kurjerioId;
            this.apmokejimoId = apmokejimoId;
        }
    }
}
