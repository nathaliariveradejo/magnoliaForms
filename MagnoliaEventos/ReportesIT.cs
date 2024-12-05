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
    public partial class ReportesIT : Form
    {
        public ReportesIT()
        {
            InitializeComponent();
        }

        private void btnInicioRIT_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }

        private void btnCrearRIT_Click(object sender, EventArgs e)
        {
            Locaciones locaciones = new Locaciones();
            Hide();
            locaciones.Show();
        }

        private void btnEditarRIT_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            this.Hide();
            editar.Show();

        }

        private void btnVerRIT_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            this.Hide();
            visualizar.Show();
        }

        private void btnReportesRIT_Click(object sender, EventArgs e)
        {
            ReportePE reportePE = new ReportePE();
            this.Hide();
            reportePE.Show();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {

        }
    }
}
