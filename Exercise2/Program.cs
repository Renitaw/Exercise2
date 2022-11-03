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
                Renita[RW + 1] = temp;
            }
        }
        //creating a method to display the sorted array 
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine(" Sorted array elements");
            Console.WriteLine("----------------------");
            for (int RW = 0; RW < n; RW++)
            {
                Console.WriteLine(Renita[RW]);
            }
            Console.WriteLine("");
        }

        //Membuat method untuk menggabungkan array 
        static public void MainMerge(int[] Renita, int low, int mid, int high)
        {
            int[] temp = new int[34];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = low;
            num = (high - low + 1);

            while ((low <= eol) && (mid <= high))
            {
                if (Renita[low] <= Renita[mid])
                    temp[pos++] = Renita[low++];
                else
                    temp[pos++] = Renita[mid++];
            }
            while (low <= eol)
                temp[pos++] = Renita[low++];
            while (mid <= high)
                temp[pos++] = Renita[mid++];
            for (i = 0; i < num; i++)
            {
                Renita[high] = temp[high];
                high--;
            }
        }

        //Membuat method untuk mengurutkan array gabungan 
        static public void SortMerge(int[] Renita, int low, int high)
        {
            int mid;
            if (high > low)
            {
                mid = (high + low) / 2;
                SortMerge(Renita, low, mid);
                SortMerge(Renita, (mid + 1), high);
                MainMerge(Renita, low, (mid + 1), high);
            }
        }

        //create main agar program dapat berjalan 
        static void Main(string[] args)
        {
            //declaring pilihanmenu
            program P = new program();
            int pilihanmenu;

            //creating a menu
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("==================");
                Console.WriteLine("1.insertion sort");
                Console.WriteLine("2.merge sort");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("insertion sort");
                        Console.WriteLine("-----------------------");
                        P.input();
                        P.insertionsort();
                        P.display();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("merge sort");
                        Console.WriteLine("-----------------------");
                        Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
                        Console.Write("\n\nEnter number of elements: ");
                        int max = Convert.ToInt32(Console.ReadLine());
                        int[] numbers = new int[max];
                        for (int i = 0; i < max; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max; k++)
                        {
                            Console.Write(numbers[k] + " ");
                            Console.Write("\n");
                        }
                        Console.WriteLine("Sorted Array");
                        SortMerge(numbers, 0, max - 1);
                        for (int i = 0; i < max; i++)
                            Console.WriteLine(numbers[i]);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("exit");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("\n\nPress Return to exit");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
       
