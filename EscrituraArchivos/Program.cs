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
            StreamWriter sw = new StreamWriter("chikistrikis.txt", true);
            //si el archivo no existe, será creado
            //si el archivo existe, escribirá en él

            Console.Write("Escriba un nombre: ");
            string nombre = Console.ReadLine();

            Nombre nom = new Nombre(nombre);

            sw.WriteLine(nom.nombre);

            //cerrar archivo
            sw.Close();

            Console.WriteLine("Escribiendo...");
            Console.ReadLine();
        }
    }
}
