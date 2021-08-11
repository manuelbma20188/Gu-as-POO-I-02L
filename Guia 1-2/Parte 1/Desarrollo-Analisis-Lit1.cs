using System;

class Temperaturas {
  static void Faren(){
	  //variables
      Double cel, far;
	  //aparece en pantalla
	  Console.Write("Escribe los grados Celsius: ");
	  //se leen los grados celsius y se convierten a double
	  cel = Convert.ToDouble(Console.ReadLine());
	  //se obtienen los grados fahrenheit
	  //redondeamos el resultado final
	  far = Math.Round((cel * 9.0 / 5 +32),2);
	  //impresión de datos
	  Console.WriteLine("{0} grados celsius son {1} grados Fahrenheit", cel, far);	  
  }	
	
	static void Celsi(){
		
	  //variables
      Double cel, far;
	  //aparece en pantalla
	  Console.Write("Escribe los grados Fahrenheit: ");
	  //se leen los grados fahrenheit y se convierten a double
	  far = Convert.ToDouble(Console.ReadLine());
	  //se obtienen los grados fahrenheit
	  //redondeamos el resultado final
	  cel = Math.Round(((far -32)  * 5 / 9),2);
	  //impresión de datos
	  Console.WriteLine("{0} grados fahrenheit son {1} grados Celsius", far, cel);	
	
	}
	
	static void FarenToKelvin(){
	    //variables
      Double kelv, far;
	  //aparece en pantalla
	  Console.Write("Escribe los grados Fahrenheit: ");
	  //se leen los grados fahrenheit y se convierten a double
	  far = Convert.ToDouble(Console.ReadLine());
	  //se obtienen los grados fahrenheit
	  //redondeamos el resultado final
	  kelv = Math.Round(((far -32) * 5/9 + 273.15),2);
	  //impresión de datos
	  Console.WriteLine("{0} grados fahrenheit son {1} grados kelvin", far, kelv);    
	}
	
	static void KelvToFaren(){
	    //variables
      Double kelv, far;
	  //aparece en pantalla
	  Console.Write("Escribe los grados kelvin: ");
	  kelv = Convert.ToDouble(Console.ReadLine());
	  //redondeamos el resultado final
	  far = Math.Round(((kelv - 273.15) * 9/5 + 32),2);
	  //impresión de datos
	  Console.WriteLine("{0} grados Kelvin son {1} grados Fahrenheit", kelv, far);    
	}
	
	static void CelToKelv(){
	    Double cel, kelv;
	    Console.Write("Escribe los grados Celsius: ");
	    cel = Convert.ToDouble(Console.ReadLine());
	    kelv = (cel + 273.15);
	    Console.WriteLine("{0} grados Celsius son {1} grados Kelvin", cel, kelv);    
	}
	
	static void KelvToCel(){
	    Double cel, kelv;
	    Console.Write("Escribe los grados Kelvin: ");
	    kelv = Convert.ToDouble(Console.ReadLine());
	    cel = (kelv - 273.15);
	    Console.WriteLine("{0} grados Kelvin son {1} grados Celsius", kelv, cel);
	}
	
    static void Main(string[] args)
    {
        //variables que me sirven para validar la entrada de solo numeros
        int valor;
        bool esNumero;
 
        //do while para validar solo numeros
        do{
        string opc;
        Console.WriteLine("\n");
		Console.WriteLine("\t*------------------------------------------------------------------------*\n");
		Console.WriteLine("\t\t\t\t.:: Programa para convertir temperaturas ::.\n");
		Console.WriteLine("\tElige el tipo de conversión: \n");
		Console.WriteLine("\tPresiona 1 si quieres convertir Celsius a Fahrenheit");
		Console.WriteLine("\tPresiona 2 si quieres convertir Fahrenheit a Celsius");
		Console.WriteLine("\tPresiona 3 si quieres convertir Fahrenheit a kelvin");
    	Console.WriteLine("\tPresiona 4 si quieres convertir kelvin a Fahrenheit");
    	Console.WriteLine("\tPresiona 5 si quieres convertir Celsius a kelvin");
    	Console.WriteLine("\tPresiona 6 si quieres convertir kelvin a Celsius\n");
		Console.Write("\tElige una opcion: ");
		
		//recoger lo que puso el usuario
		opc = Console.ReadLine();
		
		//si lo ingresado es un numero entonces retorna true y cortará al ciclo
		esNumero= int.TryParse(opc, out valor);
		
		switch(opc){
			case "1":
    			Console.Clear();
    			Console.WriteLine("\n");
				Console.WriteLine("\t --------------- Conversion a Fahrenheit --------------- \n");
				//invocamos al metodo
				Faren();
				break;
		    
				
			case "2":
			    Console.Clear();
			    Console.WriteLine("\n");
				Console.WriteLine("\t --------------- Conversión a Celsius ---------------\n");
				//invocamos al metodo
				Celsi();
				break;
			
			case "3": 
			    Console.Clear();
			    Console.WriteLine("\n");
			    Console.WriteLine("\t --------------- Conversion de Fahrenheit a kelvin --------------- \n");
				FarenToKelvin();
				break;
				
			case "4": 
			    Console.Clear();
			    Console.WriteLine("\n");
			    Console.WriteLine("\t --------------- Conversion de kelvin a Fahrenheit --------------- \n");
				KelvToFaren();
				break;
				
			case "5": 
			    Console.Clear();
			    Console.WriteLine("\n");
			    Console.WriteLine("\t --------------- Conversion de Celsius a kelvin --------------- \n");
				CelToKelv();
				break;
				
			case "6": 
			    Console.Clear();
			    Console.WriteLine("\n");
			    Console.WriteLine("\t --------------- Conversion de kelvin a Celsius --------------- \n");
				KelvToCel();
				break;
				
			default:
				Console.WriteLine("\n Tipo de conversión no válida");
				break;
		}
		
		}while (!esNumero); //condicion para validar solo numeros
		
    }
  
}
