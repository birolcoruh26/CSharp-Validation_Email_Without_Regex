using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lütfen mailinizi giriniz");
            string kullanicimaili = Console.ReadLine();
            char[] harfdizisi = kullanicimaili.ToCharArray();
            string[] baslıkmailkısmı = kullanicimaili.Split('@');
            
            foreach (char c in harfdizisi)
            {
                if (Char.IsNumber(c) && c != '_' && c != '.' && c != '@')
                {
                    Console.WriteLine("girdiginiz mail hatalı: girilen mail da _,.,@ işaretleri olmalıdır");
                    break;
                }
            }

            if (baslıkmailkısmı.Count() != 2)
            {
                Console.Write("girdiginiz mail hatalı: mailiniz @ sornrası ve öncesi 2 karakter olmak zorundadır");
                
            }

            else if (baslıkmailkısmı[0].Length == 0 || baslıkmailkısmı[1].Length < 3 )
            {
                Console.Write("girdiginiz mail hatalı: çünkü @ öncesi karakter olmalı veya @ sonrası 3 karakterden fazla olmalı");
            }

            else if (!kullanicimaili.Contains(".com"))
            {
                Console.WriteLine("girdiginiz mail hatalı: mailinizda .com  olmaası gerekiyor");
            }
                

            else if (!Char.IsLetter((baslıkmailkısmı[0])[0]))
            {
                Console.WriteLine("girdiginiz mail hatalı: mailiniz başlangıç harfi sayı veya sembol olamaz");
            }

          else if (kullanicimaili.Contains("..") || kullanicimaili.Contains(".@") || kullanicimaili.Contains("@.") || kullanicimaili.Contains("._."))
            {
                Console.WriteLine("girdiginiz mail hatalı");
            }

         else if (kullanicimaili.EndsWith("."))
            {
                Console.WriteLine("girdiginiz mail hatalı: sonu (.) işareti ile bitemez");
            }

            else
            {
                Console.WriteLine("girdiğiniz mail doğru");
            }
            Console.ReadKey();
        }
    }
}
