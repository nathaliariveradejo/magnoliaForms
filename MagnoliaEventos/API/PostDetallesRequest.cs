namespace MagnoliaEventos.API
{
    public class PostDetallesRequest
    {
        public string Notas_Adicionales { get; set; }
        
        public int ID_Servicio { get; set; }
        
        public int ID_Eventos { get; set; }
    }
}