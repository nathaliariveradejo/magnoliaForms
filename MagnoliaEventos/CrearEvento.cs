using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagnoliaEventos.API;

namespace MagnoliaEventos
{
    public partial class CrearEvento : Form
    {
        private HttpClient _httpClient;
        private EventoInfo _eventoInfo;
        private Dictionary<CheckBox, (int value, string text)> _checkBoxValues;

        private DateTime _fechaS;
        private DateTime _horaS;
        private int _totalS;
        private List<string> _opcionS;
        private int _cantS;
        private string _detalleS;

        public CrearEvento(EventoInfo eventoInfo)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7003/")
            };
            InitializeComponent();
            _eventoInfo = eventoInfo;
            dtpFechaCE.ValueChanged += dtpFechaCE_ValueChanged;
            dtpHoraCE.ValueChanged += dtpHoraCE_ValueChanged;

            _checkBoxValues = new Dictionary<CheckBox, (int value, string text)>
            {
                { chkFoto, (200, "Fotografía") },
                { chkDecoBasic, (500, "Decoración_Básica") },
                { chkDecoPremium, (1000, "Decoración_Premium") },
                { chkCatering, (50, "Catering") },
                { chkSonido, (300, "Equipo_de_Sonido_con_DJ") },
                { chkMariachi, (120, "Mariachi") },
                { chkMurga, (250, "Murga") },
                { chkMúsica, (400, "Música_en_Vivo") },
                { chkAnimador, (250, "Animadores") },
                { chkPayaso, (50, "Payaso") }
            };

            // Conectar el evento CheckedChanged de los CheckBox al manejador de eventos
            foreach (var checkBox in _checkBoxValues.Keys)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }

            // Inicializar variables
            _cantS = 0;
            _totalS = 0;
            _opcionS = new List<string>();
            UpdateTotalLabel();

        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                _totalS += _checkBoxValues[checkBox].value;
                _opcionS.Add(_checkBoxValues[checkBox].text);
            }
            else
            {
                _totalS -= _checkBoxValues[checkBox].value;
                _opcionS.Remove(_checkBoxValues[checkBox].text);
            }

            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            // Mostrar el total en el Label
            lblCosto.Text = "$" + _totalS;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            ReportePE form9 = new ReportePE();
            form9.Show();
            this.Close();
        }

        private async void btnSigCE1_Click(object sender, EventArgs e)
        {
            _eventoInfo.TipoEvento = cbEventType.SelectedItem?.ToString();
            _eventoInfo.FechaEvento = dtpFechaCE.Value;
            _eventoInfo.HoraEvento = dtpHoraCE.Value;
            _eventoInfo.CantidadPersonas = (int)txtCantPersCE.Value;
            _eventoInfo.CostoTotal = _totalS;
            _eventoInfo.Opciones = _opcionS;
            _eventoInfo.MetodoPago = cbPago.SelectedItem?.ToString();
            _eventoInfo.Detalles = _detalleS;
            _eventoInfo.ID_Evento = await CrearEventoEnBd();

            crearDetallesDeServicio();

            CrearFactura();

            Factura facturaForm = new Factura(_eventoInfo);
            facturaForm.Show();
            Hide();
        }
        
        private async Task<int> CrearEventoEnBd()
        {
            var request = new PostEventoRequest
            {
                Tipo_Evento = _eventoInfo.TipoEvento,
                Fecha_Evento = _eventoInfo.FechaEvento.ToString("yyyy-MM-dd"),
                Hora_Evento = _eventoInfo.HoraEvento.ToString("HH:mm:ss"),
                Número_Personas = _eventoInfo.CantidadPersonas,
                Correo_Electrónico = Form1.ObtenerUsuarioActual(),
                ID_Locacion = await ObtenerIdDeLocacion()
            };
            var response = await _httpClient.PostAsJsonAsync("Eventos", request);
            var respuestaJson = await response.Content.ReadAsStringAsync();
            var evento = System.Text.Json.JsonSerializer.Deserialize<Evento>(respuestaJson);
            return evento.iD_Evento;
        }

        private async Task<int> ObtenerIdDeLocacion()
        {
            var nombreLocacion = _eventoInfo.Locacion;
            var respuestaLocaciones = await _httpClient.GetAsync("Locacion");
            var respuestaJson = await respuestaLocaciones.Content.ReadAsStringAsync();
            var locaciones = System.Text.Json.JsonSerializer.Deserialize<List<Locacion>>(respuestaJson);
            
            return locaciones.Find(locacion => locacion.tipo_Locacion == nombreLocacion).iD_Locacion;
        }

        private async void CrearFactura()
        {
            var request = new PostFacturaRequest
            {
                Fecha_Factura = DateTime.Today,
                Método_Pago = _eventoInfo.MetodoPago,
                Estado_Pago = "Pendiente",
                Monto_Total = _eventoInfo.CostoTotal,
                ID_Evento = _eventoInfo.ID_Evento
            };
            
            await _httpClient.PostAsJsonAsync("Facturas", request);
        }

        private async void crearDetallesDeServicio()
        {
            var serviciosAdicionalesResponse = await _httpClient.GetAsync("ServiciosAd");
            var serviciosAdJson = await serviciosAdicionalesResponse.Content.ReadAsStringAsync();
            var serviciosAd = System.Text.Json.JsonSerializer.Deserialize<List<ServiciosAd>>(serviciosAdJson);
            
            _opcionS.ForEach(opcion =>
            {
                crearDetalleDeServicio(opcion, serviciosAd);
            });
        }

        private async void crearDetalleDeServicio(string nombreServicio, List<ServiciosAd> serviciosAdicionales)
        {
            var idServicio = serviciosAdicionales.Find(servicio => servicio.nombre_Servicio == nombreServicio)
                .iD_Servicio;
            var request = new PostDetallesRequest
            {
                Notas_Adicionales = $"Evento con ID [{_eventoInfo.ID_Evento}] contrata Servicio Ad con ID [{idServicio}]",
                ID_Servicio = idServicio,
                ID_Eventos = _eventoInfo.ID_Evento
            };
            var response = await _httpClient.PostAsJsonAsync("DetallesServicios", request);
        }

        private void dtpFechaCE_ValueChanged(object sender, EventArgs e)
        {
            _fechaS = dtpFechaCE.Value;
        }

        private void dtpHoraCE_ValueChanged(object sender, EventArgs e)
        {
            _horaS = dtpHoraCE.Value;
        }

        private void cbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cantS = (int)txtCantPersCE.Value;
        }

        private void btnInicioC_Click(object sender, EventArgs e)
        {
            LandingPage form8 = new LandingPage();
            form8.Show();
            Close();
        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVerC_Click(object sender, EventArgs e)
        {
            Visualizar form6 = new Visualizar();
            form6.Show();
            Close();
        }

        private void txtDetallesCE_TextChanged(object sender, EventArgs e)
        {
            _detalleS = txtDetallesCE.ToString(); 
        }
    }
}