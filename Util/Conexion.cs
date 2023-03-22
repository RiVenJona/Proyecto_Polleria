using System;
using System.Configuration;
namespace Util
{
    public static class Conexion
    {
        public static String Obtener() { 
            return ConfigurationManager.ConnectionStrings["cn"].ToString();
        }
    }
}
