using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterNetFram.Dominio
{
    public class Atencion
    {
        public int id_atencion { get; set; }
        public DateTime fecha { get; set; }
        public string a_descrip { get; set; }
        public double importe { get; set; }
        public Mascotas id_mascota { get; set; }
        public Usuarios id_usuario { get; set; }
        public bool borrado { get; set; }
    }
}
