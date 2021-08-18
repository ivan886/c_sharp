using System;

class Condicionales2 {
    static void Main(string[] args) {
		Random rand = new Random();
        //salarios de desarrolladores
		int salario1 = rand.Next(50,100);
		int salario2 = rand.Next(50,100);
		int salario3 = rand.Next(50,100);
		
		Console.WriteLine("El Salario 1 es:"+ salario1+"\nEl Salario2 es:"+salario2+"\nEl Salario3 es:"+salario3);
    
		if (salario1>salario2 && salario1>salario3){
		Console.WriteLine("El salario mayor es el salario1 con:"+salario1+"$ Dolares");
		}
	else if (salario2>salario1 && salario2>salario3){
		Console.WriteLine("El salario mayor es el salario2 con:"+salario2+"$ Dolares");
		}
		else{
		Console.WriteLine("El salario mayor es el salario3 con:"+salario3+"$ Dolares");
		}
	}