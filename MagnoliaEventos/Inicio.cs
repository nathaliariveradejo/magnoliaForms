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
            var contra = txtContraseña.Text;
            var correo = txtCorreo.Text;
            
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contra))
            {
                var bitacoraRequest = new PostBitacoraRequest
                {
                    Sesion = Form1.ObtenerSesionActual(),
                    Usuario = Form1.ObtenerUsuarioActual(),
                    Mensaje = $"Usuario [{Form1.ObtenerUsuarioActual()}] intentó iniciar sesión sin correo y contraseña."
                };
                HttpResponseMessage responseBitacora = await _httpClient.PostAsJsonAsync("Bitacora", bitacoraRequest);
                MessageBox.Show("Por favor, ingrese el correo y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var logInRequest = new LogInRequest
            {
                Correo_Electrónico = correo,
                Contraseña = contra
            };

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("Auth/LogIn", logInRequest);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Form1.AsignarUsuarioActual(correo);
                var bitacoraRequest = new PostBitacoraRequest
                {
                    Sesion = Form1.ObtenerSesionActual(),
                    Usuario = Form1.ObtenerUsuarioActual(),
                    Mensaje = $"Usuario [{Form1.ObtenerUsuarioActual()}] inició sesión correctamente."
                };
                await _httpClient.PostAsJsonAsync("Bitacora", bitacoraRequest);
                CerrarForm();
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                var bitacoraRequest = new PostBitacoraRequest
                {
                    Sesion = Form1.ObtenerSesionActual(),
                    Usuario = Form1.ObtenerUsuarioActual(),
                    Mensaje = $"Usuario [{Form1.ObtenerUsuarioActual()}] intentó iniciar sesión con una cuenta no existente."
                };
                await _httpClient.PostAsJsonAsync("Bitacora", bitacoraRequest);
                MessageBox.Show("No existe una cuenta con el correo ingresado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                var bitacoraRequest = new PostBitacoraRequest
                {
                    Sesion = Form1.ObtenerSesionActual(),
                    Usuario = Form1.ObtenerUsuarioActual(),
                    Mensaje = $"Usuario [{Form1.ObtenerUsuarioActual()}] intentó iniciar sesión con la contraseña incorrecta."
                };
                await _httpClient.PostAsJsonAsync("Bitacora", bitacoraRequest);
                MessageBox.Show("La contraseña ingresada es incorrecta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Console.Write(response);
        }

        private void CerrarForm()
        {
            LandingPage landingPage = new LandingPage();
            this.Hide();
            landingPage.Show();
        }
    }
}
