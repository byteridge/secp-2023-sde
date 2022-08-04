using System;
using System.Text;

namespace SECP
{
	class Secp {		
		public static void Main(string[] args)
		{
            TestMixedCase();
            TestLowerCase();
		}

        static void PrintCharArray(string label, char[] array_to_print)
        {
            System.Console.WriteLine("{0} : {1}",label, string.Join("", array_to_print));
        }

        /*
            Implement your logic inside this method ONLY
        */
        static void SecpLogic(char[] array_to_manipulate)
        {
            /*
                Start implementation
            */

            /*
                End implementation
            */
            PrintCharArray("Post-logic", array_to_manipulate);
            System.Console.WriteLine("--------------------------------------------------------");
            //
            return;
        }

        static void TestMixedCase()
        {
            char[] program = {'S', 'o', 'f', 't', 'w', 'a', 'r', 'e', ' ', 'E', 'n', 'g', 'i', 'n', 'e', 'e', 'r', 'i', 'n', 'g', ' ', 'C', 'a', 'r', 'e', 'e', 'r', ' ', 'P', 'r', 'o', 'g', 'r', 'a', 'm'};
            //
            PrintCharArray("Pre -logic", program);
            //
            SecpLogic(program);
            //
            return; 
        }

        static void TestLowerCase()
        {
            char[] program = {'g', 'r', 'e', 'e', 't', 'i', 'n', 'g', 's', ' ', 'f', 'r', 'o', 'm', ' ', 'b', 'y', 't', 'e', 'r', 'i', 'd', 'g', 'e'};
            //
            PrintCharArray("Pre -logic", program);
            //
            SecpLogic(program);
            //
            return;
        }
	}
}
