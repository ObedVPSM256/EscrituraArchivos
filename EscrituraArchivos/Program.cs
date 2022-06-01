using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //si el archivo no existe, será creado
            //si el archivo existe, escribirá en él

            string[] lines =
            {
                "Esto es la primer línea",
                "Esto es la segunda línea",
                "Esto es la tercer línea"
            };
            //recorrer el arreglo para escribir las líneas en el archivo
            foreach(string line in lines)
            {
                //escribir en el archivo
                sw.WriteLine(line);
            }
            //cerrar archivo
            sw.Close();
            Console.WriteLine("Escribiendo...");
            Console.ReadLine();
        }
    }
}
