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
        private string ConsultaSQL_Provincias = "SELECT DISTINCT IdProvincia, NombreProvincia FROM Provincias";

        protected void Page_Load(object sender, EventArgs e)
        {
            // this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None; // LO HICE DESDE Web.config

            if (!IsPostBack)
            {
                //Establecer conexion
                SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
                sqlConnection.Open();

                // ESTABLECER CONSULTA CON LA BASE DE DATOS PARA LAS PROVINCIAS
                SqlCommand sqlCommand_Provincias1 = new SqlCommand(ConsultaSQL_Provincias, sqlConnection);
                SqlDataReader reader_Prov1 = sqlCommand_Provincias1.ExecuteReader();

                // ACÁ ABAJO IRÍA LA CARGA DEL DROPDOWNLIST PROVINCIAS
                DDL_Provincia1.DataSource = reader_Prov1;
                DDL_Provincia1.DataTextField = "NombreProvincia";
                DDL_Provincia1.DataValueField = "IdProvincia";
                DDL_Provincia1.DataBind();

                reader_Prov1.Close(); // CIERRO EL READER PARA PODER ABRIRLO PARA LOCALIDADES

                SqlCommand sqlCommand_Provincias2 = new SqlCommand(ConsultaSQL_Provincias, sqlConnection);
                SqlDataReader reader_Prov2 = sqlCommand_Provincias2.ExecuteReader();

                ddlProvinciaFinal.DataSource = reader_Prov2;
                ddlProvinciaFinal.DataTextField = "NombreProvincia";
                ddlProvinciaFinal.DataValueField = "IdProvincia";
                ddlProvinciaFinal.DataBind();

                DDL_Provincia1.Items.Insert(0, new ListItem("--Seleccionar--", ""));
                ddlProvinciaFinal.Items.Insert(0, new ListItem("--Seleccionar--", ""));
                DDL_Localidad1.Items.Insert(0, new ListItem("--Seleccionar--", ""));
                ddlLocalidadFinal.Items.Insert(0, new ListItem("--Seleccionar--", ""));

                reader_Prov2.Close();

                sqlConnection.Close();
            }
        }

        protected void DDL_Provincia1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DDL_Provincia1.SelectedValue))
            {
                int idProvSelected1 = int.Parse(DDL_Provincia1.SelectedValue);

                SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
                sqlConnection.Open();

                string consultaLocalidades = "SELECT IdLocalidad, NombreLocalidad FROM Localidades WHERE IdProvincia = @IdProvincia";
                SqlCommand sqlCommand_Localidades1 = new SqlCommand(consultaLocalidades, sqlConnection);
                sqlCommand_Localidades1.Parameters.AddWithValue("IdProvincia", idProvSelected1);
                SqlDataReader reader_Loc1 = sqlCommand_Localidades1.ExecuteReader();

                // ACÁ ABAJO IRÍA LA CARGA DEL DROPDOWNLIST LOCALIDADES 
                DDL_Localidad1.DataSource = reader_Loc1;
                DDL_Localidad1.DataTextField = "NombreLocalidad";
                DDL_Localidad1.DataValueField = "IdLocalidad";
                DDL_Localidad1.DataBind();
                DDL_Localidad1.Items.Insert(0, new ListItem("--Seleccionar--", ""));

                reader_Loc1.Close();
                sqlConnection.Close();
            }
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlProvinciaFinal.SelectedValue))
            {
                int idProvSelected2 = int.Parse(ddlProvinciaFinal.SelectedValue);

                SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
                sqlConnection.Open();

                string consultaLocalidades = "SELECT IdLocalidad, NombreLocalidad FROM Localidades WHERE IdProvincia = @IdProvincia";
                SqlCommand sqlCommand_Localidades2 = new SqlCommand(consultaLocalidades, sqlConnection);
                sqlCommand_Localidades2.Parameters.AddWithValue("IdProvincia", idProvSelected2);
                SqlDataReader reader_Loc2 = sqlCommand_Localidades2.ExecuteReader();

                ddlLocalidadFinal.DataSource = reader_Loc2;
                ddlLocalidadFinal.DataTextField = "NombreLocalidad";
                ddlLocalidadFinal.DataValueField = "IdLocalidad";
                ddlLocalidadFinal.DataBind();
                ddlLocalidadFinal.Items.Insert(0, new ListItem("--Seleccionar--", ""));

                reader_Loc2.Close();
                sqlConnection.Close();
            }
        }
    }
}
