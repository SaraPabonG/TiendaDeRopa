using System;

//Clase para controlar tanto los servicios, pero también los que se encargaran de llamarlos.


namespace lib_dominio.Nucleo
{ 
    public class DatosGenerales
        {
    public static string ruta_json = @"E:\Configuracion\secrets.json";
    public static bool usa_azure = false;
    public static string clave = "EVBgi345936456ghhVBJGtgnifytsidi3456678jhgUTytutyiiyi";
    public static string usuario_datos = EncriptarConversor.Encriptar("Test.Trghhjsgdj");
    }
}