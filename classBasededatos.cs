using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trabajopracticointegrador2
{
    internal class classBasededatos
    {
        OleDbConnection Conexion = new OleDbConnection();
        OleDbCommand Comando = new OleDbCommand();
        OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        OleDbDataReader lectorBD;
        DataSet objDS = new DataSet();
        string estadoConexion;


        string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=BDusuarios.accdb";
        public void conectarBD()
        {
            try
            {
                Conexion.ConnectionString = varCadenaConexion;

                Conexion.Open();
                Comando.Connection = Conexion;

              
                Conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Conexion.Close();
            }



        }
        public void guardar(string NOMBRE, string contraseña)
        {

            Conexion.ConnectionString = varCadenaConexion;

            Conexion.Open();
            try
            {


                Comando = new OleDbCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = $"INSERT INTO Usuario (Nombre, Contraseña) VALUES ('{NOMBRE}', {contraseña})";
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Sus registros se guardaron correctamente.");

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error al intentar guardar los datos.");

                throw ex;
            }




        }
        public void RegistroLogInicioSesion()
        {
            Conexion.ConnectionString = varCadenaConexion;

            Conexion.Open();
            try
            {
                
                OleDbCommand comandoBD = new OleDbCommand();
                OleDbConnection conexionBD = new OleDbConnection(varCadenaConexion);
                DataSet objDS = new DataSet();
                OleDbDataAdapter adaptadorBD;

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.Text;
                comandoBD.CommandText = "INSERT INTO Logs (Categoria, FechaHora, Descripcion) VALUES (?, ?, ?)";

                comandoBD.Parameters.AddWithValue("@Categoria", "Inicio Sesión");
                comandoBD.Parameters.AddWithValue("@FechaHora", DateTime.Now);
                comandoBD.Parameters.AddWithValue("@Descripcion", "Inicio exitoso");

               
                comandoBD.ExecuteNonQuery();
                conexionBD.Close();

                estadoConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }


        public void RegistroLogInicioSesion2()
        {
            Conexion.ConnectionString = varCadenaConexion;

            Conexion.Open();
            try
            {
                Comando = new OleDbCommand();

                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.TableDirect;
                Comando.CommandText = "Logs";

                Adaptador = new OleDbDataAdapter(Comando);

                Adaptador.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(Adaptador);
                Adaptador.Update(objDS, "Logs");

                estadoConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }

        }








    }
} 

