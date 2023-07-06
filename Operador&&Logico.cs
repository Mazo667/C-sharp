using System;
class HolaMundo {
	public static void Main() {
		bool operando1 = true ;
        bool operando2 = true ;
        Console.WriteLine("operando1 = {0}", operando1);
        Console.WriteLine("operando2 = {0}", operando2);
		Console.WriteLine("Comparamos con ambos operandos con &&");
        Console.WriteLine("operando1 && operando2 = {0}", (operando1 && operando2)); //True
		operando1 = true;
		operando2 = false;
		Console.WriteLine("2da Comparacion con los valores cambiados");
		Console.WriteLine("operando1 && operando2 = {0}", (operando1 && operando2)); //False
		operando1 = false;
		operando2 = false;
		Console.WriteLine("3ra Comparacion con los valores cambiados a falsos");
		Console.WriteLine("operando1 && operando2 = {0}", (operando1 && operando2)); //False
	}
}
