using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using CapaDatos.Entidades;
using System.Configuration;

namespace CapaDatos
{
   public class GestionBD
        {
        List<Farmacia> listFar;
        public List<Farmacia> listadoFarmacia()
        {
            listFar = new List<Farmacia>(); //inicializamos la variable
            Farmacia objFarmacia = new Farmacia();
            objFarmacia.idMedicina = 1000;
            objFarmacia.numMedicina = 2000;
            objFarmacia.codMedicina = "B100";
            objFarmacia.detMedicina = "Acetaminofen";
            objFarmacia.cantProducto= 2;
            objFarmacia.costUnit = 500;
            objFarmacia.Total = 550;
            listFar.Add(objFarmacia);
            objFarmacia = new Farmacia() { idMedicina = 1100,numMedicina=2100, codMedicina ="B200", detMedicina = "Paracetamol", costUnit = 600, Total = 650 };
            listFar.Add(objFarmacia);
            objFarmacia = new Farmacia() { idMedicina = 1200, numMedicina = 2200, codMedicina = "B300", detMedicina = "Dorival", costUnit = 800, Total = 850 };
            listFar.Add(objFarmacia);
            objFarmacia = new Farmacia() { idMedicina = 1300, numMedicina = 2300, codMedicina = "B300", detMedicina = "Tabcin", costUnit = 750, Total = 800 };
            listFar.Add(objFarmacia);
          
return listFar;
        }
  


    }
}
