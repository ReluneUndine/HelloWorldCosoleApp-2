using System;
using System.ComponentModel.Design;

namespace HelloWorldCosoleApp_2
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, тут начинается основная часть кода
        {
            /// <summary>
            /// Console.WriteLine() переносил бы каждое новое слово на новую строку
            /// Console.Write() пишет всё на одной и той же строке
            /// Console.ReadLine() нужен для того, чтобы окошко закрылось только при нажатии  Enter
            /// </summary>


            Console.Write("Hello, ");
            Console.Write("World ");
            Console.Write("!!!");
            Console.ReadLine();

           
           
        }
    }
}
