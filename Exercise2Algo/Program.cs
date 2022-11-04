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
            /* Deklarasi array untuk menampung angka-angka yang akan diurutkan dan elemen array
            berdasarkan input user (variabel Elements) */
            int[] Angka = new int[Elements];
            Console.WriteLine("—————————————————-");
            /* Metode untuk input angka yang akan disimpan pada masing-masing element di Array */
            for (int i = 0; i < Elements; i++)
            {
                Console.WriteLine("Masukkan angka untuk mengisi elemen " + i + ":");
                string Input_Temp = Console.ReadLine();
                int angka;
                if (int.TryParse(Input_Temp, out angka))
                {
                    Angka[i] = Convert.ToInt32(angka);
                }
                else
                {
                    Console.WriteLine("Maaf input yang Anda masukkan salah.Silahkan tekan Enter untuk mengulang");
                    Console.ReadLine();
                    InsertionSort();
                }
            }
            /* Metode Insertion Sort */
            for (int i = 1; i < Elements; i++)
            {
                while (i > 0)
                {
                    if (Angka[i - 1] > Angka[i])
                    {
                        int Temp = Angka[i - 1];
                        Angka[i - 1] = Angka[i];
                        Angka[i] = Temp;
                        
                    }
                    else
                    {
                        break;
                    }
                }
            }

            /* Menampilkan hasil pengurutan */
            Console.WriteLine("");
            Console.WriteLine("Hasil pengurutan nilai: ");
            for (int i = 0; i < Elements; i++)
            {
                Console.WriteLine("Elemen" + i + ":");
                Console.WriteLine(Angka[i]);
            }
        }
    }
}