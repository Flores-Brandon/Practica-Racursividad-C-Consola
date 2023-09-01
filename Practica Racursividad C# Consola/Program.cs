using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Racursividad_C__Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escritorioPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ListarArchivosRecursivamente(escritorioPath);
            Console.ReadLine();
        }
        static void ListarArchivosRecursivamente(string directorio)
        {
            ListarArchivosEnDirectorio(directorio);

            string[] subdirectorios = Directory.GetDirectories(directorio);
            foreach (string subdirectorio in subdirectorios)
            {
                ListarArchivosRecursivamente(subdirectorio); // Llamada recursiva para listar subdirectorios
            }
        }

        static void ListarArchivosEnDirectorio(string directorio)
        {
            try
            {
                string[] archivos = Directory.GetFiles(directorio);

                foreach (string archivo in archivos)
                {
                    Console.WriteLine(Path.GetFileName(archivo) + " (" + Path.GetExtension(archivo) + ")");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar archivos: " + ex.Message);
            }
        }
    }
    }

