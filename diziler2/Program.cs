using System;

namespace diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,4,86,72,3,31,17};

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("**** Sıralı Dizi ****");

            Array.Sort(sayiDizisi);    
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Array.Clear(sayiDizisi,2,2); 
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            Array.Resize < int > (ref sayiDizisi,9);
            sayiDizisi[9] = 99;

        }
    }
}
