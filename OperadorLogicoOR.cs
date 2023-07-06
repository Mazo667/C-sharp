using System;
class OperadorLogicoAND {
	public static void Main() {
		bool Operando1 = true;
		bool Operando2 = true;
		Console.WriteLine("Operando1 = {0}",Operando1);
		Console.WriteLine("Operando2 = {0}",Operando2);
		Console.WriteLine("Operando1 || Operando2 = {0}",(Operando1||Operando2)); //True
		Operando1 = true;
		Operando2 = false;
		Console.WriteLine("Operando1 || Operando2 = {0}",(Operando1||Operando2)); //True
		Operando1 = false;
		Operando2 = false;
		Console.WriteLine("Operando1 || Operando2 = {0}",(Operando1||Operando2)); //False
    }
}
