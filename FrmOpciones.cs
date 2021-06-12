using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Instagram
{
    public partial class FrmOpciones : Form
    {
        ClsUserInsta usuario;
        ClsArbolAVL ArbolUsuarios;
        public FrmOpciones(object ArbolUsuarios, object usuario)
        {
            InitializeComponent();
            this.ArbolUsuarios = (ClsArbolAVL)ArbolUsuarios;
            this.usuario = (ClsUserInsta)usuario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsUserInsta Dato;
            ClsBusquedaObjetos UsuarioBuscado;
            UsuarioBuscado = ArbolUsuarios.BuscarDato(usuario , 2);
            Dato = (ClsUserInsta)UsuarioBuscado.GetDato();
            Dato.Set_nomUsuario(txtnombreNuevo.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
           // usuario.EliminarSeguidos();
            ArbolUsuarios.DeleteDato(usuario, 2);
            Form1 IniciarSesion = new Form1(ArbolUsuarios);
            IniciarSesion.Show();
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 IniciarSesion = new Form1(ArbolUsuarios);
            IniciarSesion.Show();
            this.Close();
        }

        private void ImgButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SesionAbierta Sesion = new SesionAbierta(usuario, ArbolUsuarios);
            Sesion.Show();
        }
    }
}
