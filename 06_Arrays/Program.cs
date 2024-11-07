using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // DegiskenTuru [] DiziAdi = new DegiskenTuru[ElemanSayisi]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Mavi";
            //colors[3] = "Sarı";

            //Console.WriteLine(colors[2]);


            //int[] numbers = { 50, 48, 698, 24, 748 };
            //Console.WriteLine(numbers[3]);
            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Lacivert", "Beyaz", "Kırmızı", "Yeşil", "Turuncu" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            #endregion

            #region Dizide En Büyük Eleman

            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(myArray.Length);
            //Console.WriteLine(maxNumber);
            #endregion

            #region Array İşlemleri

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Console.WriteLine("Dizinin en büyük elemanı " + numbers.Max() + " \nDizinin en küçük elemanı " + numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Sehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("-------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            #endregion

            Console.Read();
        }
    }
}