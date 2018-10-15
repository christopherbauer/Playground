using System;
using System.Linq;
using System.Text;

namespace CodinGamesPlayground
{
    public class BinaryConverter
    {
        public string StringToBinary(string input)
        {
            var bytes = Encoding.ASCII.GetBytes(input);
            return string.Join("", bytes.Select(b => Convert.ToString(b, 2).PadLeft(7, '0')));
        }

        public string BinaryStringToUnary(string input)
        {
            var unaryString = string.Empty;
            var i = 0;
            while(i<input.Length)
            {
                if (input.Substring(i, 1) == "1")
                {
                    unaryString += (!string.IsNullOrEmpty(unaryString) ? " " : "") + "0 ";
                    while (i<input.Length && input[i] == '1')
                    {
                        unaryString += "0";
                        i++;
                    }
                }
                if (i<input.Length && input.Substring(i, 1) == "0")
                {
                    unaryString += (!string.IsNullOrEmpty(unaryString) ? " " : "") + "00 ";
                    while (i < input.Length && input[i] == '0')
                    {
                        unaryString += "0";
                        i++;
                    }
                    
                }
            }
            return unaryString;
        }
    }
    class Program
    {
        private static readonly BinaryConverter _binaryConverter = new BinaryConverter();

        static void Main(string[] args)
        {
            string input = "CC";

            var binaryString = _binaryConverter.StringToBinary(input);
            var unaryString = _binaryConverter.BinaryStringToUnary(binaryString);
        }
    }
}
