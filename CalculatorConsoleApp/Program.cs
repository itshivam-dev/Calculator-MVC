using System;
using CalculatorLibrary;
using Newtonsoft.Json;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int add = calc.Add(10, 5);
            int sub = calc.Subtract(10, 5);

            Console.WriteLine("Add: " + add);
            Console.WriteLine("Subtract: " + sub);

            var obj = new { Operation = "Addition", Result = add };

            string json = JsonConvert.SerializeObject(obj);

            Console.WriteLine("JSON Output:");
            Console.WriteLine(json);
        }
    }
}