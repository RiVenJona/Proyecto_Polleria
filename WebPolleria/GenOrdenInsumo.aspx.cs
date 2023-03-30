using BE_;
using BL_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPolleria
{
    public partial class GenOrdenInsumo : System.Web.UI.Page
    {
        BL_Insumo IN;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TxtJefe.Enabled = false;
                CargarTabla();
            }

        }
        protected void CargarTabla()
        {
            IN = new BL_Insumo();
            GvDatos.DataSource = IN.ListaInsumos();
            GvDatos.DataBind();
        }
        protected void CargarxNombre(string a)
        {
            IN = new BL_Insumo();
            GvDatos.DataSource = IN.ListaInsumosxNombre(a);
            GvDatos.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            IN = new BL_Insumo();
            string a = this.TxtInsumoDesc.Text;
            CargarxNombre(a);
            List<BE_Insumo> Lista = new List<BE_Insumo>();
            Lista = IN.ListaInsumosxNombre(a);
            if (Lista.Count != 0)
            {

            }
            else
            {
                CargarTabla();
                Message("Registro no encontrado.");
            }
        }
        protected void btnIncrementar_Click(object sender, EventArgs e)
        {
            TextBox txtCantGv = (TextBox)(((Button)sender).Parent.FindControl("txtCantGv"));
            int cantidad = int.Parse(txtCantGv.Text);
            cantidad++;
            txtCantGv.Text = cantidad.ToString();
        }

        protected void btnDisminuir_Click(object sender, EventArgs e)
        {
            TextBox txtCantGv = (TextBox)(((Button)sender).Parent.FindControl("txtCantGv"));
            int cantidad = int.Parse(txtCantGv.Text);
            cantidad--;
            txtCantGv.Text = cantidad.ToString();
        }
        public void Message(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<script type = 'text/javascript'>");
            stringBuilder.Append("window.onload=function(){");
            stringBuilder.Append("alert('");
            stringBuilder.Append(str);
            stringBuilder.Append("')};");
            stringBuilder.Append("</script>");
            this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alerta", stringBuilder.ToString());
        }

    }
}