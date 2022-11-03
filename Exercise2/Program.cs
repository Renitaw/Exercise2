using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class program
    {
        //deklarasi array and variabel 
        private int[] Renita = new int[30];
        int n;
        int i;

        //creating a method for receiving input

        public void input()
        {
            while (true)
            {
                Console.WriteLine("Enter  the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 30))
                    break;
                else
                    Console.WriteLine("\nArray should have a minimum of 1 and a maximum of 30 elements. \n");
            }
        }
    }


}

