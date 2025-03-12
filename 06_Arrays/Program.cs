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
            #region Temel Dİzi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Lacivert";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "lacivert", "kırmızı", "mavi", "yeşil"};
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            #region Dizi Metotlar
            //string[] customers = { "ali", "buse", "ayşe", "merve", "çınar", "kaan" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 58, 78, 98, 75, 145, 785 };
            //Console.WriteLine("Dizinin En Büyük Elemanı : " 
            //    + numbers.Max() + "Dizinin En Küçük Elemanı : " +
            //    numbers.Min());
            #endregion

            #region Kullanıcıdan Değer Alma 
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum  = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("-------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
