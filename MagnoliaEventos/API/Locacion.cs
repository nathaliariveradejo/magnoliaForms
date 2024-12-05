namespace MagnoliaEventos.API
{
    public class Locacion
    {
        public int iD_Locacion { get; set; }

        public string nombre_Locacion { get; set; }
        
        public string tipo_Locacion { get; set; }
        
        public int capacidad_Maxima { get; set; }
        
        public string dirección { get; set; }
        
        public decimal precio_Base { get; set; }
    }
}