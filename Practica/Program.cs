using Entidades.Final;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        path = path + "/datos.json";

        EscritoraArchivos escritora = new EscritoraArchivos(path);

        string contenido = "hola\nchau";
        escritora.Escribir(contenido);
    }
}