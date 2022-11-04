using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class program
    {
        private int[] a = new int[91];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan Jumlah Element Array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 91)
                    break;
                else
                    Console.WriteLine("\nArray maksimum 91 element.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Masukkan Element Array");
            Console.WriteLine("----------------------");


        }
    }
}