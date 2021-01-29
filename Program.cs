using System;
using System.Collections.Generic;

namespace hexConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            HexConverter converter = new HexConverter();
            string input = "";
            while (input != "Q")
            {
                Console.WriteLine("Please enter a decimal number to convert to hex, Q to exit");
                input = Console.ReadLine();
                if(int.TryParse(input,out int nInput))
                 Console.WriteLine(converter.decimalToHex(nInput));
            }
            Console.WriteLine("Exiting, press any key to close window");
            Console.ReadKey();
        }
    }
}
