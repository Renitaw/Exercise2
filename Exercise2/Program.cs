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
        private int[] Renita = new int[34];
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
                if ((n > 0) && (n <= 34))
                    break;
                else
                    Console.WriteLine("\nArray should have a minimum of 1 and a maximum of 30 elements. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("====================");
            Console.WriteLine("Enter array elements");
            Console.WriteLine("====================");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Renita[i] = Int32.Parse(s1);
            }
        }
        //creating a method to sort array using insertion sort
        public void insertionsort()
        {
            for (int i = 0; i < n; i++)
            {
                int temp = Renita[i];
                int RW = i - i;
                while (RW >= 0 && Renita[RW] > temp)
                {
                    Renita[RW + 1] = Renita[RW];
                    RW = RW - 1;
                }
            }
        }
       
    }


}

