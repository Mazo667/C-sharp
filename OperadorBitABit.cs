using System;
    class Hola{
        static void Main(string[]args){
            byte a = 8; //0000 1000
            byte b = 9; //0000 1001

            Console.WriteLine("a & b es "+(a&b)); //0000 1000
            Console.WriteLine("a | b es "+(a|b)); //0000 10001
            Console.WriteLine("a ^ b es "+(a^b)); //0000 0001
        }
    }
