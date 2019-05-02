using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*Q1*/
            Console.WriteLine("this appiliacation will change the sign of the number");
            Console.WriteLine("please enter your number");
            Console.WriteLine($" the number with its sign changed would be :{ChangeSign(double.Parse(Console.ReadLine()))}");

            Console.ReadLine();

            /*Q2*/
            Console.WriteLine(" This application will convert miles to km's......");
            Console.WriteLine("please enter a distance in miles");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{miles} = {Converter(miles)}KM's");
        }
         
         


    }
}
