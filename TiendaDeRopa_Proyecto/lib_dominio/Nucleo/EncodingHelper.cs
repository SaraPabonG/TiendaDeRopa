using System;

namespace lib_dominio.Nucleo
{
    public class EncodingHelper
    {
        //Clase para convertir string a arreglos de bites y viceversa.

        public static string ToString(byte[] data)
        {
            return Convert.ToBase64String(data);
        }
        public static byte[] ToBytes(string data)
        {
            return Convert.FromBase64String(data);
        }
    }

}





