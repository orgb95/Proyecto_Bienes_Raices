using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienes_Raices.POCO
{
    public class Vivienda
    {
        public int Id { get; set; }
        public string Ubicacion { get; set; }
        public string Tipo_Vivienda { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
        public float Dimension_Ancho { get; set; }
        public float Dimension_Largo { get; set; }
        public double Costo { get; set; }
    }
}
