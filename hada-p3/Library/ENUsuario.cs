using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENUsuario
    {
        private string nif;
        private string nombre;
        private int edad;

        public string nifUsuario
        {
            get { return nif; }
            set { nif = value; }
        }
        public string nombreUsuario
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int edadUsuario
        {
            get { return edad; }
            set { edad = value; }
        }
        public ENUsuario()
        {
           
        }
        public ENUsuario(string nif, string nombre, int edad)
        {
            nifUsuario = nif;
            nombreUsuario = nombre;
            edadUsuario = edad;
        }
        public bool createUsuario()
        {
            return false;
        }
        public bool readUsuario()
        {
            return false;
        }
        public bool readFirstUsuario()
        {
            return false;
        }
        public bool readNextUsuario()
        {
            return false;
        }
        public bool readPrevUsuario()
        {
            return false;
        }
        public bool updateUsuario()
        {
            return false;
        }
        public bool deleteUsuario()
        {
            return false;
        }
    }
}
