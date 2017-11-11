using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINICA.Clases
{
    class Utilidades
    {
        private static decimal numero_Decimal = 0;
        private static int numero_Entero = 0;
        private static string error;

        public static string Error
        {
            get { return Utilidades.error; }
            set { Utilidades.error = value; }
        }

        public static int Numero_Entero
        {
            get { return Utilidades.numero_Entero; }
            set { Utilidades.numero_Entero = value; }
        }
        

        public static decimal Numero_Decimal
        {
            get { return Utilidades.numero_Decimal; }
            set { Utilidades.numero_Decimal = value; }
        }

        public static bool ValidarDecimal(string num) 
        {
            try
            {
                numero_Decimal = Convert.ToDecimal(num);
                error = "";
                return true;

            }
            catch (Exception ex)
            {

                error = ex.Message;
                return false;
            }
        
        }

        public static bool ValidarEntero(string num) 
        {
            try
            {
                numero_Entero = Convert.ToInt32(num);
                error = "";
                return true;

            }
            catch (Exception ex)
            {

                error = ex.Message;
                return false;
            }
        }

        
    }
}
