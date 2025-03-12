using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //geriye değer döndürmeyen Metotlar
            //Customer--->listele,ekle,sil,güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("ali yıldız");
            //    Console.WriteLine("ayse");
            //    Console.WriteLine("fatma");
            //    Console.WriteLine("ahmet");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum()


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet YIldırım");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri : " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void sum(int number1,int number2,int number3) 
            //{
            //    int result = number1 + number2+number3;
            //    Console.WriteLine(result);
            //}

            //sum(4, 5, 6);
            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string Customername()
            //{
            //    return "Buse Yıldız";

            //}
            //Customername();

            //string StudentCard ()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard ());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard (string countryName,string capital ,string flagColor)
            //{
            //    string cardInfo = "Ülke: "+ countryName + "-  Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x,y,z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //CountryCard(x, y, z);

            //Console.WriteLine(   CountryCard(x, y, z) );


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum (int number1 , int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}
            //Console.WriteLine(Sum(15 , 52));
            //Console.WriteLine(Sum(18 , 82));
            //Console.WriteLine(Sum(25 , 42));
            //Console.WriteLine(Sum(44 , 98));

            #endregion

            #region Örnek uygulama 

            string ExamResult (string student,int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli Öğrenci Sınavı Geçti" + "Ortalama : " + result;
                }
                else
                {
                    return student + "Öğrenci Başarısız Oldu" + "Ortalama : " + result; ;
                }
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 85));

            #endregion


            Console.Read();

        }
    }
}
