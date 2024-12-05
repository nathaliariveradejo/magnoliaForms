using System;

namespace MagnoliaEventos.API
{
    public class PostFacturaRequest
    {
        public DateTime Fecha_Factura { get; set; }
        
        public string Método_Pago { get; set; }
        
        public string Estado_Pago { get; set; }
        
        public decimal Monto_Total { get; set; }
        
        public int ID_Evento { get; set; }
    }
}