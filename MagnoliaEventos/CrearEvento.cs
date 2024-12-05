using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MagnoliaEventos
{
    public partial class CrearEvento : Form
    {
        private Dictionary<CheckBox, (int value, string text)> checkBoxValues;

        private DateTime fechaS;
        private DateTime horaS;
        private int totalS;
        private List<string> opcionS;
        private int cantS;
        private string tipoS;
        private string metodoPagoS; 

        public CrearEvento()
        {
            InitializeComponent();
            dtpFechaCE.ValueChanged += new EventHandler(dtpFechaCE_ValueChanged);
            dtpHoraCE.ValueChanged += new EventHandler(dtpHoraCE_ValueChanged);

            checkBoxValues = new Dictionary<CheckBox, (int value, string text)>
            {
                { chkFoto, (200, "Fotografía") },
                { chkDecoBasic, (500, "Decoración Básica") },
                { chkDecoPremium, (1000, "Decoración Premium") },
                { chkCatering, (50, "Catering") },
                { chkSonido, (300, "Equipo de Sonido con DJ") },
                { chkMariachi, (120, "Mariachi") },
                { chkMurga, (250, "Murga") },
                { chkMúsica, (400, "Música en Vivo") },
                { chkAnimador, (250, "Animadores") },
                { chkPayaso, (50, "Payaso") }
            };

            btnSigCE1.Click += new EventHandler(btnSigCE1_Click);

            // Conectar el evento CheckedChanged de los CheckBox al manejador de eventos
            foreach (var checkBox in checkBoxValues.Keys)
            {
                checkBox.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            }

            // Inicializar variables
            cantS = 0;
            totalS = 0;
            opcionS = new List<string>();
            UpdateTotalLabel();

        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Checked)
            {
                totalS += checkBoxValues[checkBox].value;
                opcionS.Add(checkBoxValues[checkBox].text);
            }
            else
            {
                totalS -= checkBoxValues[checkBox].value;
                opcionS.Remove(checkBoxValues[checkBox].text);
            }

            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            // Mostrar el total en el Label
            lblCosto.Text = "$" + totalS.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
        }

        private void btnSigCE1_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaCE_ValueChanged(object sender, EventArgs e)
        {
            fechaS = dtpFechaCE.Value;
        }

        private void dtpHoraCE_ValueChanged(object sender, EventArgs e)
        {
            horaS = dtpHoraCE.Value;
        }

        private void cbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantS = (int)txtCantPersCE.Value;
        }
    }
}