using System;
namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad tjänar den första anställda?");
            string förstaText = Console.ReadLine();
            double första = double.Parse(förstaText);
            Console.WriteLine("Vad tjänar den andra anställda?");
            string andratext = Console.ReadLine();  
            double andra = double.Parse(andratext);
            Console.WriteLine("Vad tjänar den tredje anställda?");
            string tredjetext = Console.ReadLine(); 
            double tredje = double.Parse(tredjetext);   
            
            double sum = (första + andra + tredje) / 2;
            Console.WriteLine("Medelvärdet av de tre antälldas lön är " +  sum);
            Console.ReadKey();
        }
    }
}