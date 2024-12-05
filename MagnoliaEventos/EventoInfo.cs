using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnoliaEventos
{
    public class EventoInfo
    {
        public string TipoEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public DateTime HoraEvento { get; set; }
        public int CantidadPersonas { get; set; }
        public int CostoTotal { get; set; }
        public List<string> Opciones { get; set; }
        public string MetodoPago { get; set; }
        public string Detalles {  get; set; }
        public string Locacion { get; set; }
        public int PrecioLocacion { get; set; }
    }
}
