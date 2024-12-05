using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagnoliaEventos.API;

namespace MagnoliaEventos
{
    public partial class Visualizar : Form
    {
        private HttpClient _httpClient;
        public Visualizar()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7003/")
            };
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var idEvento = txtBuscar.Text;
            var eventoResponse = await _httpClient.GetAsync($"Eventos/{idEvento}");
            var eventoJson = await eventoResponse.Content.ReadAsStringAsync();
            var evento = System.Text.Json.JsonSerializer.Deserialize<Evento>(eventoJson);

            var idLocacion = evento.iD_Locacion;
            var locacionResponse = await _httpClient.GetAsync($"Locacion/{idLocacion}");
            var locacionJson = await locacionResponse.Content.ReadAsStringAsync();
            var locacion = System.Text.Json.JsonSerializer.Deserialize<Locacion>(locacionJson);

            var servicios = await obtenerServiciosDeEvento(evento.iD_Evento);
            
            mostrarEventos(new List<Evento>{evento});
            mostrarLocaciones(new List<Locacion>{locacion});
            mostrarServiciosAd(servicios);
        }

        private void mostrarEventos(List<Evento> eventos)
        {
            DGVTablaEvento.DataSource = eventos;
            
            // Configura las columnas del DataGridView
            DGVTablaEvento.Columns["iD_Evento"].HeaderText = "ID del Evento";
            DGVTablaEvento.Columns["tipo_Evento"].HeaderText = "Tipo de Evento";
            DGVTablaEvento.Columns["fecha_Evento"].HeaderText = "Fecha del Evento";
            DGVTablaEvento.Columns["hora_Evento"].HeaderText = "Hora del Evento";
            DGVTablaEvento.Columns["número_Personas"].HeaderText = "Cantidad de Personas";
            DGVTablaEvento.Columns["correo_Electrónico"].HeaderText = "Correo Electrónico";
            DGVTablaEvento.Columns["iD_Locacion"].HeaderText = "ID de la Locacion";

            // Ajusta automáticamente el ancho de las columnas
            DGVTablaEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configura la selección para facilitar la interacción
            DGVTablaEvento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVTablaEvento.ReadOnly = true; // Desactiva la edición si solo deseas mostrar los datos
        }
        
        private void mostrarLocaciones(List<Locacion> locaciones)
        {
            DGVTablaLocacion.DataSource = locaciones;
            
            // Configura las columnas del DataGridView
            DGVTablaLocacion.Columns["iD_Locacion"].HeaderText = "ID de la Locacion";
            DGVTablaLocacion.Columns["nombre_Locacion"].HeaderText = "Nombre de la Locacion";
            DGVTablaLocacion.Columns["tipo_Locacion"].HeaderText = "Tipo de Locacion";
            DGVTablaLocacion.Columns["capacidad_Maxima"].HeaderText = "Capacidad Maxima de la Locacion";
            DGVTablaLocacion.Columns["dirección"].HeaderText = "Dirección";
            DGVTablaLocacion.Columns["precio_Base"].HeaderText = "Precio Base";

            // Ajusta automáticamente el ancho de las columnas
            DGVTablaLocacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configura la selección para facilitar la interacción
            DGVTablaLocacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVTablaLocacion.ReadOnly = true; // Desactiva la edición si solo deseas mostrar los datos
        }
        
        private void mostrarServiciosAd(List<ServiciosAd> servicios)
        {
            DGVTablaServicio.DataSource = servicios;
            
            // Configura las columnas del DataGridView
            DGVTablaServicio.Columns["iD_Servicio"].HeaderText = "ID del Servicio";
            DGVTablaServicio.Columns["nombre_Servicio"].HeaderText = "Nombre del Servicio";
            DGVTablaServicio.Columns["precio_Servicio"].HeaderText = "Precio";
            DGVTablaServicio.Columns["descripción"].HeaderText = "Descripción del Servicio";
            DGVTablaServicio.Columns["teléfono"].HeaderText = "Teléfono";

            // Ajusta automáticamente el ancho de las columnas
            DGVTablaServicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configura la selección para facilitar la interacción
            DGVTablaServicio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVTablaServicio.ReadOnly = true; // Desactiva la edición si solo deseas mostrar los datos
        }

        private async Task<List<ServiciosAd>> obtenerServiciosDeEvento(int idEvento)
        {
            var detallesResponse = await _httpClient.GetAsync($"DetallesServicios");
            var detallesJson = await detallesResponse.Content.ReadAsStringAsync();
            var detalles = System.Text.Json.JsonSerializer.Deserialize<List<DetallesDeServicio>>(detallesJson);

            var detallesDeEvento = detalles.FindAll(detalle => detalle.iD_Eventos == idEvento);
            var servicios = new List<ServiciosAd>();
            foreach (var servicioAdId in detallesDeEvento.Select(detalle => detalle.iD_Servicio))
            {
                var servicioAdResponse = await _httpClient.GetAsync($"ServiciosAd/{servicioAdId}");
                var servicioAdJson = await servicioAdResponse.Content.ReadAsStringAsync();
                var servicioAd = System.Text.Json.JsonSerializer.Deserialize<ServiciosAd>(servicioAdJson);
                servicios.Add(servicioAd);
            }
            return servicios;
        }
    }
}
