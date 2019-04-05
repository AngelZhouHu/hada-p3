using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
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
            nifUsuario = "";
            nombreUsuario = "";
            edadUsuario = 0;
        }
        public ENUsuario(string nif, string nombre, int edad)
        {
            nifUsuario = nif;
            nombreUsuario = nombre;
            edadUsuario = edad;
        }
        public bool createUsuario()
        {
            CADUsuario crear = new CADUsuario();
            return crear.createUsuario(this);
            
        }
        public bool readUsuario()
        {
            CADUsuario lectura = new CADUsuario();
            return lectura.readUsuario(this);
        }
        public bool readFirstUsuario()
        {
            CADUsuario leerPrimero = new CADUsuario();
            return leerPrimero.readFirstUsuario(this);
        }
        public bool readNextUsuario()
        {
            CADUsuario leerSiguiente = new CADUsuario();
            return leerSiguiente.readNextUsuario(this);
        }
        public bool readPrevUsuario()
        {
            CADUsuario leerPrevio = new CADUsuario();
            return leerPrevio.readPrevUsuario(this);
        }
        public bool updateUsuario()
        {
            CADUsuario actualizar = new CADUsuario();
            return actualizar.updateUsuario(this);
        }
        public bool deleteUsuario()
        {
            CADUsuario borrar = new CADUsuario();
            return borrar.deleteUsuario(this);
        }
    }
}
