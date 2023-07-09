using System;
    class Programa{
        static void Main(string[]args){
         Console.WriteLine("Enter a Number");
        int number = int .Parse(Console.ReadLine());
        switch (number) {
        case 1 :
            Console.WriteLine("Sunday");
        break ;
        case 2 :
            Console.WriteLine("Monday");
        break ;
        case 3 :
            Console.WriteLine("Tueday");
        break ;
        case 4 :
            Console.WriteLine("Wednesday");
        break ;
        case 5 :
            Console.WriteLine("ThursDay");
        break ;
        case 6 :
            Console.WriteLine("Friday");
        break;
        case 7 :
            Console.WriteLine("Saturday");
        break ;
        default :
            Console.WriteLine("You entered wrong day number");
        break ;
    }
  }
}
