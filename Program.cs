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
                Console.WriteLine("enter 1 to convert dec to hex, 2 to convert hex to dec, Q to exit");
                input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (result == 1)
                    {
                        while (input != "Q")
                        {
                            Console.WriteLine("Please enter a decimal number to convert to hex, Q to exit");
                            input = Console.ReadLine();
                            if (int.TryParse(input, out int nInput))
                                Console.WriteLine(converter.decimalToHex(nInput));
                        }
                    }
                    else if (result == 2)
                    {
                        while (input != "Q")
                        {
                            Console.WriteLine("Please enter a hex number to convert to hex, Q to exit");
                            input = Console.ReadLine();
                            if (input != "Q")
                                Console.WriteLine(converter.hexToDec(input));
                        }
                    }
                    else if (result == 3)
                    {
                        while (input != "Q")
                        {
                            Console.WriteLine("Please enter a number");
                            input = Console.ReadLine();
                            if (int.TryParse(input, out int nInput)) 
                            {
                                string hex = converter.decimalToHex(nInput);
                                Console.WriteLine($"Your number in hex: {hex}");
                                Console.WriteLine($"Your number converted back: {converter.hexToDec(hex)}");
                            }

                        }
                    }
                }
            }
            Console.WriteLine("Exiting, press any key to close window");
            Console.ReadKey();
        }
    }
}
