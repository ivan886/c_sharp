using System;

namespace Aprendizaje_C
{
    public class Casting
    {
        static void Main(string[] args)
        {   string nombre;
            int edad;
            Console.WriteLine("Hola como te llamas ");
            nombre = Console.ReadLine();
            Console.WriteLine("Es un gusto poder atenderte, " + nombre +", Pero antes puedes decirme que edad tienes ");
            string textoTemporal = Console.ReadLine();
            edad = Int32.Parse(textoTemporal);
            Console.WriteLine("Edad :" +edad);
            
            //condicionales
            if (edad >= 18)  
            { Console.WriteLine(" Qué deseas tomar? ");
                //...
            }
            else
            {  Console.WriteLine("Lo siento debes salir del establecimiento ");
            }
            // manejo de texto - string
            int longitud = nombre.Length;
            Console.WriteLine("Longitud: " + longitud);
            // nata      4  
            // 
            string subCadena = nombre.Substring(0, 8);
            Console.WriteLine("Subcadena: " + subCadena);

            bool contiene = nombre.Contains('-');
            if (contiene)
            { 
                Console.WriteLine("el nombre contiene el caracter -");
            }
            else
            {  Console.WriteLine("el nombre NO contiene el caracter -");
            }
        }
    }
}

