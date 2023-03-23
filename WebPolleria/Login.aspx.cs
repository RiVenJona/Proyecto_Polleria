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

            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            us = new BL_Usuario();
            if ()
            {

            }
            Response.Redirect("WebForm2.aspx", true);
        }
    }
}