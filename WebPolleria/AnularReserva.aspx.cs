using BL_;
using BE_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPolleria
{
    public partial class AnularReserva : System.Web.UI.Page
    {
        BL_OrdenReserva or;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            or = new BL_OrdenReserva();
            string a = this.TxtNro.Text;
            CargarDatos(a);
            List<BE_OrdenReserva> Lista = new List<BE_OrdenReserva>();
            Lista = or.BL_Reserva(a);
            foreach (var lis in Lista)
            {
                this.TxtEstado.Text = lis.EstadoOrden;
            }
        }
        protected void CargarDatos(string a)
        {
            or = new BL_OrdenReserva();
            this.GrdReserva.DataSource = or.BL_Reserva(a);
            this.GrdReserva.DataBind();
        }
    }
}