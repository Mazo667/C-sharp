using System;
    class Hola{
        static void Main(string[]args){
            Console.WriteLine("Escriba su nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Escriba su edad");
            String edad = Console.ReadLine();
            Console.WriteLine("Hola {0} tienes {1} años de edad",nombre,edad);
        }
    }
