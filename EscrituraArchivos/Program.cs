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
            StreamWriter sw = new StreamWriter("QueDeseas.txt", true);
            //si el archivo no existe, será creado
            //si el archivo existe, escribirá en él

            Console.Write("Escriba su mayor deseo: ");
            string deseo = Console.ReadLine();
            Console.Write("Número de deseo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Deseo Deseo = new Deseo(numero, deseo);

            sw.WriteLine(Deseo.numero + " " + Deseo.deseo);

            //cerrar archivo
            sw.Close();

            Console.WriteLine("Escribiendo...");
            Console.ReadLine();
        }
    }
}
