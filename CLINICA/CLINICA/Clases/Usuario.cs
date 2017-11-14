
using LibConexionBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.Clases
{
    class Usuario1
    {
        private static string mensaje;
        private static ConexionBD conexion = new ConexionBD("Parametros.xml");
        public static string Mensaje { get { return mensaje; } }

       


        public static bool Validar_Usuario(string usuario,string clave) 
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            conexion.SQL = "SELECT (1) From Usuarios" +
                           " WHERE Usuario ='"+usuario+"' AND clave='"+clave+"'";

            if (!conexion.ConsultarValorUnico(false))
            {
                 mensaje = conexion.Error;
                conexion.CerrarConexion();
                return false;
            }

            if (conexion.ValorUnico==null)
            {
                mensaje = "Usuario o Contraseña no valido";
                conexion.CerrarConexion();
                return false;
            }
            conexion.CerrarConexion();
            return true;
        
        }

        public static Usuarios Getusuarios(string id_Usuario) 
        {
            if (!conexion.AbrirConexion())
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
            }
            conexion.SQL="SELECT * FROM Usuarios WHERE Usuario='"+id_Usuario+"'";

            if (!conexion.LlenarDataSet(false))
            {
                mensaje = conexion.Error;
                conexion.CerrarConexion();
                return null;
            }

            if (conexion.Ds == null)
            {
                mensaje = "Usuario no Existe ";
                conexion.CerrarConexion();
                return null;
            }

            if (conexion.Ds.Tables[0].Rows.Count == 0)
            {
                mensaje = "Usuario no Existe ";
                conexion.CerrarConexion();
                return null;
            }

            Usuarios usuario1 = new Usuarios();
            usuario1.usuario  = conexion.Ds.Tables[0].Rows[0].ItemArray[0].ToString();
            usuario1.clave = conexion.Ds.Tables[0].Rows[0].ItemArray[1].ToString();
            usuario1.nombre = conexion.Ds.Tables[0].Rows[0].ItemArray[2].ToString();
            usuario1.apellido = conexion.Ds.Tables[0].Rows[0].ItemArray[3].ToString();
            usuario1.id_Perfil =(int) conexion.Ds.Tables[0].Rows[0].ItemArray[4];
            


            conexion.CerrarConexion();
            return usuario1;



        }


        

    }
}
