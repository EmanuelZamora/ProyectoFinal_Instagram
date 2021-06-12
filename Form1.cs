using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoFinal_Instagram
{
    public partial class Form1 : Form
    {
         ClsArbolAVL UsuarioInsta_Alterno = new ClsArbolAVL();

        public Form1(object UsuarioInsta_Alterno)
        {
            InitializeComponent();

            if(UsuarioInsta_Alterno != null) 
            {
                this.UsuarioInsta_Alterno = (ClsArbolAVL)UsuarioInsta_Alterno;
                
            }else
            {
                CargarDatosXML();
            }
            
        }

        private void CargarDatosXML() 
        {

            bool datos_cargados = false;
            XmlReader LecturaXml = XmlReader.Create(@"C:\Users\emanuel\Desktop\ProyectoFinalInstagram\XML\UserData.xml");
            string[] datos = new string[5];
            //int indice = 1;
            while (LecturaXml.Read())
            {

                if (LecturaXml.IsStartElement() && (LecturaXml.NodeType == XmlNodeType.Element))
                {

                    switch (LecturaXml.Name.ToString())
                    {
                        case "USER":
                            if (LecturaXml.HasAttributes)
                            {
                                datos[0] = LecturaXml.GetAttribute("ID");
                            }
                            break;
                        case "USERNAME":
                            datos[1] = LecturaXml.ReadElementContentAsString();
                            break;

                    }
                }//Fin del If de inicio de elemto

                if (LecturaXml.NodeType == XmlNodeType.Element)
                {
                    switch (LecturaXml.Name.ToString())
                    {
                        case "FULLNAME":
                            datos[2] = LecturaXml.ReadElementContentAsString();
                            break;
                        case "PROFILEIMAGE":
                            datos[3] = LecturaXml.ReadElementContentAsString();
                            break;
                        case "BIRTHDATE":
                            datos[4] = LecturaXml.ReadElementContentAsString();
                            datos_cargados = true;
                            break;

                    }
                }//Fin de if Elementos


                if (datos_cargados) 
                {
                    ClsUserInsta usuario_nuevo = new ClsUserInsta(datos[0], datos[1], datos[2], datos[3], datos[4]);
                    UsuarioInsta_Alterno.AddDatos(usuario_nuevo, 2);
                    datos_cargados = false;

                }

            }//Fin del While de lectura XML

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;

            ClsUserInsta aux_usuario = new ClsUserInsta();
            aux_usuario.Set_nomPerfil(usuario);

            ClsBusquedaObjetos usuario_encontrado = UsuarioInsta_Alterno.BuscarDato(aux_usuario,2);

            if (usuario_encontrado.GetEncontrado()) 
            {

                this.Close();
                SesionAbierta Form2 = new SesionAbierta(usuario_encontrado.GetDato(), UsuarioInsta_Alterno);
                Form2.ShowDialog();
            }
            else
            {
                txtUsuario.Text = "";
                MessageBox.Show("No se encontro su nombre de usuario " + " ' " + usuario + " ' ", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            TextBox clickedTextbox = sender as TextBox;
            if (clickedTextbox.Text.Equals("Usuario"))
            {
                clickedTextbox.Text = "";
            }
            txtUsuario.ForeColor = Color.Black;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            TextBox clickedPasswordBox = sender as TextBox;
            if (clickedPasswordBox.Text.Equals("Contraseña"))
            {
                clickedPasswordBox.Text = "";
            }
            txtContrasena.ForeColor = Color.Black;
        }
    }

    
}
