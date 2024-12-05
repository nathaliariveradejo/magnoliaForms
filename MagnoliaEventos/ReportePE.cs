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


namespace MagnoliaEventos
{
    public partial class ReportePE : Form
    {
        public ReportePE()
        {
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
    }
}
