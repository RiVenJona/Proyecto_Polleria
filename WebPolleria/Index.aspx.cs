using System;
using BL_;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            us = new BL_Usuario();
            this.GridView1.DataSource = us.BL_Lista(a, b);
            this.GridView1.DataBind();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            us = new BL_Usuario();
            string user = this.txtUser.Text;
            string pass = this.txtPass.Text;
            CargarPag(user,pass);
            this.txtUser.Text = string.Empty;
            this.txtPass.Text = string.Empty;
            Session["user"] = user;
            Session["pass"] = pass;
            if (us.Entrar())
            {
                Response.Redirect("~/MainMenu.aspx", true);
            }
            
        }

        protected void btnCambio_Click(object sender, EventArgs e)
        {
            
        }
    }
}