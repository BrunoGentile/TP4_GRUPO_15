using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace TP4_GRUPO_15
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog = Neptuno; Integrated Security = True; TrustServerCertificate=True";
        private string ConsultaSQL_IdProducto = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";


        // ---------- FUNCIONES PARA FILTRAR LA TABLA POR PRODUCTO ----------

        protected void FiltrarPorProducto()
        {
            string ConsultaSQL_IdProducto = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos WHERE IdProducto = @IdProducto";
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
            sqlConnection.Open();

            SqlCommand sqlCommand_Producto = new SqlCommand(ConsultaSQL_IdProducto, sqlConnection);
            sqlCommand_Producto.Parameters.AddWithValue("@IdProducto", Convert.ToInt32(txtProducto.Text));

            SqlDataReader sqlDataReader = sqlCommand_Producto.ExecuteReader();

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
                lblMensaje.Text = "No se encontraron productos con ese ID.";
                lblMensaje.Visible = true;
            }

            sqlConnection.Close();
        }

        // ---------- FIN FUNCIONES FILTRAR TABLA POR PRODUCTO ----------

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

        private bool ExisteProducto(int idProducto)
        {
            bool existe = false;

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                string consultaProducto = "SELECT COUNT(*) FROM Productos WHERE IdProducto = @IdProducto";
                SqlCommand sqlCommand = new SqlCommand(consultaProducto, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@IdProducto", idProducto);

                sqlConnection.Open();
                int cantidad = (int)sqlCommand.ExecuteScalar();
                existe = cantidad > 0;
            }

            return existe;
        }

        private bool ExisteCategoria(int idCategoria)
        {
            bool existe = false;

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                string consultaCategoria = "SELECT COUNT(*) FROM Categorías WHERE IdCategoría = @IdCategoría";
                SqlCommand sqlCommand = new SqlCommand(consultaCategoria, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@IdCategoría", idCategoria);

                sqlConnection.Open();
                int cantidad = (int)sqlCommand.ExecuteScalar();
                existe = cantidad > 0;
            }

            return existe;
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblIdProducto.Text = "";
            lblIdCategoria.Text = "";

            int idProducto;
            int idCategoria;

            bool hayProducto = int.TryParse(txtProducto.Text, out idProducto);
            bool hayCategoria = int.TryParse(txtCategoria.Text, out idCategoria);

            /// VERIFICACIÓN POR SI NO EXISTE PRODUCTO O CATEGORÍA CON EL ID INTRODUCIDO
            if (hayProducto && !ExisteProducto(idProducto))
            {
                lblIdProducto.Text = "No existe un producto con ese ID.";
                return;
            }
            if (hayCategoria && !ExisteCategoria(idCategoria))
            {
                lblIdCategoria.Text = "No existe una categoría con ese ID.";
                return;
            }

            string consultaSQL = "SELECT * FROM Productos WHERE 1=1";

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                // Diccionario de operadores
                var operadores = new Dictionary<string, string>
            {
            { "Igual a: ", "=" },
            { "Menor a: ", "<" },
            { "Mayor a: ", ">" }
            };

                // Producto
                if (!string.IsNullOrEmpty(txtProducto.Text))
                {
                    string operadorProducto = operadores[ddlProducto.SelectedItem.ToString()];
                    consultaSQL += $" AND IdProducto {operadorProducto} @IdProducto";
                    sqlCommand.Parameters.AddWithValue("@IdProducto", Convert.ToInt32(txtProducto.Text));
                }

                // Categoría
                if (!string.IsNullOrEmpty(txtCategoria.Text))
                {
                    string operadorCategoria = operadores[ddlCategoria.SelectedItem.ToString()];
                    consultaSQL += $" AND IdCategoría {operadorCategoria} @IdCategoria";
                    sqlCommand.Parameters.AddWithValue("@IdCategoria", Convert.ToInt32(txtCategoria.Text));
                }


            sqlCommand.CommandText = consultaSQL;
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

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
                lblMensaje.Text = "No se encontraron productos con los filtros aplicados.";
                lblMensaje.Visible = true;
            }

            }
            

            txtProducto.Text = string.Empty;
            txtCategoria.Text = string.Empty;
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            // REINICIO DE LOS TEXTBOX
            txtProducto.Text = string.Empty;
            txtCategoria.Text = string.Empty;

            // REINICIO DE LOS DDL
            ddlProducto.SelectedIndex = 0;
            ddlCategoria.SelectedIndex = 0;

            // REINICIO GRIDVIEW
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ConsultaSQL_IdProducto, sqlConnection);

            // CREO UNA INSTANCIA NUEVA DE LA CLASE DataSet
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "TablaProducto");

            // ASIGNAR LA TABLA DE DATOS COMO ORIGEN DE DATOS DEL GRIDVIEW
            gvProductos.DataSource = ds.Tables["TablaProducto"];
            gvProductos.DataBind();

            sqlConnection.Close();

            txtProducto.Text = string.Empty;
            txtCategoria.Text = string.Empty;
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}