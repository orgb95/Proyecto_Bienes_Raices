using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bienes_Raices.POCO
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int edad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Estado_Civil { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Pais_Actual { get; set; }
        public string Ciudad_Actual { get; set; }
        public string Direccion_Actual { get; set; }
    }
}
