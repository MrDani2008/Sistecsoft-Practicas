using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Data;

namespace Datos
{
    public class DAgendaDeContactos : Conection
    {
        public int IAgendaDeContactos(EAgendaDeContactos eAgendaDeContactos)
        {
            string IQuery = "INSERT INTO agenda_de_contactos (NOMBRE,NUMERO) VALUES (@nombre,@numero); SELECT last_insert_id();";

            using (MySqlConnection conexion = GetCon())
            {
                int idAgenda = 0;
                MySqlCommand cmd = new MySqlCommand(IQuery, conexion);
                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = eAgendaDeContactos.nombre;
                cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = eAgendaDeContactos.numero;
                conexion.Open();
                int.TryParse(cmd.ExecuteScalar().ToString(), out idAgenda);

                return idAgenda;
            }
        }

        public DataTable SListaAgendaDeContactos()
        {
            string query = "SELECT * FROM agenda_de_contactos;";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, GetCon());
            adapter.Fill(dt);
            return dt;
        }

        public void UAgendaDeContactos(EAgendaDeContactos eAgendaDeContactos)
        {
            string query = "UPDATE agenda_de_contactos SET NOMBRE = @nombre, NUMERO = @numero WHERE id_agenda_de_contactos = @id;";

            using (MySqlConnection conexion = GetCon())
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = eAgendaDeContactos.nombre;
                cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = eAgendaDeContactos.numero;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = eAgendaDeContactos.id_agenda_de_contactos;

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SAgendaDeContactos(int idAgendaDeContactos)
        {
            string query = "SELECT * FROM agenda_de_contactos WHERE id_agenda_de_contactos = @prm_id_agenda_de_contactos;";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, GetCon());
            adapter.SelectCommand.Parameters.Add("@prm_id_agenda_de_contactos", MySqlDbType.Int32).Value = idAgendaDeContactos;
            adapter.Fill(dt);
            return dt;
        }

        public DataTable EjecutarBusqueda(string query)
        {
            // Crear la conexión a la base de datos
            using (MySqlConnection conexion = GetCon())
            {
                // Abrir la conexión
                conexion.Open();

                // Crear el comando para ejecutar el procedimiento almacenado
                MySqlCommand cmd = new MySqlCommand("Busqueda_De_Contactos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro 'query' al procedimiento
                cmd.Parameters.AddWithValue("query", query);

                // Crear un DataAdapter para llenar el DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;


            }
        }

    }
}
