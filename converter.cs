using System;
using System.Collections.Generic;
using System.Text;

namespace hexConverter
{
    public class HexConverter
    {
        public string decimalToHex(int input)
        {
           
            Stack<string> outputStack = new Stack<string>();
            do
            {
                int remainderCheck = input % 16;
                switch (remainderCheck)
                {
                    case 10:
                        outputStack.Push("A");
                        break;
                    case 11:
                        outputStack.Push("B");
                        break;
                    case 12:
                        outputStack.Push( "C");
                        break;
                    case 13:
                        outputStack.Push( "D");
                        break;
                    case 14:
                        outputStack.Push( "E");
                        break;
                    case 15:
                        outputStack.Push( "F");
                        break;
                    default:
                        outputStack.Push( (remainderCheck).ToString());
                        break;
                }
                input = input / 16;
            } while (input != 0) ;
            return stackToString(outputStack);
        }

        public int hexToDec(string input)
        {
            int maxPower = input.Length;
            int power = 0;
            int output = 0;
            Stack<char> hexDigits = new Stack<char>();
            foreach(char c in input)
            {
                hexDigits.Push(c);
            }
            while(hexDigits.Count != 0)
            {
                char digit = hexDigits.Pop();
                int decDigit = 0;
                ;
                switch(digit)
                {
                    case 'A':
                        decDigit = 10;
                        break;
                    case 'B':
                        decDigit = 11;
                        break;
                    case 'C':
                        decDigit = 12;
                        break;
                    case 'D':
                        decDigit = 13;
                        break;
                    case 'E':
                        decDigit = 14;
                        break;
                    case 'F':
                        decDigit = 15;
                        break;
                    default:
                        decDigit = (int)Char.GetNumericValue(digit);
                        break;
                }
                output += decDigit * (int)Math.Pow(16,power);
                if(power<maxPower)
                {
                    power++;
                }
            }

            return output;
            
        }

        private string stackToString(Stack<string> input)
        {
            StringBuilder builder = new StringBuilder();
            while(input.Count !=0)
            {
                builder.Append(input.Pop());
            }
            return builder.ToString();
        }
    }
}