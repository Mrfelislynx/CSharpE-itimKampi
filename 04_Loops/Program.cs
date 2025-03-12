using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            #region For Döngüsü

            //For(x;y;z)
            //x:basşlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C^# Eğitim Kampı");
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda : " + bacterium);

            //}
            #endregion

            #region While Döngüsü

            //While(şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Karan");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}








            #endregion


            #region Örnek Sınav Sorusu

            //klavyeden girilen 3 basamaklı sayının basamaklarını hesaplayan kodu yazınız ?
            //456 = 4+5+6

            //Console.Write("Sayıyı Giriniz : ");

            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //sum = ones + tens + hundreds;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //Console.WriteLine(sum);



            #endregion


            Console.Read();
        }
    }
}
