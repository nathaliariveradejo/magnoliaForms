using System;
using System.Windows.Forms;

namespace MagnoliaEventos
{
    public partial class Form1 : Form
    {
        private static string _sesion;
        private static string _usuario = "Invitado";

        public Form1()
        {
            GenerarSesion();
            InitializeComponent();
        }

        private static void GenerarSesion()
        {
            _sesion = Guid.NewGuid().ToString();
        }

        public static string ObtenerSesionActual()
        {
            return _sesion;
        }

        public static void AsignarUsuarioActual(string usuario)
        {
            _usuario = usuario;
        }

        public static string ObtenerUsuarioActual()
        {
            return _usuario;
        }
        
        private void btnSesión_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            Hide();
            inicio.Show();
        }
    }
}
