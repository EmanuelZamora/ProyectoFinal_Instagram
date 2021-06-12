using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinal_Instagram
{
    class ClsUserInsta : IComparador
    {
        private string id;
        private string nom_perfil;
        private string nom_usuario;
        private string direcc_foto;
        private string cumpleanos;
        private ClsHashTable seguidores;
        private ClsHashTable usuarios_seguidos;

        public ClsUserInsta() 
        {
            id = "";
            nom_perfil = "";
            nom_usuario = "";
            direcc_foto = "";
            cumpleanos = "";
            seguidores = new ClsHashTable();
            usuarios_seguidos =  new ClsHashTable();
        }
        public ClsUserInsta(string id, string nom_perfil, string nom_usuario, string direcc_foto, string cumpleanos) 
        {
            this.id = id;
            this.nom_perfil = nom_perfil;
            this.nom_usuario = nom_usuario;
            this.direcc_foto = direcc_foto;
            this.cumpleanos = cumpleanos;
            seguidores = new ClsHashTable();
            usuarios_seguidos = new ClsHashTable();
        }

        bool IComparador.mayorQue(object objeto, int tipo_llave)
        {
            bool resp = false;
            ClsUserInsta UsuarioComprobacion = (ClsUserInsta)objeto;

            switch (tipo_llave)
            {
                case 1:
                    if (id.CompareTo(UsuarioComprobacion.Get_id()) > 0)
                    {
                        resp = true;
                    }
                    break; //Caso 1 llave primaria (ID)
                case 2:
                    if (nom_perfil.CompareTo(UsuarioComprobacion.Get_nomPerfil()) > 0)
                    {
                        resp = true;
                    }
                    break; //Caso 1 llave secundaria(Nombre de Perfil)
            }


            return resp; ;
        }

        bool IComparador.menorQue(object objeto, int tipo_llave) 
        {
            bool resp = false;
            ClsUserInsta UsuarioComprobacion = (ClsUserInsta)objeto;

            switch (tipo_llave) 
            {
                case 1:
                    if (id.CompareTo(UsuarioComprobacion.Get_id()) < 0)
                    {
                        resp = true;
                    }
                    break; //Caso 1 llave primaria (ID)
                case 2:
                    if (nom_perfil.CompareTo(UsuarioComprobacion.Get_nomPerfil()) < 0 )
                    {
                        resp = true;
                    }
                    break; //Caso 1 llave secundaria(Nombre de Perfil)
            }
            

            return resp;
        }

        bool IComparador.igualQue(object objeto, int tipo_llave)
        {
            bool resp = false;
            ClsUserInsta UsuarioComprobacion = (ClsUserInsta)objeto;

            switch (tipo_llave)
            {
                case 1:
                    if (id.CompareTo(UsuarioComprobacion.Get_id()) < 0)
                    {
                        resp = true;
                    }
                    break; //Caso 1 llave primaria (ID)
                case 2:
                    if (nom_perfil.CompareTo(UsuarioComprobacion.Get_nomPerfil()) == 0)
                    {
                        resp = true;
                    }
                    break; //Caso 1 llave secundaria(Nombre de Perfil)
            }


            return resp;
        }



        public string Get_id() { return id; }
        public string Get_nomPerfil() { return nom_perfil; }
        public string Get_nomUsuario() { return nom_usuario; }
        public string Get_direccFoto() { return direcc_foto; }
        public string Get_Cumpleanos() { return cumpleanos; }
        public ClsHashTable Get_seguidores() { return seguidores; }

        public ClsHashTable Get_UsuariosSeguidos() { return usuarios_seguidos; }

        public void Set_id(string id) { this.id = id; }
        public void Set_nomPerfil(string nom_perfil) { this.nom_perfil = nom_perfil; }
        public void Set_nomUsuario(string nom_usuario) { this.nom_usuario = nom_usuario; }
        public void Set_direccFoto(string direcc_foto) { this.direcc_foto = direcc_foto; }
        public void Set_Cumpleanos(string cumpleanos) { this.cumpleanos = cumpleanos; }
        public void Set_seguidor(ClsUserInsta seguidores)
        {
            this.seguidores.AddDatoHash(seguidores, seguidores.Get_nomPerfil());
        }
        public void Set_UsuarioSeguido(ClsUserInsta usuarios_seguidos) 
        { 
            this.usuarios_seguidos.AddDatoHash(usuarios_seguidos, usuarios_seguidos.Get_nomPerfil());
        }

        public ClsBusquedaObjetos BuscarUsuarioSeguido(string dato) 
        {
            ClsUserInsta Usuario_buscar =new ClsUserInsta(); 
            Usuario_buscar.Set_nomUsuario(dato);
            ClsLista ListaDatos = (ClsLista)usuarios_seguidos.BuscarLista(dato);
            if (ListaDatos != null)
            {
                return ListaDatos.BuscarDato(Usuario_buscar);
            }
            else
            {
                return new ClsBusquedaObjetos(dato, false);
            }
              
        }

        public void EliminarSeguidos() 
        {
            int i = 0;
            int j = 0;
            while (i <  usuarios_seguidos.HashTableContent()) 
            {
                ClsLista Lista = usuarios_seguidos.HashTableSearchCorrelative(i+1);
                while (j < Lista.LongitudLista()) 
                {
                    ClsUserInsta Usuario = (ClsUserInsta) Lista.Recorrido(j+1);
                    Usuario.Get_seguidores().DeleteUsuario(nom_perfil);
                    j++;
                }
                i++;
            }

        }

        public int GetCantidadSeguidores()
        { 
            if (seguidores != null) 
            { return seguidores.HashTableContent(); }
            else
            { return 0; }
        }
        public int GetCantidadSeguidos()
        {
            if (usuarios_seguidos != null)
            { return usuarios_seguidos.HashTableContent(); }
            else
            { return 0; }
        }

    }//Fin Clase Usuario Instagram
}
