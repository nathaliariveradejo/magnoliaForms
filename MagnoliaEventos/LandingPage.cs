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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void btnInicioI_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }

        private void btnCrearI_Click(object sender, EventArgs e)
        {
            CrearEvento crearEvento = new CrearEvento();
            this.Hide();
            crearEvento.Show();
        }

        private void btnEditarI_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            this.Hide();
            editar.Show();
        }

        private void btnVerI_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            this.Hide();
            visualizar.Show();
        }

        private void btnReportesI_Click(object sender, EventArgs e)
        {
            ReportePE reportePE = new ReportePE();
            this.Hide();
            reportePE.Show();   
        }
    }
}
