using System;

class CalculoEdad {
    
    //funcion para calcular edad con su respectivo parametro
    static Double CalcularEdad(Double año){
        //obtengo fecha actual          
        DateTime fechaActual = DateTime.Now;
	  
        //obtengo unicamente el año
        string anio = fechaActual.Year.ToString();
        
        //hago una conversion del string anterior y se convierte en double para poder realizar el calculo
	    Double conversion = Convert.ToDouble(anio);
	  
        //aca se realiza el propio calculo	  
	    Double operacion = (conversion - año);
	    
	    //retorno el resultado
	    return operacion;
    }
  
    static void Main() {
        //variable a utilizar
        Double año;
        
        Console.WriteLine("\n");
		Console.WriteLine("\t*------------------------------------------------------------------------*\n");
        Console.WriteLine("\tBienvenido usuario, este es un programa para calcular tu respectiva edad\n");
        
	    Console.Write("\tPor favor ingresa tu respectivo año de nacimiento: ");
     	año = Convert.ToDouble(Console.ReadLine()); //hacemos la conversion del año ingresado
     	if(año >2021){
     	    Console.WriteLine("Fecha de nacimiento no valida");
     	}else{
     	Console.WriteLine("\tTu edad es de: " + CalcularEdad(año) + " años. \n"); //imprimo la funcion pasandole el parametro 
     	Console.WriteLine("\t*------------------------------------------------------------------------*\n");    
     	}
  }
  
}
