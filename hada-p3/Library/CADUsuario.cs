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

            return false;
        }
        public bool readUsuario(ENUsuario en)
        {
            SqlCommand com = new SqlCommand("Select * from usuarios", c);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool readFirstUsuario(ENUsuario en)
        {
            return false;
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
