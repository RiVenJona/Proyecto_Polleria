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
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarPag();
        }
        protected void CargarPag() 
        {
            BL_Usuario us = new BL_Usuario();
            this.GridView1.DataSource = us.BL_Lista();
            this.GridView1.DataBind();
        }
    }
}