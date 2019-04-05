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
                Label4.Text = " El usuario es:";
                Label1.Text = " NIF: " + en.nifUsuario;
                Label2.Text = " Nombre: " + en.nombreUsuario;
                Label3.Text = " Edad: " + en.edadUsuario.ToString();
            }
            else
            {
                Label4.Text = " El usuario no se ha podido leer.";
            }
        }
        protected void Leer_Primero_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;

           
            if (en.readFirstUsuario())
            {
                Label4.Text = " El primer usuario es: ";
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
                Label4.Text = " El anterior usuario es: ";
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
                Label4.Text = " El siguiente usuario es: ";
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
            if(en.readUsuario())
            {
                Label4.Text = " El usuario ya existe en la base de datos";
            }
            else
            {
                if (en.createUsuario())
                {
                    Label4.Text = " El usuario ha sido creado con éxito";
                }
            }
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;
            en.nombreUsuario = Nombre.Text;
            en.edadUsuario = int.Parse(Edad.Text);

            if (en.readUsuario())
            {
                if (en.updateUsuario())
                {
                    Label4.Text = " El usuario ha sido actualizado con éxito";
                    Label1.Text = " NIF: " + en.nifUsuario;
                    Label2.Text = " Nombre: " + en.nombreUsuario;
                    Label3.Text = " Edad: " + en.edadUsuario.ToString();
                }
            }
            else
            {
                Label4.Text = " El usuario no existe en la base de datos";
            }
        }

        protected void Borrar_Click(object sender, EventArgs e)
        {
            ENUsuario en = new ENUsuario();
            en.nifUsuario = NIF.Text;

            if (en.readUsuario())
            {
                if (en.deleteUsuario())
                {
                    Label4.Text = " El usuario ha sido borrado con éxito";
                    Label1.Text = " NIF: Borrado";
                    Label2.Text = " Nombre: Borrado";
                    Label3.Text = " Edad: Borrado";
                }
            }
            else
            {
                Label4.Text = " El usuario no existe en la base de datos";
              
            }
        }

    }

}