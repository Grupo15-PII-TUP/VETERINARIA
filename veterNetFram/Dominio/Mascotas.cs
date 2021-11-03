using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterNetFram.Dominio
{
    public class Mascotas
    {
        public int id_mascota { get; set; }
        public string m_nombre { get; set; }
        public int edad { get; set; }
        public Tipos id_tipo { get; set; }
        public Clientes id_cliente { get; set; }
        public bool borrado { get; set; }
    }

}
