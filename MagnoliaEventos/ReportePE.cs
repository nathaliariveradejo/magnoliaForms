using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net.Http;
using MagnoliaEventos.API;


namespace MagnoliaEventos
{
    public partial class ReportePE : Form
    {
        private HttpClient _httpClient;
        public ReportePE()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7003/")
            };
            InitializeComponent();
        }

        private void btnMensual_Click(object sender, EventArgs e)
        {

        }


        private void btnExportarPE_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("ServAdReporte.pdf",FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("Hola Mundoo!"));
            doc.Close();

        }

        private void btnInicioRPE_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();

        }

        private void btnCrearRPE_Click(object sender, EventArgs e)
        {
            Locaciones locaciones = new Locaciones();
            Hide();
            locaciones.Show();

        }

        private void btnEditarRPE_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            this.Hide();
            editar.Show();

        }

        private void btnVerRPE_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            this.Hide();
            visualizar.Show();

        }

        private void btnReportesRPE_Click(object sender, EventArgs e)
        {
            ReportePE reportePE = new ReportePE();
            this.Hide();
            reportePE.Show();

        }

        private void btnProxEventosPE_Click(object sender, EventArgs e)
        {

        }

        private async void btnBitacora_Click(object sender, EventArgs e)
        {
            var respuestaBitacoras = await _httpClient.GetAsync("Bitacora");
            var respuestaJson = await respuestaBitacoras.Content.ReadAsStringAsync();
            var bitacoras = System.Text.Json.JsonSerializer.Deserialize<List<Bitacora>>(respuestaJson);
            mostrarBitacoras(bitacoras);
        }

        private void mostrarBitacoras(List<Bitacora> bitacoras)
        {
            // Asigna la lista como fuente de datos para el DataGridView
            dgvBitacora.DataSource = bitacoras;

            // Configura las columnas del DataGridView
            dgvBitacora.Columns["sesion"].HeaderText = "Sesión";
            dgvBitacora.Columns["usuario"].HeaderText = "Usuario";
            dgvBitacora.Columns["mensaje"].HeaderText = "Mensaje";

            // Ajusta automáticamente el ancho de las columnas
            dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configura la selección para facilitar la interacción
            dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBitacora.ReadOnly = true; // Desactiva la edición si solo deseas mostrar los datos
        }

        private void dgvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
