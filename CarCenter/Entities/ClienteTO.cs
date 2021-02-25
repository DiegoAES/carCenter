using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClienteTO
    {
        public long ClienteId { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string TipoDocumento { get; set; }
        public decimal? Documento { get; set; }
        public decimal? Celular { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}
