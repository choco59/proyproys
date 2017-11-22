using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyecto
{
    class conexion
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1; database=proyectofin; Uid=root; pwd=;");
        public MySqlCommandBuilder msqlcmb;
        public DataSet ds = new DataSet();
        public MySqlDataAdapter adaptador;
        public MySqlCommand comando;
        public void Conectar()
        {
            try
            {
                con.Open();
                MessageBox.Show("Conectado con exito");
            }
            catch
            {
                MessageBox.Show("Conectado sin exito");
            }
            finally
            {
                con.Close();
            }

        }

        public bool InsertarDatos(string sql)
        {
            con.Open();
            comando = new MySqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            adaptador = new MySqlDataAdapter(sql, con);
            msqlcmb = new MySqlCommandBuilder(adaptador);
            adaptador.Fill(ds, tabla);


        }
        public bool ActualizarDatos(string tabla, string campos, string condicion)
        {
            con.Open();
            string actuzalizar = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion;
            comando = new MySqlCommand(actuzalizar, con);
            int act = comando.ExecuteNonQuery();
            con.Close();
            if (act > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarDatos(string tabla, string condicion)
        {
            con.Open();
            string eliminar = "DELETE FROM " + tabla + " WHERE " + condicion;
            comando = new MySqlCommand(eliminar, con);
            int eli = comando.ExecuteNonQuery();
            con.Close();
            if (eli > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        }

       
    }

