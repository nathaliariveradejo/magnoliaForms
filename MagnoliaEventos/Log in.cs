using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnoliaEventos
{
    public partial class Form1 : Form
    {
        private HttpClient _httpClient;
        public Form1()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7003/")
            };
            InitializeComponent();
        }
        
        async private void btnSesión_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }
    }
}
