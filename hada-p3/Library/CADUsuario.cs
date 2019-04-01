﻿using System;
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
            constring =ConfigurationManager.ConnectionStrings["miconexion"].ToString();
            posicion = 0;

        }
        public bool createUsuario(ENUsuario en)
        {
            bool crear = false;
            ENUsuario usu = en;
            SqlConnection c;
            try
            {
                c = new SqlConnection(constring);
                c.Open();
                SqlCommand com = new SqlCommand("Insert Into Usuarios (nif, nombre, edad) VALUES ('" + usu.nifUsuario + "', '" + usu.nombreUsuario + "', '" + usu.edadUsuario + "'", c);
                com.ExecuteNonQuery();
                c.Close();


            }
            catch (SqlException ex)
            {
                crear = false;
                throw new CADException("no funciona", ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine("User operation has failed. Error:{0}", ex.Message);
            }
            finally
            {
            }
            return crear;



        }
        public bool readUsuario(ENUsuario en)
        {
            bool lectura = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                ENUsuario usu = en;
                
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
        public bool readFirstUsuario(ENUsuario en)
        {
            bool lectura = false;

            SqlConnection c = new SqlConnection(constring);
            try
            {
                ENUsuario usu = en;
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
            SqlConnection c = new SqlConnection(constring);
            try
            {
                posicion++;
                ENUsuario usu = en;
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
            SqlConnection c = new SqlConnection(constring);
            try
            {
                posicion--;
                ENUsuario usu = en;
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
            bool cambiar = false;

            SqlConnection c = new SqlConnection(constring);

            try
            {
                ENUsuario usu = en;
                c.Open();
                SqlCommand com = new SqlCommand("Update Usuarios set nombre, edad where nif=" + usu.nifUsuario , c);
                com.ExecuteNonQuery();


                cambiar = true;
            }
            catch (SqlException ex)
            {
                cambiar = false;
                throw new CADException("no funciona", ex);
            }
            finally
            {
                c.Close();
            }
            return cambiar;
        }
        public bool deleteUsuario(ENUsuario en)
        {
            bool borrar = false;

            SqlConnection c = new SqlConnection(constring);

            try
            {
                ENUsuario usu = en;
                c.Open();
                SqlCommand com = new SqlCommand("Delete from Usuarios where nif=" + usu.nifUsuario, c);
                com.ExecuteNonQuery();
                
                borrar = true;
            }
            catch (SqlException ex)
            {
                borrar = false;
                throw new CADException("no funciona", ex);
            }
            finally
            {
                c.Close();
            }
            return borrar;
        }

    }
}
