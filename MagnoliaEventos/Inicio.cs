using MagnoliaEventos.API;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace MagnoliaEventos
{
    public partial class Inicio : Form
    {
        private HttpClient _httpClient;
        public Inicio()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7003/")
            };
            InitializeComponent();
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

            var request = new LogInRequest
            {
                Correo_Electrónico = correo,
                Contraseña = contra
            };

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("Auth/LogIn", request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                this.cerrarForm();
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                MessageBox.Show("No existe una cuenta con el correo ingresado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                MessageBox.Show("La contraseña ingresada es incorrecta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Console.Write(response);
        }

        private void cerrarForm()
        {
            LandingPage landingPage = new LandingPage();
            this.Hide();
            landingPage.Show();
        }
    }
}
