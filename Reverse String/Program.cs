using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Exit = false;
            while (Exit ==  false)
                {
                
                Console.Write("Enter a string or press e to EXIT" + "\r\n");

                string InPut = Console.ReadLine();
                char[] process = InPut.ToCharArray();
                Array.Reverse(process);
                Console.WriteLine(process);

                if (InPut == "e")
                {
                Exit = true;
                }
            }

        }
    }
}
