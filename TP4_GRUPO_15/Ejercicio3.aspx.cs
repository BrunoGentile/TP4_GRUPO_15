using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_GRUPO_15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True;";

        private string ConsultaSQL_Temas = "SELECT IdLibro, IdTema, Titulo, Precio, Autor FROM Temas WHERE IdTema = @IdTema";

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlTemas.Items.Add("--Seleccione--");
            ddlTemas.Items.Add("Tema 1");
            ddlTemas.Items.Add("Tema 2");
            ddlTemas.Items.Add("Tema 3");

            if (!IsPostBack)
            {
                //Establecer conexion
                SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
                sqlConnection.Open();

                sqlConnection.Close();

            }
        }
        protected void ddlTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AGREGUE ESTA FUNCION POR QUE SI NO ME DEJABA EJECUTAR EL CODIGO
        }

        protected void lbLibros_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio3b.aspx");
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}
