using CLINICA.MEDICODataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.Clases
{
    class Paciente
    {
       private static PacientesTableAdapter adaptador = new PacientesTableAdapter();

        public static void InsertPaciente(string DPI_Paciente,string nombres,string apellidos,string direccion,
                                    string telefono,string telefono_Casa,string notas,DateTime fecha_de_consulta)
        {
            adaptador.InsertPaciente(DPI_Paciente,nombres,apellidos,direccion,telefono,telefono_Casa,notas,fecha_de_consulta);
        }

        public static void UpdatePaciente(string DPI_Paciente,string nombres,string apellidos,string direccion,
                                        string telefono,string telefono_Casa,string notas,DateTime fecha_de_consulta,int id_Paciente)
        {
            adaptador.UpdatePaciente(DPI_Paciente, nombres, apellidos, direccion, telefono, telefono_Casa, notas, fecha_de_consulta, id_Paciente);
        }

        public static void DeletePaciente(int id_Paciente)
        {
            adaptador.DeletePaciente(id_Paciente);
        }

        public static void Existe_Paciente(int id_Paciente) 
        {
            adaptador.Existe_Paciente(id_Paciente);
        }

        public static void Existe_paciente_DPI(string DPI_Paciente)
        {
            adaptador.Existe_paciente_DPI(DPI_Paciente);
        }


 
        
    }
}
