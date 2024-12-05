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
    public partial class Factura : Form
    {

        private int cantP;
        private double precioL, costoSA, total;
        private string tipoE;
       
        public Factura(EventoInfo eventoInfo)
        {
            InitializeComponent();

            tipoE = eventoInfo.TipoEvento;
            lblFecha.Text = eventoInfo.FechaEvento.ToShortDateString();
            lblHora.Text = eventoInfo.HoraEvento.ToShortTimeString();
            cantP = eventoInfo.CantidadPersonas;
            costoSA = eventoInfo.CostoTotal;
            listBoxServicios.Items.AddRange(eventoInfo.Opciones.ToArray());
            lblMétodoPago.Text = eventoInfo.MetodoPago;
            lblDetalleReserva.Text = eventoInfo.Detalles;
            lblLocacion.Text = eventoInfo.Locacion;
            precioL= eventoInfo.PrecioLocacion;
            lblEstado.Text = "En_Espera";
            lblID.Text = eventoInfo.ID_Evento.ToString();

            /*total = costoSA + precioL;
             lblTotal.Text = total.ToString();
             */
        }
    }
}
