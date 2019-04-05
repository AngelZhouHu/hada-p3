using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using library;

namespace usuWeb
{
    public partial class Default : System.Web.UI.Page
    {
       
        protected void Leer_Click(object sender, EventArgs e)
        {
          
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;


            if (en.readUsuario())
            {
                Label1.Text = " NIF: " + en.nifUsuario;
                Label2.Text = " Nombre: " + en.nombreUsuario;
                Label3.Text = " Edad: " + en.edadUsuario.ToString();
            }
        }
        protected void Leer_Primero_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;

           
            if (en.readFirstUsuario())
            {
                Label1.Text = " NIF: " + en.nifUsuario;
                Label2.Text = " Nombre: " + en.nombreUsuario;
                Label3.Text = " Edad: " + en.edadUsuario.ToString();
            }
        }

        protected void Leer_Anterior_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            
            if (en.readPrevUsuario())
            {
                Label1.Text = " NIF: " + en.nifUsuario;
                Label2.Text = " Nombre: " + en.nombreUsuario;
                Label3.Text = " Edad: " + en.edadUsuario.ToString();
            }
        }
        protected void Leer_Siguiente_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;

            if (en.readNextUsuario())
            {
                Label1.Text = " NIF: " + en.nifUsuario;
                Label2.Text = " Nombre: " + en.nombreUsuario;
                Label3.Text = " Edad: " + en.edadUsuario.ToString();
            }
        }


        protected void Crear_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            if(en.createUsuario())
            {
                Label4.Text = " Usuario creado.";
            }
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