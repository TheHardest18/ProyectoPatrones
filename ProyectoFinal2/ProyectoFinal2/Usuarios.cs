using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyectoFinal2
{
    class Usuarios
    {
        SqlConnection con;
        SqlCommand comando;
        SqlDataReader dr;
        public Usuarios()
        {
            try 
            {
                con = new SqlConnection(@"Data Source=.;Initial Catalog=ProyectoFinal;Integrated Security=True");
                con.Open();
               
            }
            catch (Exception er) 
            {
                MessageBox.Show("Error de conexion: "+ er.ToString());
            }
        }
        public string RegistrarUsuario(string Usu, string Contra)
        {
            string exito = "Usuario Registrado con exito!!";
            try
            {
                
                
                comando = new SqlCommand("Insert Into Users(Nombre, Contraseña) values('"+Usu+"','"+Contra+"')", con);
                comando.ExecuteNonQuery();
                //SqlDataAdapter sd = new SqlDataAdapter(comando);
                //DataTable dt = new DataTable();
                con.Close();
                
                
                
                
            }
            catch (Exception Err)
            {
                exito="Error de conexion" + Err.ToString(); 
            }
            return exito;
            
        }
        public string UsuarioRegistrado(string usuario)
        {
            string indice = usuario;
            try
            {


                comando = new SqlCommand("select * from Users where Nombre = '"+usuario+"'", con);
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    indice="";
                }
                dr.Close();
               


            }
            catch (Exception Err)
            {
                MessageBox.Show("Error al registrar usuario" + Err.ToString());
            }
            return indice;

        }
        public string Usuario(string usuario, string contraseña)
        {
            string indice = "";
            string indice2 = "";
            try
            {


                comando = new SqlCommand("select * from Users where Nombre AND Contraseña= '" + usuario + "','" + contraseña + "'", con);
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    indice = usuario;
                    indice2 = contraseña;
                }
                dr.Close();



            }
            catch (Exception Err)
            {
                MessageBox.Show("Error al registrar usuario" + Err.ToString());
            }
            return indice;

        }

    }
}

