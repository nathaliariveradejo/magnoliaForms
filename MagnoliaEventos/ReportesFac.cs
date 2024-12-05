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
    public partial class ReportesFac : Form
    {
        public ReportesFac()
        {
            InitializeComponent();
        }

        private void btnInicioRFAC_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();

        }

        private void btnCrearRFAC_Click(object sender, EventArgs e)
        {
            Locaciones locaciones = new Locaciones();
            Hide();
            locaciones.Show();
        }

        private void btnEditarRFAC_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            this.Hide();
            editar.Show();
        }

        private void btnVerRFAC_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            this.Hide();
            visualizar.Show();
        }

        private void btnReportesRFAC_Click(object sender, EventArgs e)
        {
            ReportePE reportePE = new ReportePE();
            this.Hide();
            reportePE.Show();
        }
    }
}
