using System;

namespace Type_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //x.ToString() Methodu
            int a = 6;
            string b = a.ToString();
            Console.WriteLine(b);
            string c = 12.5f.ToString();
            Console.WriteLine(c);
            string d = 'k'.ToString();
            Console.WriteLine(d);
            //System.Convert sınıfı
            string s1, s2;
            int sayi1, sayi2;
            int Toplam;
            Console.Write("Birinci sayıyı girin: ");
            s1 = Console.ReadLine();
            Console.Write("İkinci sayıyı girin: ");
            s2 = Console.ReadLine();
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.Write("Toplam= " + Toplam);
        }
    }
}
