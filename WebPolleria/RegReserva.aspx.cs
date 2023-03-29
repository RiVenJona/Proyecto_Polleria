using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL_;
using BE_;
using System.Text;

namespace WebPolleria
{
    public partial class RegReserva : System.Web.UI.Page
    {
        BL_Horario HR;
        BL_Persona PE;
        protected void Page_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            CargarTabla();
        }
        protected void Habilitar()
        {
            TxtNombre.Enabled = true;
            TxtApellidos.Enabled = true;
            TxtCorreo.Enabled = true;
            TxtDireccion.Enabled = true;
            TxtDni.Enabled = true;
            TxtTelefono.Enabled = true;
        }
        protected void Deshabilitar()
        {
            TxtNombre.Enabled = false;
            TxtApellidos.Enabled = false;
            TxtCorreo.Enabled = false;
            TxtDireccion.Enabled = false;
            TxtDni.Enabled = false;
            TxtTelefono.Enabled = false;
        }
        protected void CargarTabla()
        {
            HR = new BL_Horario();
            GvHorario.DataSource = HR.BL_ListaHorarios();
            GvHorario.DataBind();
        }

        protected void BtnDni_Click(object sender, EventArgs e)
        {
            PE = new BL_Persona();
            List<BE_Persona> Lista = new List<BE_Persona>();
            int a = int.Parse(TxtBDni.Text);
            Lista = PE.BL_RegPersona(a);
            if (Lista != null)
            {
                foreach (var lis in Lista)
                {
                    TxtNombre.Text = lis.Nombre;
                    TxtApellidos.Text = lis.Apellidos;
                    TxtDireccion.Text = lis.Direccion;
                    TxtDni.Text = lis.DNI.ToString();
                    TxtTelefono.Text = lis.Telefono.ToString();
                    TxtCorreo.Text = lis.Correo;
                }
                Deshabilitar();
            }
            else
            {
                Message("Persona no encontrada, puede proceder a registrarla");
                Habilitar();
            } 
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