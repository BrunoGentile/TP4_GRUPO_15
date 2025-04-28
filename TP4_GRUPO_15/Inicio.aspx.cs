using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_15
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_EJ1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio1.aspx");
        }

        protected void BTN_EJ2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }

        protected void BTN_EJ3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3.aspx");
        }
    }
}