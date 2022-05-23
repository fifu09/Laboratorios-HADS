using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public class Class1
    {
        static SqlConnection conexion = new SqlConnection();
        public static void conectar()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Probando entrar en DB");
                String connectionString = "Server=tcp:dbd2022-abderraoufkhedidji.database.windows.net,1433;Initial Catalog=dbd;Persist Security Info=False;User ID=fifu09;Password=Besmeleh1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                conexion = new SqlConnection(connectionString);
                conexion.Open();
                System.Diagnostics.Debug.WriteLine("He conectado en la BD");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("No conectado en la BD");
                System.Diagnostics.Debug.WriteLine("{0} Exception caught.", e);
            }
        }
        public static void desconectar()
        {
            try
            {
                conexion.Close();
                System.Diagnostics.Debug.WriteLine("Conexion cerrada");
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("{0} Exception caught.", e);
            }
        }
        public static Boolean registrarUsuario(string email, string nombre, string apellidos, int numConfir, string tipo, string pass)
        {
            Boolean condition;
            int confirmado = 0;
            int codpass = 0;
            SqlCommand comand = new SqlCommand();
            String sql = $"insert into dbo.Usuario values ('{email}','{nombre}','{apellidos}', {numConfir}, {confirmado}, '{tipo}', '{pass}', {codpass})"; ;
            comand = new SqlCommand(sql, conexion);
            //Condicion si el email esta o no en la DB
            if (existeUsuario(email))
            {

                condition = false;
                System.Diagnostics.Debug.WriteLine("Correo existente");
            }
            //Caso de que el email esté en uso
            else
            {
                try
                {
                    comand.ExecuteNonQuery();
                    System.Diagnostics.Debug.WriteLine("Se ha registrado correctamente");
                    condition = true;
                }
                catch (Exception e)
                {
                    condition = false; ;
                    System.Diagnostics.Debug.WriteLine("{0} Exception caught.", e);
                }
            }
            
            return condition;
        }
        public static Boolean existeUsuario(string email)
        {
            SqlCommand comand = new SqlCommand();
            string sql = $"select count(*) from dbo.Usuario where email = '{email}'";
            comand = new SqlCommand(sql, conexion);
            int a = Convert.ToInt32(comand.ExecuteScalar());
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean iniciarSesion(string email, string password)
        {
            SqlCommand comand = new SqlCommand();
            string sql = $"select count(*) from dbo.Usuario where email = '{email}' and pass = '{password}' and confirmado= 1";
            comand = new SqlCommand(sql, conexion);
            int a = Convert.ToInt32(comand.ExecuteScalar());
            if (a == 1)
            {
                System.Diagnostics.Debug.WriteLine("Usuario registrado");
                return true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Usuario no registrado");
                return false;
            }
        }
        public static Boolean enviarMensaje(string to, string subject, string body)
        {
            string from = "akhedidji001@ikasle.ehu.eus";
            MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            message.Body = body;
            SmtpClient SmtpServer = new SmtpClient("smtp.ehu.eus");
            SmtpServer.EnableSsl = true;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("873355", "Besmeleh1");
            try
            {
                SmtpServer.Send(message);
                System.Diagnostics.Debug.WriteLine("Mensaje enviado");
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Mensaje no enviado");
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
                return false;
            }
        }
        public static Boolean verificacion(string email, int numConf)
        {
            SqlCommand comand = new SqlCommand();
            string sql = $"select count(*) from dbo.Usuario where email = '{email}' and numconfir='{numConf}'";
            comand = new SqlCommand(sql, conexion);
            if ((Convert.ToInt32(comand.ExecuteScalar()) == 1))
            {
                sql = $"update dbo.Usuario set confirmado = 1 where email = '{email}'";
                comand = new SqlCommand(sql, conexion);
                comand.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean insertarCodPass(String email, int codpass)
        {
            SqlCommand comand = new SqlCommand();
            string sql = $"update dbo.Usuario set codpass = {codpass} where email = '{email}'";
            comand = new SqlCommand(sql, conexion);
            try
            {
                comand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static Boolean existeCodPass(String email, int codpass)
        {
            SqlCommand comand = new SqlCommand();
            string sql = $"select count(*) from dbo.Usuario where email = '{email}' and codpass= '{codpass}'";
            comand = new SqlCommand(sql, conexion);
            int a = Convert.ToInt32(comand.ExecuteScalar());
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean insertarPasswordNueva(String password, String email)
        {
            SqlCommand comand = new SqlCommand();
            string sql = $"update dbo.Usuario set pass = '{password}' where email = '{email}'";
            comand = new SqlCommand(sql, conexion);
            try
            {
                comand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static String getRol(String email)
        {
            SqlCommand comand = new SqlCommand();
            string sql = $"select tipo from dbo.Usuario where email = '{email}'";
            comand = new SqlCommand(sql, conexion);
            SqlDataReader rol = comand.ExecuteReader();
            if (rol.Read())
            {
                String resultado = rol["tipo"].ToString();
                rol.Close();
                return resultado;
            }
            else
            {
                rol.Close();
                return "Error al buscar el rol";
            }
        }
        public static Boolean existeTarea(String codigo)
        {
            string st = $"select count(*) from dbo.TareaGenerica where Codigo ='{codigo}'";
            SqlCommand comando = new SqlCommand(st, conexion);
            int existe = (Int32)comando.ExecuteScalar();
            if (existe == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static bool insertarTarea(string codigo, string descripcion, string codAsig, int horas, string tipoTarea)
        {
            try
            {
                string sql = $"select * from dbo.TareaGenerica";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexion);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                DataRow dataRow = dataset.Tables[0].NewRow();
                dataRow["Codigo"] = codigo;
                dataRow["Descripcion"] = descripcion;
                dataRow["CodAsig"] = codAsig;
                dataRow["HEstimadas"] = horas;
                dataRow["Explotacion"] = false;
                dataRow["TipoTarea"] = tipoTarea;
                dataset.Tables[0].Rows.Add(dataRow);
                SqlCommandBuilder cb = new SqlCommandBuilder(adapter);

                adapter.Update(dataset);

                return true;
            }
            catch 
            { 
                return false; 
            }

        }
        public static DataSet getInstancias(string email)
        {
            string st = $"select * from dbo.EstudianteTarea where Email = '{email}'";
            SqlDataAdapter adapter = new SqlDataAdapter(st, conexion);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "EstudianteTarea");
            return dataset;
        }
        public static DataTable getTareasGenericas()
        {
            string st = $"select * from dbo.TareaGenerica";
            SqlDataAdapter adapter = new SqlDataAdapter(st, conexion);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "TareaGenerica");
            DataTable data = dataset.Tables["TareaGenerica"];

            return data;
        }
        public static DataTable getAsignaturas(string email)
        {
            string st = $"select codigoAsig from dbo.GrupoClase, dbo.EstudianteGrupo where dbo.GrupoClase.codigo=dbo.EstudianteGrupo.Grupo and dbo.EstudianteGrupo.email='{email}'";
            SqlDataAdapter adapter = new SqlDataAdapter(st, conexion);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "EstudianteTarea");
            DataTable data = dataset.Tables["EstudianteTarea"];
            return data;
        }
        public static bool InstanciarTarea(string email, string codigo, int horasEstimadas, int horasReales, DataSet dataset)
        {
            try
            {
                string st = $"insert into  dbo.EstudianteTarea values('{email}','{codigo}',{horasEstimadas}, {horasReales})";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(st, conexion);
                adapter.InsertCommand.ExecuteNonQuery();
                return true;
            }
            catch 
            { 
                return false; 
            }

        }
    }
}
