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
        BL_Persona PE;
        protected void Page_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            if (!Page.IsPostBack)
            {
                LlenarListaHorarios();
                LlenarListaMesas();
                this.RegCliente.Visible = false;
                this.BtnRegistrar.Visible = false;
            }
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
        

        protected void BtnDni_Click(object sender, EventArgs e)
        {
            PE = new BL_Persona();
            List<BE_Persona> Lista = new List<BE_Persona>();
            int a = int.Parse(TxtBDni.Text);
            Lista = PE.BL_RegPersona(a);
            if (Lista.Count != 0)
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
                Message("Persona encontrada");
                Deshabilitar();
                this.BtnRegistrar.Visible = true;
            }
            else
            {
                Message("Persona no encontrada, puede proceder a registrarla");
                Habilitar();
                this.RegCliente.Visible = true;
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
        protected void LlenarListaHorarios()
        {
            List<BE_Horario> horarios = new List<BE_Horario>();
            BL_Horario h = new BL_Horario();
            horarios = h.BL_ListaHorarios();
            DpDown1.DataSource = horarios;
            DpDown1.DataTextField = "DescHorario";
            DpDown1.DataValueField = "IdHorario";
            DpDown1.DataBind();
            DpDown1.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione un horario]", "0"));
        }
        protected void LlenarListaMesas()
        {
            List<BE_Mesa> mesas = new List<BE_Mesa>();
            BL_Mesa m = new BL_Mesa();
            mesas = m.BL_ListaMesas();
            DpDown2.DataSource = mesas;
            DpDown2.DataTextField = "IdMesa";
            DpDown2.DataValueField = "IdMesa";
            DpDown2.DataBind();
            DpDown2.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione una Mesa]", "0"));

        }
        protected void DpDown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DpDown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RegCliente_Click(object sender, EventArgs e)
        {
            PE = new BL_Persona();
            string Nombre = TxtNombre.Text;
            string Apellidos = TxtApellidos.Text;
            string Correo = TxtCorreo.Text;
            int Telefono = int.Parse(TxtTelefono.Text);
            string Direccion = TxtDireccion.Text;
            int DNI = int.Parse(TxtDni.Text);

            if (TxtDni.Text != String.Empty)
            {
                if (PE.BL_RegisPersona(Nombre, Apellidos, Correo, Telefono, Direccion, DNI))
                {
                    Message("Se registro el correctamente");
                }
                else
                {
                    Message("Error al registrar");
                }
            }
            else
            {
                Message("Ingrese Nro de DNI");
            }
            this.RegCliente.Visible = false;
            this.BtnRegistrar.Visible = true;
        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            BL_OrdenReserva RE = new BL_OrdenReserva();
            int mesa = int.Parse(this.DpDown1.SelectedValue);
            DateTime fecha = DateTime.Parse(this.TxtFecha.Text);
            int hora = int.Parse(this.DpDown2.SelectedValue);
            int tra = 1;
            int dni = int.Parse(this.TxtBDni.Text);
            RE.BL_RegistrarReserva(mesa, fecha, hora, tra, dni);
        }
    }
}