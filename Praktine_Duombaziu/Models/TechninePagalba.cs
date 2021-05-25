using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class TechninePagalba
    {
        public int id { get; set; }
        public int transportoId { get; set; }
        public int senoKurjerioId { get; set; }
        public int naujoKurjerioId { get; set; }
        public int uzsakymoId { get; set; }

        public TechninePagalba(int id, int transportoId, int senoKurjerioId, int naujoKurjerioId, int uzsakymoId)
        {
            this.id = id;
            this.transportoId = transportoId;
            this.senoKurjerioId = senoKurjerioId;
            this.naujoKurjerioId = naujoKurjerioId;
            this.uzsakymoId = uzsakymoId;
        }
    }
}
