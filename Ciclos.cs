using System;

class Ciclos {
    static void Main(string[] args) {
		int nivelVida=0;
		Random rand = new Random();
	
	for(int i=0; i< 500; i++ )
	  {  nivelVida = rand.Next(0,100);
		  Console.WriteLine(i + ",Nivel de vida: "+nivelVida);
		 
		  if(nivelVida >= 80)
	          Console.WriteLine(" estas muy bien, sigue adelante ");
	        
	      if(nivelVida>=50 && nivelVida<= 79)
	          Console.WriteLine( " debes buscar un kit de salud para recuperar vida ");
	      
	      if(nivelVida>0 && nivelVida<= 49)  
	       Console.WriteLine(  " ten cuidado, puedes estar perdiendo");
	      
		 if (nivelVida == 0)
		  {  
			 Console.WriteLine("Game Over");
			 break;
		  }
	 }

		 Console.WriteLine("Fin aplicación principal");
   }
}