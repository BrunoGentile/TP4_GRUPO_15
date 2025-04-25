using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlTemas.Items.Add("Tema 1");
            ddlTemas.Items.Add("Tema 2");
            ddlTemas.Items.Add("Tema 3");
        }

        protected System.Void Page_Load(System.Object sender, System.EventArgs e)
        {

        }
    }
}