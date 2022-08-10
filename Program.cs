using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[]args)
        {
            //sort
            int[]sayiDizisi={15,18,13,28,4,16,0,89};
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
            Console.WriteLine("***Array Sort***");

            Array.Sort(sayiDizisi);
            //Diziyi küçükten büyüğe sıralayan array.

            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            Console.WriteLine("***Array Clear***");
            Array.Clear(sayiDizisi,2,2);
            //2. indexten itibaren 2 elemanı temizleme; 0 yapan array.

            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
            Console.WriteLine("***Array Reverse***");
            Array.Reverse(sayiDizisi);
            //Diziyi tersten yazan array.

            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
            Console.WriteLine("***Array IndexOf***");
            
            Console.WriteLine(Array.IndexOf(sayiDizisi,18));
            //Bir elemanın dizide kaçıncı sırada olduğunu gösteren array.(0'lı sayma ile)

            Console.WriteLine("*** Array Resize***");
            Array.Resize<int>(ref sayiDizisi,9);
            //Diziyi tekrar boyutlandırır ve yeni elemanlar için yer açmış olur.
            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            






        }
    }
}