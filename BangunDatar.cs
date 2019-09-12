using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
         public void luaspersegipanjang()
        {
            int panjang,lebar,luas;
             Console.WriteLine("Luas Persegi Panjang");
             Console.WriteLine("");

             Console.WriteLine("Masukan nilai panjang : ");
             panjang = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Masukan nilai lebar : ");
             lebar = Convert.ToInt32(Console.ReadLine());

             luas = panjang * lebar;

             Console.WriteLine("Luas Persegi Panjang adalah "+luas);
        }

        public void luassegitiga()
        {
            int alas,tinggi,luas;
            Console.WriteLine("Luas Segitiga");
            Console.WriteLine("");

            Console.WriteLine("Masukan nilai alas : ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi /2;

            Console.WriteLine ("luas segitiga adalah "+luas);
        }
            public void luaslingkaran()
            {
                int r,luas;
                Console.WriteLine("masukan nilai r : ");
                r = Convert.ToInt32(Console.ReadLine());

                luas = r * r * 22/7;
            }
        }   
    }    