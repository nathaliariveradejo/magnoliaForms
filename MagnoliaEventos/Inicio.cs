using MagnoliaEventos.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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
                BaseAddress = new Uri("https://localhost:7003/")
            };
        }

        private async void btnNextSesión_Click(object sender, EventArgs e)
        {
            string contra, correo;
            contra = txtContraseña.Text;
            correo = txtCorreo.Text;


            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contra))
            {
                MessageBox.Show("Por favor, ingrese el correo y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HttpResponseMessage response = await _httpClient.GetAsync();

            



        }

        private void cerrarForm()
        {
            LandingPage landingPage = new LandingPage();
            this.Hide();
            landingPage.Show();
        }

    
    }
}
