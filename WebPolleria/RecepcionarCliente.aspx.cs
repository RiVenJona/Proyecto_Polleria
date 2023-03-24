using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPolleria
{
	public partial class RecepcionarCliente : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                Llenar();
            }
		}

        protected void Llenar()
        {
            {
                try
                {
                    DropDownListMesas.DataSource = ConsultarProyecto();
                    DropDownListMesas.DataTextField = "DESCRIPCION";
                    DropDownListMesas.DataValueField = "CODIGO";
                    DropDownListMesas.DataBind();
                    DropDownListMesas.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccione un proyecto", "0"));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}