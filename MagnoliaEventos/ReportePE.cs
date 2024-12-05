using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnInicioRPE_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();

        }

        private void btnCrearRPE_Click(object sender, EventArgs e)
        {
            CrearEvento crearEvento = new CrearEvento();
            this.Hide();
            crearEvento.Show();

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
