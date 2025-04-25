using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_GRUPO_15
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=DESKTOP-150PF2K\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True;Trust Server Certificate=True";
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack) {
            ddlProducto.Items.Add("Igual a: ");
            ddlProducto.Items.Add("Mayor a: ");
            ddlProducto.Items.Add("Menor a: ");

            ddlCategoria.Items.Add("Igual a: ");
            ddlCategoria.Items.Add("Mayor a: ");
            ddlCategoria.Items.Add("Menor a: ");

            //conexion extablecida
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
            sqlConnection.Open();

            sqlConnection.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}