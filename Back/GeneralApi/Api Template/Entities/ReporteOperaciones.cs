using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Entities
{
    public class ReporteOperaciones
    {
        public int idTransaccion { get; set; }
        public int idOperacion { get; set; }
        public string idTienda { get; set; }
        public string NombreOrigen { get; set; }
        public string NombreDestino { get; set; }
        public string NombreProducto { get; set; }
        public decimal cantidad { get; set; }
        public string usuario { get; set; }
        public DateTime fecha { get; set; }
    }
}