﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste,Koleksiyon,
            //4:Liste,Koleksiyon,Dizi
            //string[] cities = { "milano", "roma", "Budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { "22", "33", "44", "55", "66", "77" };
            //foreach (string x in numbers)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 22, 33, 44, 55, 66, 77 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 22, 33, 44, 55, 66, 77 };

            //int total = 0;

            //foreach (int i in numbers)
            //{ 
            //    total += i;
            //}


            //Console.WriteLine(total);


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();



            ////Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma 

            //Console.WriteLine("------------------------------");
            //Console.Write("Sınıfınızda Kaç öğrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");

            ////Öğrenci ortalamalarını ve isimlerini saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //Her Öğrenci için  3 sınav notu girişi 

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;//notları topluyoruz.
            //    }

            //    //sınav ortalmaları
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;

            //}
            ////Öğrencilerin ortalaması
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //geçip kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi Kaldı") ;
            //    }
            //    Console.WriteLine("------------------------------");

            //}









            #endregion

            //Console.Read();

        }
    }
}
