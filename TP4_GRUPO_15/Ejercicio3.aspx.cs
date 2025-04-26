using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_GRUPO_15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=DESKTOP-8RCUNNO\SQLEXPRESS;Initial Catalog = Libreria; Integrated Security = True; Encrypt=True;Trust Server Certificate=True";

        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
