using System;

namespace MagnoliaEventos.API
{
    public class Evento
    {
        public int iD_Evento { get; set; }
        
        public string tipo_Evento { get; set; }
        
        public string fecha_Evento { get; set; }
        
        public string hora_Evento { get; set; }
        
        public int número_Personas { get; set; }
        
        public string correo_Electrónico { get; set; }
        
        public int iD_Locacion { get; set; }
    }
}