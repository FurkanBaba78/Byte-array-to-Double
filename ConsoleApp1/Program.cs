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
            double d;
            Console.Write("Double: ");
            d = Double.Parse(Console.ReadLine());
            Console.WriteLine("Double value: " + d.ToString());
            byte[] bytes = ConvertDoubleToByteArray(d);
            Console.WriteLine("Byte array value:");
            Console.WriteLine(BitConverter.ToString(bytes));
            Console.WriteLine("Byte array back to double:");

            // Create byte array to double  
            double dValue = ConvertByteArrayToDouble(bytes);
            Console.WriteLine(dValue.ToString());
            Console.ReadLine();

        }
        public static byte[] ConvertDoubleToByteArray(double d)
        {
            return BitConverter.GetBytes(d);
        }
        public static double ConvertByteArrayToDouble(byte[] b)
        {
            return BitConverter.ToDouble(b, 0);
        }
    }
}
