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
            using (MySqlConnection conexion = GetCon())
            {
                int idAgenda = 0;
                MySqlCommand cmd = new MySqlCommand("sp_InsertarAgendaDeContactos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@prm_nombre", MySqlDbType.VarChar).Value = eAgendaDeContactos.nombre;
                cmd.Parameters.Add("@prm_numero", MySqlDbType.VarChar).Value = eAgendaDeContactos.numero;
                conexion.Open();
                idAgenda = Convert.ToInt32(cmd.ExecuteScalar());  
                return idAgenda;
            }
        }

        public DataTable SListaAgendaDeContactos()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("sp_ObtenerAgendaDeContactos", GetCon());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(dt);
            return dt;
        }

        public void UAgendaDeContactos(EAgendaDeContactos eAgendaDeContactos)
        {
            using (MySqlConnection conexion = GetCon())
            {
                MySqlCommand cmd = new MySqlCommand("sp_ActualizarAgendaDeContactos", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("prm_nombre", MySqlDbType.VarChar).Value = eAgendaDeContactos.nombre;
                cmd.Parameters.Add("prm_numero", MySqlDbType.VarChar).Value = eAgendaDeContactos.numero;
                cmd.Parameters.Add("prm_id_agenda_de_contactos", MySqlDbType.Int32).Value = eAgendaDeContactos.id_agenda_de_contactos;
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SAgendaDeContactos(int idAgendaDeContactos)
        {
            
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Buscar_id", GetCon());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@prm_id_agenda_de_contactos", MySqlDbType.Int32).Value = idAgendaDeContactos;
            adapter.Fill(dt);
            return dt;

        }


        public DataTable SListaAgenda_de_contactosBusqueda(string query)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SListaAgenda_de_contactosBusqueda", GetCon());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("query", MySqlDbType.Text).Value = query;
            adapter.Fill(dt);
            return dt;
        }

        

    }
}
