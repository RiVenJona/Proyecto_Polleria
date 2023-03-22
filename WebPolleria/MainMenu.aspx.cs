using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPolleria
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.txtSesion.Text = Session["pass"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("~/Index.aspx", true);
        }
    }
}