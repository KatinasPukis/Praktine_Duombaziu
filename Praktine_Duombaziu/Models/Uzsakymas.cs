using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine.Models
{
    public class Uzsakymas
    {
        public int uzsakymoId { get; set; }
        public string busena { get; set; }
        public DateTime uzsakymoData { get; set; }
        public DateTime ivykdymoData { get; set; }
        public int klientoId { get; set; }
        public int pristatymoId { get; set; }
        public int isvezimoId { get; set; }

        public Uzsakymas(int uzsakymoId, string busena, DateTime uzsakymoData, DateTime ivykdymoData, int klientoId, int pristatymoId, int isvezimoId)
        {
            this.uzsakymoId = uzsakymoId;
            this.busena = busena;
            this.uzsakymoData = uzsakymoData;
            this.ivykdymoData = ivykdymoData;
            this.klientoId = klientoId;
            this.pristatymoId = pristatymoId;
            this.isvezimoId = isvezimoId;
        }
    }
}
