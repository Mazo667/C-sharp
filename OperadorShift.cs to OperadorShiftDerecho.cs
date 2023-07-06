using System ;
class Program {
    static void Main ( string [] args) {
        int intVar = 128 ;
        Console.WriteLine("Value of int variable is " + intVar);
        Console.WriteLine("After shifting 1 bit Right " + (intVar >> 1 ));
        Console.WriteLine("After shifting 2 bits Right " + (intVar >> 2 ));
        Console.WriteLine("After shifting 3 bits Right " + (intVar >> 3 ));
        Console.WriteLine("After shifting 4 bits Right " + (intVar >> 4 ));
        Console.WriteLine("After shifting 5 bits Right " + (intVar >> 5 ));
        Console.WriteLine("After shifting 6 bits Right " + (intVar >> 6 ));
        Console.WriteLine("After shifting 6 bits Right " + (intVar >> 7 ));
        Console.WriteLine("Value of int variable is " + intVar);
    }
}
