using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
   public class Farmacia
    {
        public int idMedicina { get; set; }
        public int numMedicina { get; set; }
        public string codMedicina { get; set; } 
        public string detMedicina { get; set; }
        public int cantProducto { get; set; }

        public double costUnit { get; set; }
        public double Total { get; set; }
    }
}
