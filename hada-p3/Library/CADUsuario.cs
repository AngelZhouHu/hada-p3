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
        private static int posicion;
     
        public CADUsuario()
        {
            constring = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
            posicion = 0;

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
            catch(SqlException ex)
            {
                throw new CADException("no funciona", ex);
            }

               
            
        }
        public bool readUsuario(ENUsuario en)
        {
            bool lectura = false;


            try
            {
                ENUsuario usu = en;
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select nif, nombre, edad From Usuarios where nif="+ usu.nifUsuario +"", c);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    en.nifUsuario= dr["nif"].ToString();
                    en.nombreUsuario = dr["nombre"].ToString();
                    en.edadUsuario = int.Parse(dr["edad"].ToString());
                }



                dr.Close();
                c.Close();
                return true;
            }
            catch (SqlException ex)
            {
                throw new CADException("no funciona", ex);
            }

        }
        public bool readFirstUsuario(ENUsuario en)
        {
            bool lectura = false;


            try
            {
                ENUsuario usu = en;
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select nif, nombre, edad From Usuarios where id= 1", c);
                SqlDataReader dr = com.ExecuteReader();

                dr.Read();
                
                en.nifUsuario = dr["nif"].ToString();
                en.nombreUsuario = dr["nombre"].ToString();
                en.edadUsuario = int.Parse(dr["edad"].ToString());
                



                dr.Close();

                lectura = true;
            }
            catch (SqlException ex)
            {
                lectura = false;
                throw new CADException("no funciona", ex);
            }
            finally
            {
                c.Close();
            }
            return lectura;
        }
        public bool readNextUsuario(ENUsuario en)
        {
            bool lectura = false;

            try
            {
                posicion++;
                ENUsuario usu = en;
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select nif, nombre, edad From Usuarios limit" +posicion+"", c);
                SqlDataReader dr = com.ExecuteReader();

                dr.Read();

                en.nifUsuario = dr["nif"].ToString();
                en.nombreUsuario = dr["nombre"].ToString();
                en.edadUsuario = int.Parse(dr["edad"].ToString());

                dr.Close();

                lectura = true;
            }
            catch (SqlException ex)
            {
                lectura = false;
                throw new CADException("no funciona", ex);
            }
            finally
            {
                c.Close();
            }
            return lectura;
        }
        public bool readPrevUsuario(ENUsuario en)
        {
            bool lectura = false;
            try
            {
                posicion--;
                ENUsuario usu = en;
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Select nif, nombre, edad From Usuarios limit" + posicion + "", c);
                SqlDataReader dr = com.ExecuteReader();

                dr.Read();

                en.nifUsuario = dr["nif"].ToString();
                en.nombreUsuario = dr["nombre"].ToString();
                en.edadUsuario = int.Parse(dr["edad"].ToString());

                dr.Close();
               
                lectura = true;
            }
            catch (SqlException ex)
            {
                lectura = false;
                throw new CADException("no funciona", ex);
            }
            finally
            {
                c.Close();
            }
            return lectura;
        }
        public bool updateUsuario(ENUsuario en)
        {
            try
            {
                ENUsuario usu = en;
                SqlConnection c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Update Usuarios set nombre, edad where nif=" + usu.nifUsuario , c);
                com.ExecuteNonQuery();
                c.Close();
                return true;
            }
            catch (SqlException ex)
            {
                throw new CADException("no funciona", ex);
            }
        }
        public bool deleteUsuario(ENUsuario en)
        {
            return false;
        }

    }
}
