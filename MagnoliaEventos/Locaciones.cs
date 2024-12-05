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
        private Dictionary<RadioButton, (int value, string txt)> _radioButtonValues;
        private EventoInfo _eventoInfo;
        public Locaciones()
        {      
            _eventoInfo = new EventoInfo();
            InitializeComponent();
            
            _radioButtonValues = new Dictionary<RadioButton, (int value, string txt)>
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
            foreach (var radioButton in _radioButtonValues.Keys)
            {
                radioButton.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                _eventoInfo.PrecioLocacion = _radioButtonValues[radioButton].value;
                _eventoInfo.Locacion = _radioButtonValues[radioButton].txt;
            }
        }



        private void rdbAireLibre_CheckedChanged(object sender, EventArgs e)
        {
            panelBajoTechoCE.Visible = false;
            panelAireLibreCE.Visible = true;
        }
        
        private void rdbBajoTecho_CheckedChanged(object sender, EventArgs e)
        {
            panelAireLibreCE.Visible=false;
            panelBajoTechoCE.Visible=true;
        }

        private void panelBajoTechoCE_Paint(object sender, PaintEventArgs e)
        {
            
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

        private void btnSig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_eventoInfo.Locacion))
            {
                MessageBox.Show("Por favor, seleccione una locación antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                CrearEvento crearEvento = new CrearEvento(_eventoInfo);
                crearEvento.Show();
                Close();
            }
        }

        private void btnInicioC2_Click(object sender, EventArgs e)
        {
            LandingPage form8 = new LandingPage();
            form8.Show();
            Close();
        }

        private void btnCrearC2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerC2_Click(object sender, EventArgs e)
        {
            Visualizar form6 = new Visualizar();
            form6.Show();
            this.Close();
        }

        private void btnReportesC2_Click(object sender, EventArgs e)
        {
            ReportePE form9 = new ReportePE();
            form9.Show();
            this.Close();
        }
    }
}
