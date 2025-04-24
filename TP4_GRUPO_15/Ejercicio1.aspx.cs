using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace TP4_GRUPO_15
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog = Viajes; Integrated Security = True; TrustServerCertificate=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Establecer conexion
                SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
                sqlConnection.Open();




                sqlConnection.Close();

            }
        }
    }
}