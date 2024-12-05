using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MagnoliaEventos
{
    public partial class CrearEvento : Form
    {
        private DateTime fechaS;
        private DateTime horaS;
        private Dictionary<CheckBox, (int value, string text)> checkBoxValues;
        private int totalS;
        private List<string> opcionS;
        private int cantS;
        private int precioS;
        private string tipoS;
        private string detalles;
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

            btnSig.Click += new EventHandler(btnSig_Click);

            foreach (var checkBox in checkBoxValues.Keys)
            {
                checkBox.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            }

            cantS = 0;
            totalS = 0;
            opcionS = new List<string>();
            UpdateTotalLabel();

        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Obtener el CheckBox que disparó el evento
            CheckBox checkBox = sender as CheckBox;

            // Verificar si el CheckBox está seleccionado o deseleccionado
            if (checkBox.Checked)
            {
                // Sumar el valor del CheckBox al total
                totalS += checkBoxValues[checkBox].value;
                // Agregar el texto del CheckBox a la lista
                opcionS.Add(checkBoxValues[checkBox].text);
            }
            else
            {
                // Restar el valor del CheckBox del total
                totalS -= checkBoxValues[checkBox].value;
                // Eliminar el texto del CheckBox de la lista
                opcionS.Remove(checkBoxValues[checkBox].text);
            }

            // Actualizar el Label con el nuevo total

            UpdateTotalLabel();
        }

        
        private void UpdateTotalLabel()
        {
            // Mostrar el total en el Label
            lblCosto.Text = "$" + totalS.ToString();
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            ReportePE form9 = new ReportePE();
            form9.Show();
            this.Close();
        }

        private void btnInicioC_Click(object sender, EventArgs e)
        {
            LandingPage form8 = new LandingPage();
            form8.Show();
            this.Close();
        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            Editar form7 = new Editar();
            form7.Show();
            this.Close();
        }

        private void btnVerC_Click(object sender, EventArgs e)
        {
            Visualizar form6 = new Visualizar();
            form6.Show();
            this.Close();
        }

        private void dtpFechaCE_ValueChanged(object sender, EventArgs e)
        {
            fechaS = dtpFechaCE.Value;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            fechaS = dtpFechaCE.Value;
            horaS = dtpHoraCE.Value;
            tipoS = cbEventType.SelectedItem?.ToString();
            fechaS = dtpFechaCE.Value;
            cantS = (int)txtCantPersCE.Value;
            detalles = txtDetallesCE.Text;
            precioS = totalS;
        }  

        private void cbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantPersCE_ValueChanged(object sender, EventArgs e)
        {
            cantS = (int)txtCantPersCE.Value;
        }

        private void dtpHoraCE_ValueChanged(object sender, EventArgs e)
        {
            horaS = dtpHoraCE.Value;
        }

        private void txtDetallesCE_TextChanged(object sender, EventArgs e)
        {
            detalles = txtDetallesCE.Text;
        }
    }
}
