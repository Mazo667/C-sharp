using System;
    class Hola{
        static void Main(string[]args){
            string sinVerbatim = "Esta cadena\n no tiene un \nliteral de cadena";
            string conVerbatim = @"Esta cadena\n si tiene un\nliteral de cadena";
            Console.WriteLine(sinVerbatim);
            Console.WriteLine(conVerbatim);
        }
    }
