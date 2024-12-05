using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MagnoliaEventos.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MagnoliaEventos
{
    public partial class Inicio : Form
    {
        private HttpClient _httpClient;
        public Inicio()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {

            };
        }

        private async void btnNextSesión_Click(object sender, EventArgs e)
        {
            string contra, correo;
            contra = txtContraseña.Text ;
            correo = txtCorreo.Text ;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var resultado = await validar(correo, contra);
                if (resultado != null) {
                    this.cerrarForm;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           

        }

        private void cerrarForm()
        {
            LandingPage landingPage = new LandingPage();
            this.Hide();
            landingPage.Show();
        }

        private async void validar(string correo, string contra)
        {
            var pedir = new
            {
                correo = correo,
                contra = contra
            };

            string json = JsonConverter.Se
        }
    }
}
