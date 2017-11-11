using CLINICA.MEDICODataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.Clases
{
    class Medicos
    {

        private static MedicosTableAdapter adaptador = new MedicosTableAdapter();

        public static void InsertMedico(string DPI,string nombres,string apellidos,string direccion,string notas,string telefono)
        {
            adaptador.InsertMedico(DPI, nombres, apellidos, direccion, notas, telefono);
        }

        public static void UpdateMedico(string DPI,string nombres,string apellidos,string direccion,string notas,string telefono,int id_Medico) 
        {
            adaptador.UpdateMedico(DPI, nombres, apellidos, direccion, notas, telefono, id_Medico);
        }

        public static void DeleteMedico(int id_Medico) 
        {
            adaptador.DeleteMedico(id_Medico);
        }

        public static bool Existe_Medico(string DPI) 
        {
            return adaptador.Existe_Medico(DPI)==1;
        }
    }
}
