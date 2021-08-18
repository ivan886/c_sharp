using System;

namespace ConsoleApp1
{
    class String
    {
        static void Main(string[] args)
        {   string nombre;
            Console.WriteLine("Hola Como te llamas?");
            nombre=Console.ReadLine();

            int longitud = nombre.Length;
            Console.WriteLine("longitud:" + longitud);
            
            string parteTexto= nombre.Substring(0, 5);
            Console.WriteLine("Parte del texto :" + parteTexto);

            string textoMayusculas = nombre.ToUpper();
            Console.WriteLine("Mayusculas: " + textoMayusculas);
            
            string remplazo = nombre.Replace("a","$");
            Console.WriteLine("Remplazo: " + remplazo);
            
            
            
            bool b = nombre.Contains(' ');
            if (b)
            {
                int posicion=nombre.IndexOf(' ');
                Console.WriteLine(posicion);
                string apellido=nombre.Substring(posicion, (longitud-posicion));
                Console.WriteLine("apellido: " + apellido);
            }

        }
    }
}