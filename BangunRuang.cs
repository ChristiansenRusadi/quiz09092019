using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void luasbalok()
        {
        int panjang,lebar,tinggi,luas;
        Console.WriteLine("luas balok");
        Console.WriteLine("");

        Console.WriteLine("masukan nilai panjang");
        panjang = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("masukan nilai lebar");
        lebar =  Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("masukan nilai tinggi");
        tinggi = Convert.ToInt32(Console.ReadLine());

        luas = panjang * lebar * tinggi;
        }
         public void volumekubus()
         {
             int sisi,volume;
             Console.WriteLine("masukan nilai sisi : ");
             sisi = Convert.ToInt32(Console.ReadLine());

             volume = sisi * sisi * sisi;
         }
    }
}