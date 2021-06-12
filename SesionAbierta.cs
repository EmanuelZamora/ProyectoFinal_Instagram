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
    public partial class SesionAbierta : Form
    {
        ClsUserInsta perfil_activo;
        ClsArbolAVL usuarios;
        public SesionAbierta(object perfil_activo, object Arbol)
        {
            InitializeComponent();
            this.perfil_activo = (ClsUserInsta)perfil_activo;
            Regresar_PerfilPrincipal();
            usuarios = (ClsArbolAVL)Arbol;
            usuarios.mostrardata();
        }

        private void SesionAbierta_Load(object sender, EventArgs e)
        {
            lstSeguidores.View = View.Details;
            lstSeguidores.Columns.Add("SEGUIDORES");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(25,25);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string usuario = txtUsuarioBuscado.Text;
            ClsUserInsta UsuarioBuscado = new ClsUserInsta();
            ClsBusquedaObjetos Dato = null;
            ClsBusquedaObjetos seguidor_encontrado = null;

            UsuarioBuscado.Set_nomPerfil(usuario);

            if (Convert.ToInt32(e.KeyChar) == 13) 
            {
                Dato = usuarios.BuscarDato(UsuarioBuscado, 2);
                if (Dato.GetEncontrado() == true) 
                {
                    UsuarioBuscado = (ClsUserInsta)Dato.GetDato();
                    MostrarDatosIniciales(UsuarioBuscado);
                    btnRegresar.Visible = true;
                    btnSeguir.Visible = true;
                    seguidor_encontrado = perfil_activo.BuscarUsuarioSeguido(UsuarioBuscado.Get_nomUsuario());

                    if (seguidor_encontrado.GetEncontrado()) 
                    {
                        btnSeguir.Text = "DEJAR DE SEGUIR";
                    }
                    else 
                    {
                        btnSeguir.Text = "SEGUIR";
                    }
                }
                else
                {
                    MessageBox.Show("USUARIO NO REGISTARDO" + " ' " + usuario + " ' ", "ADVERTENCIA",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtUsuarioBuscado.Text = "";
            }
        }

        private void txtUsuarioBuscado_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarDatosIniciales(ClsUserInsta perfil_buscado) 
        {
            lblNombre.Text = perfil_buscado.Get_nomUsuario();
            lblNombreUsua.Text = perfil_buscado.Get_nomPerfil();
            lblCumpleAnios.Text = perfil_buscado.Get_Cumpleanos();
            lblSeguidores.Text = Convert.ToString(perfil_buscado.GetCantidadSeguidores());
            lblSeguidos.Text = Convert.ToString(perfil_buscado.GetCantidadSeguidos());
            try 
            {
                ImgPerfil.Image = Image.FromFile(perfil_buscado.Get_direccFoto());
            }
            catch (Exception e) 
            {
                ImgPerfil.Image = default;
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Regresar_PerfilPrincipal();
        }
        private void Regresar_PerfilPrincipal()
        {
            lblNombre.Text = this.perfil_activo.Get_nomUsuario();
            lblNombreUsua.Text = this.perfil_activo.Get_nomPerfil();
            lblCumpleAnios.Text = this.perfil_activo.Get_Cumpleanos();
            lblSeguidores.Text = Convert.ToString(this.perfil_activo.GetCantidadSeguidores());
            lblSeguidos.Text = Convert.ToString(this.perfil_activo.GetCantidadSeguidos());
            try 
            {
                ImgPerfil.Image = Image.FromFile(this.perfil_activo.Get_direccFoto());
            }
            catch (Exception e)
            {
                ImgPerfil.Image = default;
            }

            btnRegresar.Visible = false;
            btnSeguir.Visible = false;
            txtUsuarioBuscado.Text = "Buscar Usuario...(ENTER)";

        }

        private void txtUsuarioBuscado_Leave(object sender, EventArgs e)
        {
            txtUsuarioBuscado.Text = "Buscar Usuario...(ENTER)";
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            ClsUserInsta UsuarioBuscado = new ClsUserInsta();
            string usuario = lblNombreUsua.Text;
            ClsBusquedaObjetos Dato = null;
            UsuarioBuscado.Set_nomPerfil(usuario);

            if (btnSeguir.Text == "SEGUIR") 
            {
                Dato = usuarios.BuscarDato(UsuarioBuscado, 2);
                UsuarioBuscado = (ClsUserInsta)Dato.GetDato();
                UsuarioBuscado.Set_seguidor(perfil_activo);
                perfil_activo.Set_UsuarioSeguido(UsuarioBuscado);
                MostrarDatosIniciales(UsuarioBuscado);

                btnSeguir.Text = "DEJAR DE SEGUIR";
                MessageBox.Show("AHORA SIGUES AL USUARIO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool dato_eliminado = false;
                Dato = usuarios.BuscarDato(UsuarioBuscado, 2);
                UsuarioBuscado = (ClsUserInsta)Dato.GetDato();
                dato_eliminado = perfil_activo.Get_UsuariosSeguidos().DeleteUsuario(UsuarioBuscado.Get_nomPerfil());
                if (dato_eliminado) 
                {
                    UsuarioBuscado.Get_seguidores().DeleteUsuario(perfil_activo.Get_nomPerfil());
                    lblSeguidores.Text = Convert.ToString(UsuarioBuscado.GetCantidadSeguidores());
                    btnSeguir.Text = "SEGUIR";
                    MessageBox.Show("YA NO SIGUES AL USUARIO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("LLAME A SU ADMINISTRADOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           
            FrmOpciones MenuOpciones = new FrmOpciones(usuarios, perfil_activo);
            MenuOpciones.Show();

            Close();

        }
    }
}
