using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL_;
using BE_;

namespace WebPolleria
{
	public partial class RecepcionarCliente : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                LlenarListaMesas();
                LlenarListaHorarios();
            }
		}

        protected void LlenarListaMesas()
        {      
                List<BE_Mesa> mesas = new List<BE_Mesa>();
                BL_Mesa m = new BL_Mesa();
                mesas = m.BL_ListaMesas();
                DropDownListMesas.DataSource = mesas;
                DropDownListMesas.DataTextField = "IdMesa";
                DropDownListMesas.DataValueField = "IdMesa";
                DropDownListMesas.DataBind();
                DropDownListMesas.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione una Mesa]", "0"));
                
        }
        protected void LlenarListaHorarios()
        {
            List<BE_Horario> horarios= new List<BE_Horario>();
            BL_Horario h = new BL_Horario();
            horarios = h.BL_ListaHorarios();
            DropDownListHorarios.DataSource = horarios;
            DropDownListHorarios.DataTextField = "DescHorario";
            DropDownListHorarios.DataValueField = "IdHorario";
            DropDownListHorarios.DataBind();
            DropDownListHorarios.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione un horario]", "0"));

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BtnBuscarRes_Click(object sender, EventArgs e)
        {

        }
    }
}