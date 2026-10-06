using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        //tablas 
        Console.WriteLine("----------------------");
        Console.WriteLine("-- OR -> AND -> AND --");
        Console.WriteLine("----------------------");
        Console.WriteLine((false || false) && (false && false));
        Console.WriteLine((true || false) && (true && false)); 
        Console.WriteLine((false || true) && (false && true));  
        Console.WriteLine((true || true) && (true && true));
        
        Console.WriteLine("----------------------");
        Console.WriteLine("-- AND -> NOT -> OR --");
        Console.WriteLine("----------------------");
        Console.WriteLine((false && false) || !(false));
        Console.WriteLine((true && false) || !(true)); 
        Console.WriteLine((false && true) || !(false));  
        Console.WriteLine((true && true) || !(true));
    }
}
