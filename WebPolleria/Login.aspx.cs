using System;
using BL_;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BCrypt.Net;
using System.Text;

namespace WebPolleria
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BL_Usuario us;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void CargarPag(string a, string b) 
        {

            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            us = new BL_Usuario();
            string usuario = this.txtUser.Text;
            string password = BCrypt.Net.BCrypt.HashPassword(txtPass.Text,8);
            Message(password.ToString());
            if (BCrypt.Net.BCrypt.Verify(password,us.BL_Validacion(usuario)))
            {
                Message("Bienvenido, si esta creado");
            }
            //Response.Redirect("WebForm2.aspx", true);
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