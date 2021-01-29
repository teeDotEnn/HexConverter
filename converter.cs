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
            return StackToString(outputStack);
        }

        private string StackToString(Stack<string> input)
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