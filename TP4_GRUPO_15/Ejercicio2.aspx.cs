using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace TP4_GRUPO_15
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog = Neptuno; Integrated Security = True; TrustServerCertificate=True";
        private string ConsultaSQL_IdProducto = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";


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

                SqlCommand sqlCommand = new SqlCommand(ConsultaSQL_IdProducto, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            
                // CARGA DE DATOS AL GRID VIEW
                gvProductos.DataSource = sqlDataReader;
                gvProductos.DataBind();

                sqlConnection.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoria.Text) && string.IsNullOrEmpty(txtProducto.Text))
            {
              string ConsultaSQL_IdCategoria = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos WHERE IdCategoría = @IdCategoría" ;
                SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
                sqlConnection.Open();

                SqlCommand sqlCommand_Categoria = new SqlCommand(ConsultaSQL_IdCategoria, sqlConnection);
                sqlCommand_Categoria.Parameters.AddWithValue("@IdCategoría", Convert.ToInt32(txtCategoria.Text));

                SqlDataReader sqlDataReader = sqlCommand_Categoria.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    gvProductos.DataSource = sqlDataReader;
                    gvProductos.DataBind();
                    lblMensaje.Visible = false;
                }
                else
                {
                    gvProductos.DataSource = null;
                    gvProductos.DataBind();
                    lblMensaje.Text = "No se encontraron productos para esta categoría.";
                    lblMensaje.Visible = true;
                }

                

                sqlConnection.Close();
            }
        }
    }
}