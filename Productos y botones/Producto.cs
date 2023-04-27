using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos_y_botones
{
    public class Producto
    {
        public int NRegistro { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string ID { get; set; }
        public string Dimension { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }


        public String toString() {


            return this.NRegistro + this.Nombre
                + this.Precio + this.Tipo;
                
                }
    }
}
