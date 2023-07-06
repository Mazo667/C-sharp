using System;
class OperadorLogicoAND {
	public static void Main() {
		int a = 10, b = 21;
		//Operando1 (a > b) && Operando2 (a++>b) = (false) && (false) = false
		if((a>b)&&(a++>b)){
			Console.WriteLine("Este bloque no fue evaluado");
		}
		Console.WriteLine("a no se incrementa "+a);
		//Operando1 (a < b) && Operando2 (a++<b) = (true) && (true) = true
		if ((a < b) && (a++ < b)) {
            Console.WriteLine("Este bloque fue evaluado");
        }
        Console.WriteLine("a es incrementado " + a);
    }
}
