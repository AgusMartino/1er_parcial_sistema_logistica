using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralApi.Entities
{
    public class GetOperacionesFiltroFecha
    {
        public int id { get; set; }
        public DateTime inicio { get; set; }
        public DateTime final { get; set; }
    }
}