using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Library
{
    public class CADUsuario
    {
        private string constring;
     
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();

        }
        public bool createUsuario(ENUsuario en)
        {
            try
            {
                ENUsuario usu = en;
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Usuarios (nif, nombre, edad) VALUES ('" + usu.nifUsuario + "', '" + usu.nombreUsuario + "', '" + usu.edadUsuario + "'", c);
                com.ExecuteNonQuery();
                c.Close();
                return true;
            }
            catch(Exception ex)
            {

                return false;
            }

               
            
        }
        public bool readUsuario(ENUsuario en)
        {
            try
            {
                ENUsuario usu = en;
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select nif, nombre, edad From Usuarios where nifUsuario="+ usu.nifUsuario, c);
                com.ExecuteNonQuery();
                c.Close();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public bool readFirstUsuario(ENUsuario en)
        {
            try
            {
                ENUsuario usu = en;
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select nif, nombre, edad From Usuarios where id= 1", c);
                com.ExecuteNonQuery();
                c.Close();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool readNextUsuario(ENUsuario en)
        {
            return false;
        }
        public bool readPrevUsuario(ENUsuario en)
        {
            return false;
        }
        public bool updateUsuario(ENUsuario en)
        {
            return false;
        }
        public bool deleteUsuario(ENUsuario en)
        {
            return false;
        }

    }
}
