using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.Design.Serialization;
using System.Text;
using MySqlConnector;

namespace WinMySQL
{
    internal class Datos
    {
        string cadenaConexion = "server=localhost;port=3307;user=edgarjr;pwd=NissanGTR03.;Database=escolar";
        MySqlConnection conexion;

        private void Conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            
        }

        private void Desconectar()
        {
            try
            {
                if (conexion != null)
                    conexion.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desconectar de la base de datos: " + ex.Message);
            }
        }
        public DataSet ejecutar (string comando)
        {
            try
            {
                Conectar();
                MySqlDataAdapter dA = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                dA.Fill(ds);
                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar el comando: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool ejecutarComando(String comando)
        {
            try {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el comando: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }


    }
}
