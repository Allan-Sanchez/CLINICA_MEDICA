using CLINICA.MEDICODataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.Clases
{
    class NewUsuario
    {

        private static UsuariosTableAdapter adaptator = new UsuariosTableAdapter();


       public static void InsertUsuario(string Usuario,string clave,string nombres,string apellidos,int id_Perfil)
       {
           adaptator.InsertUsuario(Usuario, clave, nombres, apellidos, id_Perfil);
       }

       public static void DeleteUsuario(string Usuario)
       {
           adaptator.DeleteUsuario(Usuario);
       }

       public static void UpdateUsuario(string Usuario,string clave,string nombres,string apellidos,int id_Perfil) 
       {
           adaptator.UpdateUsuario(Usuario, clave, nombres, apellidos, id_Perfil);
       }

       public static bool Existe_Usuario(string Usuario) 
       {
         return  adaptator.Existe_Usuario(Usuario)==1;
       }
    }
}
