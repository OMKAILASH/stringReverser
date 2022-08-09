using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringReverserCharByChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                   Reversed!");
            Console.WriteLine("                                                             - by SnoopyLikesToCode");
            Console.WriteLine("Enter the word/string you wish to reverse \n");


            string sToBeReversed = Console.ReadLine(); // taking input as string 

            char[] letterArray = sToBeReversed.ToCharArray(); 
            //declaring a array of character type, converting string to array of char using helping method.
            Array.Reverse(letterArray);
            // revrsing the array obtained above

            Console.WriteLine("\nThe Reverse of the Given string     " + sToBeReversed + "     is :");
            Console.WriteLine(); // spacing [ noob me :) ]
            Console.WriteLine(letterArray);

            // printing the array 
            // can also use foreach loop method ^ if so use Console.Write()  
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Thank you for using 'Reversed!' ");
            Console.WriteLine("Au Revoir!");
            Console.ReadLine(); // to show



        }
    }
}
