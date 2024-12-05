using System;
using System.Windows.Forms;

namespace MagnoliaEventos
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void btnInicioI_Click(object sender, EventArgs e) { }

        private void btnCrearI_Click(object sender, EventArgs e)
        {
            Locaciones locaciones = new Locaciones();
            Hide();
            locaciones.Show();
        }

        private void btnVerI_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            Hide();
            visualizar.Show();
        }

        private void btnReportesI_Click(object sender, EventArgs e)
        {
            ReportePE reportePE = new ReportePE();
            Hide();
            reportePE.Show();   
        }
    }
}
