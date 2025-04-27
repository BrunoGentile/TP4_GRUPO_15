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
        private const string cadenaConexion = @"Data Source=DESKTOP-8rcunno\SQLEXPRESS;Initial Catalog=Viajes;Integrated Security=True;TrustServerCertificate=True";
        private string ConsultaSQL_Provincias = "SELECT * FROM provincias";
       
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None; // LO HICE DESDE Web.config

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
            ValidarProvincias();
        }

        protected void btnRestablecerSelecciones_Click(object sender, EventArgs e)
        {
            // Volver a seleccionar el primer ítem (por ejemplo, "Seleccione una provincia...")
            DDL_Provincia1.SelectedIndex = 0;
            DDL_Localidad1.SelectedIndex = 0;
            ddlProvinciaFinal.SelectedIndex = 0;
            ddlLocalidadFinal.SelectedIndex = 0;
            lblDistancia.Text = "";
        }

        private string CalcularDistancia(string origen, string destino)
        {
            var distancias = new Dictionary<(string, string), int>()
    {
        // Buenos Aires - Entre Ríos
        { ("Campana", "Colon"), 250 },
        { ("Campana", "Concordia"), 400 },
        { ("Campana", "Gualeguay"), 320 },
        { ("Campana", "Gualeguaychu"), 280 },
        { ("Pacheco", "Colon"), 260 },
        { ("Pacheco", "Concordia"), 410 },
        { ("Pacheco", "Gualeguay"), 330 },
        { ("Pacheco", "Gualeguaychu"), 290 },
        { ("Retiro", "Colon"), 240 },
        { ("Retiro", "Concordia"), 390 },
        { ("Retiro", "Gualeguay"), 310 },
        { ("Retiro", "Gualeguaychu"), 270 },
        { ("San isidro", "Colon"), 250 },
        { ("San isidro", "Concordia"), 400 },
        { ("San isidro", "Gualeguay"), 320 },
        { ("San isidro", "Gualeguaychu"), 280 },

        // Buenos Aires - Santa Fe
        { ("Campana", "Arocena"), 380 },
        { ("Campana", "Rafaela"), 480 },
        { ("Campana", "Rosario"), 310 },
        { ("Pacheco", "Arocena"), 390 },
        { ("Pacheco", "Rafaela"), 490 },
        { ("Pacheco", "Rosario"), 320 },
        { ("Retiro", "Arocena"), 370 },
        { ("Retiro", "Rafaela"), 470 },
        { ("Retiro", "Rosario"), 300 },
        { ("San isidro", "Arocena"), 380 },
        { ("San isidro", "Rafaela"), 480 },
        { ("San isidro", "Rosario"), 310 },

        // Entre Ríos - Santa Fe
        { ("Colon", "Arocena"), 220 },
        { ("Colon", "Rafaela"), 320 },
        { ("Colon", "Rosario"), 180 },
        { ("Concordia", "Arocena"), 340 },
        { ("Concordia", "Rafaela"), 440 },
        { ("Concordia", "Rosario"), 300 },
        { ("Gualeguay", "Arocena"), 260 },
        { ("Gualeguay", "Rafaela"), 360 },
        { ("Gualeguay", "Rosario"), 220 },
        { ("Gualeguaychu", "Arocena"), 280 },
        { ("Gualeguaychu", "Rafaela"), 380 },
        { ("Gualeguaychu", "Rosario"), 240 }
    };

            if (distancias.ContainsKey((origen, destino)))
            {
                return $"La distancia entre {origen} y {destino} es de {distancias[(origen, destino)]} km.";
            }
            else if (distancias.ContainsKey((destino, origen)))
            {
                return $"La distancia entre {origen} y {destino} es de {distancias[(destino, origen)]} km.";
            }
            else
            {
                return "No se encontró la distancia entre esas localidades.";
            }
        }

        private string CalcularPrecios(string origen, string destino)
        {
            var Precios = new Dictionary<(string, string), int>()
    {
        // Buenos Aires - Entre Ríos
        { ("Campana", "Colon"), 250*200 },
        { ("Campana", "Concordia"), 400 * 200 },
        { ("Campana", "Gualeguay"), 320 * 200 },
        { ("Campana", "Gualeguaychu"), 280 * 200 },
        { ("Pacheco", "Colon"), 260 * 200 },
        { ("Pacheco", "Concordia"), 410 * 200 },
        { ("Pacheco", "Gualeguay"), 330 * 200 },
        { ("Pacheco", "Gualeguaychu"), 290 * 200 },
        { ("Retiro", "Colon"), 240 * 200 },
        { ("Retiro", "Concordia"), 390 * 200 },
        { ("Retiro", "Gualeguay"), 310 * 200 },
        { ("Retiro", "Gualeguaychu"), 270 * 200 },
        { ("San isidro", "Colon"), 250 * 200 },
        { ("San isidro", "Concordia"), 400 * 200 },
        { ("San isidro", "Gualeguay"), 320 * 200 },
        { ("San isidro", "Gualeguaychu"), 280 * 200 },

        // Buenos Aires - Santa Fe
        { ("Campana", "Arocena"), 380*200 },
        { ("Campana", "Rafaela"), 480*200 },
        { ("Campana", "Rosario"), 310*200 },
        { ("Pacheco", "Arocena"), 390*200 },
        { ("Pacheco", "Rafaela"), 490*200 },
        { ("Pacheco", "Rosario"), 320*200 },
        { ("Retiro", "Arocena"), 370*200 },
        { ("Retiro", "Rafaela"), 470*200 },
        { ("Retiro", "Rosario"), 300*200 },
        { ("San isidro", "Arocena"), 380*200 },
        { ("San isidro", "Rafaela"), 480*200 },
        { ("San isidro", "Rosario"), 310*200 },

        // Entre Ríos - Santa Fe
        { ("Colon", "Arocena"), 220*200 },
        { ("Colon", "Rafaela"), 320*200 },
        { ("Colon", "Rosario"), 180*200 },
        { ("Concordia", "Arocena"), 340*200 },
        { ("Concordia", "Rafaela"), 440*200 },
        { ("Concordia", "Rosario"), 300*200 },
        { ("Gualeguay", "Arocena"), 260 * 200 },
        { ("Gualeguay", "Rafaela"), 360 * 200 },
        { ("Gualeguay", "Rosario"), 220 * 200 },
        { ("Gualeguaychu", "Arocena"), 280 * 200  },
        { ("Gualeguaychu", "Rafaela"), 380 * 200 },
        { ("Gualeguaychu", "Rosario"), 240 * 200 }
    };
            if (Precios.ContainsKey((origen, destino)))
            {
                return $"El precio estimado de su vuelo es de ${Precios[(origen, destino)]} pesos argentinos.";
            }
            else if (Precios.ContainsKey((destino, origen)))
            {
                return $"El precio estimado de su vuelo es de ${Precios[(origen, destino)]} pesos argentinos.";
            }
            else
            {
                return "No se encontró el precio del vuelo requerido.";
            }
        }

        protected void ddlLocalidadFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlLocalidadFinal.SelectedValue))
            {
                lblDistancia.Text = CalcularDistancia(DDL_Localidad1.SelectedItem.ToString(),ddlLocalidadFinal.SelectedItem.ToString());
                lblPrecios.Text = CalcularPrecios(DDL_Localidad1.SelectedItem.ToString(), ddlLocalidadFinal.SelectedItem.ToString());
            }
        }

        protected void DDL_Localidad1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DDL_Localidad1.SelectedValue) && !string.IsNullOrEmpty(ddlLocalidadFinal.SelectedValue))
            {
                lblDistancia.Text = CalcularDistancia(DDL_Localidad1.SelectedItem.ToString(), ddlLocalidadFinal.SelectedItem.ToString());
                lblPrecios.Text = CalcularPrecios(DDL_Localidad1.SelectedItem.ToString(), ddlLocalidadFinal.SelectedItem.ToString());
            }
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        private void ValidarProvincias()
        {
            if (!string.IsNullOrEmpty(DDL_Provincia1.SelectedValue) &&
                DDL_Provincia1.SelectedValue == ddlProvinciaFinal.SelectedValue)
            {
                lblMensaje.Text = "No puedes seleccionar la misma provincia en ambos campos.";
                ddlProvinciaFinal.SelectedIndex = 0; // Resetea la selección del final si son iguales
            }
            else
            {
                lblMensaje.Text = "";
            }
        }


    }
}


  

       
        
    

