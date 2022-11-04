using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Text;
namespace tester
{
    class Insertion
    {
        public void InsertionSort()
        {
            Console.Clear();
            Console.WriteLine("Masukkan Banyak Elemen: ");
            /* Deklarasi variabel untuk input jumlah elemen array yg akan diurutkan */
            string Input = Console.ReadLine();
            int Elements;
            if (int.TryParse(Input, out Elements))
            {
                Elements = Convert.ToInt32(Input);
            }
            else
            {
                Console.WriteLine("Maaf input yang Anda masukkan salah.Silahkan tekan Enter untuk mengulang");
                Console.ReadLine();
                InsertionSort();
            }
        }
    }
}