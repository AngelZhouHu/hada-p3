using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Library;

namespace usuWeb
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Leer_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            en.readUsuario();
        }
        protected void Leer_Primero_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            en.readFirstUsuario();
        }

        protected void Leer_Anterior_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            en.readPrevUsuario();
        }
        protected void Leer_Siguiente_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            en.readNextUsuario();
        }


        protected void Crear_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            en.createUsuario();
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            en.updateUsuario();
        }

        protected void Borrar_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            en.deleteUsuario();
        }

    }

}