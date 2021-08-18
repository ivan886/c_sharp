using System;

class Basic {
    static void Main(string[] args) {
           /*uso de comentarios igual que java*/
           //igual 


            string nombre;
            int edad;
            Console.WriteLine("Hola Como te llamas?");
            nombre=Console.ReadLine();
            Console.WriteLine( nombre+" Es un gusto poder atenderte, pero antes puedes decirme que edad tienes " );
            string texto =Console.ReadLine();
            edad = Int32.Parse(texto);
           Console.WriteLine("Edad:" +edad);

           

    }
}