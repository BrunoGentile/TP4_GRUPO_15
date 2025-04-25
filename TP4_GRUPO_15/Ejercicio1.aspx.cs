using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace TP4_GRUPO_15
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private const string cadenaConexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog = Viajes; Integrated Security = True; TrustServerCertificate=True";
        private string ConsultaSQL_Provincias = "SELECT * FROM Provincias";
        private string ConsultaSQL_Localidades = "SELECT * FROM Localidades";

        protected void Page_Load(object sender, EventArgs e)
        {
            
            // this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None; // LO HICE DESDE Web.config

            if (!IsPostBack)
            {
                //Establecer conexion
                SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
                sqlConnection.Open();

                // ESTABLECER CONSULTA CON LA BASE DE DATOS PARA LAS PROVINCIAS
                SqlCommand sqlCommand_Provincias = new SqlCommand(ConsultaSQL_Provincias, sqlConnection);
                SqlDataReader reader_Prov = sqlCommand_Provincias.ExecuteReader();

                reader_Prov.Close(); // CIERRO EL READER PARA PODER ABRIRLO PARA LOCALIDADES

                // ACÁ ABAJO IRÍA LA CARGA DEL DROPDOWNLIST PROVINCIAS

                // ESTABLECER CONSULTA CON LA BASE DE DATOS PARA LAS LOCALIDADES
                SqlCommand sqlCommand_Localidades = new SqlCommand(ConsultaSQL_Localidades, sqlConnection);
                SqlDataReader reader_Loc = sqlCommand_Localidades.ExecuteReader();

                // ACÁ ABAJO IRÍA LA CARGA DEL DROPDOWNLIST LOCALIDADES 

                sqlConnection.Close();

            }
        }
    }
}

