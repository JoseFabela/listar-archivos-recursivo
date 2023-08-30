using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listar_archivos_recursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\"; // Cambia esto a la ruta del directorio que desees explorar
            ListFilesRecursively(directoryPath);
            Console.ReadLine();
        }
        static void ListFilesRecursively(string directoryPath)
        {
            try
            {
                foreach (string file in Directory.GetFiles(directoryPath))
                {
                    Console.WriteLine($"Archivo: {Path.GetFileName(file)}, Extensión: {Path.GetExtension(file)}");
                }

                foreach (string subdirectory in Directory.GetDirectories(directoryPath))
                {
                    ListFilesRecursively(subdirectory);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al acceder a {directoryPath}: {e.Message}");
            }
        }
    }
}
