using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnoliaEventos.API
{
    public class LogInRequest
    {
        public string Correo_Electrónico { get; set; }

        public string Contraseña { get; set; }
    }
}
