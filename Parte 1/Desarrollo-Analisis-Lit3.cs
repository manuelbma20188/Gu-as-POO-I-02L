using System;
using System.Threading;

class Menu {
    
    
    static void Division(){
		Double num1, num2, operacion;
	  	Console.WriteLine("\t\t -------------- Haz seleccionado la opción 1 --------------\n");
		Console.Write("\t\tIngrese el primer número: ");
		num1 = Convert.ToDouble(Console.ReadLine()); //conversion del dato ingresado
		Console.Write("\t\tIngrese el segundo número: ");
		num2 = Convert.ToDouble(Console.ReadLine()); //conversion del dato ingresado
		//valido en caso de que el num2 sea igual a cero
		if(num2 ==0){
		    Console.WriteLine("\t\tNo se puede realizar divison entre cero");
		
		}else{
		    operacion = (num1 / num2);
		    Console.WriteLine("\t\tEl resultado de dividir " + num1 + "y " + num2 + " es: " + operacion);
		    Console.WriteLine("\t\t----------------------------------------------------------------------");
		}
	}
	  
	static void Cubo(){
	  	Double num, resultado;
		Console.WriteLine("\t\t -------------- Haz seleccionado la opción 2 -------------- \n");
		Console.Write("\t\tIngrese el número respectivo: ");
		num = Convert.ToDouble(Console.ReadLine()); //conversion del dato ingresado
		resultado = Math.Pow(num, 3); //elevo al cubo el numero con la funcion math.pow, agregandole el exponente luego de la ','
		Console.WriteLine("\t\t" + num + " al cubo es: " + resultado + "\n");
		Console.WriteLine("\t\t----------------------------------------------------------------------");
	  }
	  
	  static void Indice(){
	  	Double peso, altura, resultado;
		Console.WriteLine("\t\t -------------- Haz seleccionado la opción 3 -------------- \n");
		Console.Write("\t\tPor favor ingrese su peso en Kg: ");
		peso = Convert.ToDouble(Console.ReadLine()); //conversion del dato ingresado
		Console.Write("\t\tPor favor ingrese su altura en metros: ");
		altura = Convert.ToDouble(Console.ReadLine()); //conversion del dato ingresado
		  
	    resultado = (peso / (Math.Pow(altura, 2))); //se emplea la formula y funcion math.Pow 
	    Console.WriteLine("\t\tTu indice de masa corporal es: " + resultado + " según los parametros dados.\n");
	    Console.WriteLine("\t\t----------------------------------------------------------------------");
	  }
	  
  static void Main() {
    //declaro variable booleana, con el objetivo de hacer repetitivo al menu
    bool salir = false;
    while (salir !=true) { //mientras esta condicion se cumpla, el ciclo se seguira repitiendo 
          
        try{ //try para fines validacion
            Console.WriteLine("\t\t*---------------------------- Programa para realizar diversos calculos ----------------------------*\n");		
		    Console.WriteLine("\t\t1. Dividir dos cantidades");
		    Console.WriteLine("\t\t2. Obtener cubo de un numero");
		    Console.WriteLine("\t\t3. Calcular Indice de Masa Corporal");
		    Console.WriteLine("\t\t4. Salir");
		    Console.Write("\t\tElige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            
            switch (opcion){
                case 1:
                    Console.Clear();
                    Division();
                    //esta funcion hace que se haga una pausa en pantalla, en milisegundos
                    Thread.Sleep(1550);
                    Console.Clear();
                    break;
 
                case 2:
                    Console.Clear();
                    Cubo();
                    //esta funcion hace que se haga una pausa en pantalla, en milisegundos
                    Thread.Sleep(1550);
                    Console.Clear();
                    break;
 
                case 3:
                    Console.Clear();
                    Indice();
                    //esta funcion hace que se haga una pausa en pantalla, en milisegundos
                    Thread.Sleep(1550);
                    Console.Clear();
                    break;
                    
                case 4:
                    Console.Clear();
                    Console.WriteLine("\t\t ------------- Saliendo de la aplicacion... ------------");
                    salir = true; //aca corto el ciclo del while
                    break;
                    
                default:
                    Console.Clear();
                    Console.WriteLine("\t\t ------------- Opcion no valida ------------");
                    //esta funcion hace que se haga una pausa en pantalla, en milisegundos
                    Thread.Sleep(1550);
                    Console.Clear();
                    break;
            } //end del switch
 
            }catch (FormatException e){
                Console.WriteLine(e.Message); //imprimo mensaje de error en caso de haberlo
                Thread.Sleep(1000);
                Console.Clear();
            } //end del try catch
            
        }//end del while
 
            Console.ReadLine();
        }//end del main
      
      

}
