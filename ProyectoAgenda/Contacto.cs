using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoAgenda
{
    public class Contacto
    {
        private readonly string connectionString;
     
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Contacto()
        {
            connectionString = "Server= localhost; DataBase=AgendaDB; Trusted_Connection=True;";
        }

        public void AgregarContacto()
        {
                string query = "insert into Contactos (Nombre, Email, Telefono, FechaRegistro, Activo) values (@Nombre, @Email, @Telefono, GetDate(), 1) ";
                SqlConnection sqlconnection = new SqlConnection(connectionString);  
                SqlCommand sqlCommand = new SqlCommand (query, sqlconnection);
            try
            {
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Nombre", Nombre);
                sqlCommand.Parameters.AddWithValue("@Email", Email);
                sqlCommand.Parameters.AddWithValue("@Telefono", Telefono);
                sqlconnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlconnection.Close();  
                sqlconnection.Dispose();    
            }

        }
    }
}
