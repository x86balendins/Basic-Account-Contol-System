using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(String[] args)
    {

      

        string basamak,isim="isim";
        int sifre=0,basamak1=0;

            try
            {
                Console.Write("Kullanici adinizi girin: ");
                isim = Console.ReadLine();
            }



            catch (FormatException)
            {

                Console.WriteLine("Gecersiz karakter");

            }


            catch (Exception ex)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        

        for(int i=0; i<1 ;){

            try
            {
                Console.Write("Sifrenizi girin: ");
                sifre = Convert.ToInt32(Console.ReadLine());
                basamak = sifre.ToString();
                basamak1 = basamak.Length;
                
                if (basamak1 != 4)
                {
                    Console.WriteLine("Şifre 4 basamaktan oluşmalı.");
                    continue;
                }

                else
                {
                    break;
                }
            }

            catch (FormatException) {
                Console.WriteLine("Gecersiz karakter");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu: " + ex.Message);
            }

            
        }

        if(isim == "Faruk" && sifre == 1234)
        {
            Console.WriteLine("Basarili Giris!");
        }

        else
        {
            Console.WriteLine("Basarisiz Giris!");
        }

    }
}