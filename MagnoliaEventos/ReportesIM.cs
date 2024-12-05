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
    public partial class ReportesIM : Form
    {
        public ReportesIM()
        {
            InitializeComponent();
        }

        private void btnReportesRIM_Click(object sender, EventArgs e)
        {
            ReportePE reportePE = new ReportePE();
            this.Hide();
            reportePE.Show();
        }

        private void btnVerRIM_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            this.Hide();
            visualizar.Show();
        }

        private void btnEditarRIM_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            this.Hide();
            editar.Show();
        }

        private void btnCrearRIM_Click(object sender, EventArgs e)
        {
            CrearEvento crearEvento = new CrearEvento();
            this.Hide();
            crearEvento.Show();
        }

        private void btnInicioRIM_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }
    }
}
