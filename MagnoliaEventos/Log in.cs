using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnoliaEventos
{
    public partial class Form1 : Form
    {
        private HttpClient _httpClient;
        public Form1()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7003/")
            };
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private async void btnSesión_Click(object sender, EventArgs e)
        {
            // Poner logica para extraer la info necesaria de los otros campos

            // Crear su objeto de request usando la info que sacaron de los otros campos
            var idEvento = 137;
            var putEventosRequest = new PutEventosRequest()
            {
                Tipo_Evento = TipoDeEvento.Matrimonio,
                Fecha_Evento = "2021-09-01",
                Hora_Evento = "15:00:00",
                Número_Personas = 100,
                ID_Usuario = 201,
                ID_Locacion = 220,
            };
            
            // Llamar a la API
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"Eventos/{idEvento}", putEventosRequest);
            
            // Procesar response
            Console.WriteLine("Respuesta de APIpi:");
            Console.WriteLine(response.StatusCode);
        }
        
        public enum TipoDeEvento
        {
            Matrimonio,
            Cumpleaños,
            Reunión_Ejecutiva,
            Graduación,
            Festividad,
            Quinceaños
        }
        
        public class PutEventosRequest
        {
            public TipoDeEvento Tipo_Evento { get; set; }
            
            public string Fecha_Evento { get; set; }
            
            public string Hora_Evento { get; set; }
            
            public int Número_Personas { get; set; }
            
            public int ID_Usuario { get; set; }
            
            public int ID_Locacion { get; set; }
        }
    }
}
