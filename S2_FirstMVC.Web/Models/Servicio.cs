using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2_FirstMVC.Web.Models
{
    public class Servicio
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public Servicio(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public Servicio()
        {

        }



    }
}
