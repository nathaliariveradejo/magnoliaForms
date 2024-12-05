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
    public partial class Locaciones : Form
    {
        private Dictionary<RadioButton, (int value, string txt)> radioButtonValues;

        public Locaciones()
        {
            InitializeComponent();
            radioButtonValues = new Dictionary<RadioButton, (int value, string txt)>
            {
                {rdbPlayaCE, (950, "Playa") },
                {rdbBosqueCE, (950, "Bosque") },
                {rdbLagoCE, (950, "Lago") },
                {rdbJardinCE, (1000, "Jardín") },
                {rdbTerrazaCE, (1100, "Terraza") },
                {rdbVistaMarCE, (1400, "Vista_al_Mar") },
                {rdbVistaBosqueCE, (1400, "Vista_a_la_Montaña") },
                {rdbCapillaCE, (1000, "Capilla") },
                {rdbInvernaderoCE, (1200, "Invernadero") }
            };

        }

        private void rdbAireLibre_CheckedChanged(object sender, EventArgs e)
        {
            panelBajoTechoCE.Enabled = false;
            panelAireLibreCE.Visible = true;
        }

        private void panelBajoTechoCE_Paint(object sender, PaintEventArgs e)
        {
            panelAireLibreCE.Visible=false;
            panelBajoTechoCE.Visible=true;
        }

        private void panelAireLibreCE_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void rdbPlayaCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Playa";
        }

        private void rdbBosqueCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Bosque";
        }

        private void rdbLagoCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Lago";
        }

        private void rdbJardinCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Jardín";
        }

        private void rdbTerrazaCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Terraza";
        }

        private void rdbVistaMarCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Vista_al_Mar";
        }

        private void rdbVistaBosqueCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Vista_a_la_Montaña";
        }

        private void rdbVistaLagoCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Vista_a_la_Lago";
        }

        private void rdbCapillaCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Capilla";
        }

        private void rdbInvernaderoCE_CheckedChanged(object sender, EventArgs e)
        {
            string resp;
            resp = "Invernadero";
        }
    }
}
