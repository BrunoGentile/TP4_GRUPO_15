using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Messaging;

namespace TP4_GRUPO_15
{
    public partial class Ejercicio3b : System.Web.UI.Page
    {

        private const string CadenaConexion = @"Data Source=Localhost\SQLEXPRESS;Initial Catalog = Libreria; Integrated Security = True;";

        // FUNCIÓN QUE ME DEVUELVE EL TEMA SELECCIONADO
        protected int TemaSeleccionado(string StringTema)
        {
            int Tema = 0;

            switch (StringTema)
            {
                case "Tema 1": Tema = 1; break;
                case "Tema 2": Tema = 2; break;
                case "Tema 3": Tema = 3; break;
            }

            return Tema;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if ( !IsPostBack )
            {
                string Tema = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedItem.Text;
                bool ordenar = ((CheckBox)PreviousPage.FindControl("cbPrecios")).Checked;
                string ConsultaSQL = "SELECT * FROM Libros WHERE IdTema = @Tema";
                if (ordenar)
                {
                    ConsultaSQL = "SELECT * FROM Libros WHERE IdTema = @Tema ORDER BY Precio DESC";
                }
                    // ESTABLEZCO CONEXIÓN
                SqlConnection sqlConnection = new SqlConnection(CadenaConexion);
                sqlConnection.Open();
                // ESTABLECER CONSULTA CON LA BASE DE DATOS
                SqlCommand SQLCommand = new SqlCommand(ConsultaSQL, sqlConnection);
                
                SQLCommand.Parameters.AddWithValue("@Tema", TemaSeleccionado(Tema));
                SqlDataReader READER = SQLCommand.ExecuteReader();

                if ( READER.HasRows )
                {
                    gvLibros.DataSource = READER;
                    gvLibros.DataBind();
                }

                string CantRegistros = gvLibros.Rows.Count.ToString();
                lblListado.Text += " Se encontraron " + CantRegistros + " registros del " + Tema;

                sqlConnection.Close();

            }
        }

        protected void lbConsultaTema_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3.aspx");
        }
    }
}