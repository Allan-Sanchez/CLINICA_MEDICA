using CLINICA.MEDICODataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.Clases
{
    class Examenes
    {
        private static ExamenesTableAdapter adaptador = new ExamenesTableAdapter();
        //ExamenesTableAdapter es el nombre de la tabla donde realizamos nuestros querys

        public static void Insert_Examen(string nombre_Examen,decimal costo,string nota)
        {
            adaptador.Insert_Examen(nombre_Examen,costo,nota);
            //le paso los campos que le asigne en el query
        }

        public static void Update_Examen(string nombre_Examen,decimal costo,string nota,int id_Examenes) 
        {
            adaptador.Update_Examen(nombre_Examen, costo, nota, id_Examenes);
        }

        public static void Delete_Examen(int id_Examenes)
        {
            adaptador.Delete_Examen(id_Examenes);
        }

        public static bool ExisteExamen(int id_Examenes)
        {

            return adaptador.ExisteExamen(id_Examenes) == 1;
            // verificamos si existe el examen de existin el devuelve 1 si no devuelve null
        }
        public static bool Existe_Examen_igual(string nombre_Examen) 
        {
          return  adaptador.Existe_Examen_igual(nombre_Examen)==1;
        }

    }
}
