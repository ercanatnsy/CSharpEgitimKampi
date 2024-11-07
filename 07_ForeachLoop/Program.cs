using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach

            // Foreach(1; 2; 3; 4)

            // 1: Değişken türü
            // 2: Değişken adı
            // 3: In
            // 4: Liste, Koleksiyon, Dizi



            //string[] cities = { "İstanbul", "Ankara", "Tekirdağ" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}



            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}



            //int[] numbers = { 1, 2, 54, 78, 100, 545, 989 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);



            // Foreach dizilerin yanında list ile de çalışır.

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 10
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("---------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            // Öğrenci isimleri ve not ortalamasını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentExamAvg[i] = totalExamResult / 3;
            }

            // Sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                // Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");

                }
                Console.WriteLine("-------------------------------------");
            }




            #endregion

            Console.Read();
        }
    }
}
