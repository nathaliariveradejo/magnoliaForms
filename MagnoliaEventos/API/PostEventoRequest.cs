using System;

namespace MagnoliaEventos.API
{
    public class PostEventoRequest
    {
        public string Tipo_Evento { get; set; }
        
        public string Fecha_Evento { get; set; }
        
        public string Hora_Evento { get; set; }
        
        public int Número_Personas { get; set; }
        
        public string Correo_Electrónico { get; set; }

        public int ID_Locacion { get; set; }
        
    }
}