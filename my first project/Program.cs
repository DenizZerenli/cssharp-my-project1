using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("*****Denizin Alış Veriş Dükkanı*****");

            int computerPrice, freezerPrice, shoesPrice, chairPrice, iphonePrice, androidPhonePrice;

            computerPrice = 47500;
            freezerPrice = 25500;
            shoesPrice = 1500;
            chairPrice = 900;
            iphonePrice = 90000;
            androidPhonePrice = 43500;

            int computerCount, freezerCount, shoesCount, chairCount, iphoneCount, androidPhoneCount;

            Console.WriteLine("Bilgisayar Fiyatı: " + computerPrice + " TL ");
            Console.WriteLine("Buzdolabı Fiyatı: " + freezerPrice + " TL ");
            Console.WriteLine("Ayakkabı Fiyatı: " + shoesPrice + " TL ");
            Console.WriteLine("Sandalye Fiyatı: " + chairPrice + " TL ");
            Console.WriteLine("İphone Fiyatı: " + iphonePrice + " TL ");
            Console.WriteLine("Android Telefon Fiyatı: " + androidPhonePrice + " TL ");

            Console.WriteLine();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Lütfen Aldığınız Bilgisayar Adetini Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Aldığınız Buzdolabı Adetini Giriniz: ");
            freezerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Aldığınız Ayakkabı Adetini Giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Aldığınız Sandalye Adetini Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Aldığınız İphone Adetini Giriniz: ");
            iphoneCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Aldığınız Android Telefon Adetini Giriniz: ");
            androidPhoneCount = int.Parse(Console.ReadLine());

            Console.Clear();

            int totalPrice = computerCount * computerPrice + freezerCount * freezerPrice + shoesCount * shoesPrice + chairCount * chairPrice + iphoneCount * iphonePrice + androidPhoneCount * androidPhonePrice;

            Console.WriteLine("-------------------");
            Console.WriteLine("Toplam ödemeniz Gereken Tutar: " + totalPrice + " TL ");
            Console.WriteLine();

            int taksit = 1;

            Console.WriteLine("Ödeme Yolları: Kredi Kartı,PAPARA,PAYPAL,PAYOONER");
            Console.WriteLine();
            Console.WriteLine("Lütfen Yukarıdaki Ödeme Yollarından Birini Seçin");
            string paymentMethod = Console.ReadLine().ToLower();

            Console.Clear();

            switch (paymentMethod)
            {
                case "kredi kartı":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Kredi Kartı Seçildi");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Taksit Seçenekleri: 3,6,9,12 Ay");

                    bool validtaksit = false;
                    while (!validtaksit)
                    {
                        Console.WriteLine("Kaç Taksit Yapmak istiyorsunuz");
                        validtaksit = int.TryParse(Console.ReadLine(), out taksit);
                        if (!validtaksit || (taksit != 3 && taksit != 6 && taksit != 9 && taksit != 12))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Geçersiz taksit seçimi! Lütfen 3,6,9 veya 12 giriniz.");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            validtaksit = false;
                        }
                    }
                    break;

                case "papara":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PAPARA Seçildi");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Taksit Seçenekleri Malesef Mevcut Değildir Tek Çekim Mevcuttur");
                    taksit = 1;
                    break;

                case "paypal":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PAYPAL Seçildi");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("PAYPAL Uygulamasında Taksit Seçeneği Mevcut değildir Tek Çekim Mevcuttur");
                    taksit = 1;
                    break;

                case "payooner":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("PAYOONER Seçilmiştir");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Taksit Seçenekleri Malesef Mevcut Değildir Tek Çekim Mevcuttur");
                    taksit = 1;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geçersiz Ödeme Yöntemi Seçtiniz.");
                    taksit = 1;
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine();

            decimal aylikOdeme = (decimal)totalPrice / taksit;
            Console.WriteLine($"Her ay ödenecek miktar: {aylikOdeme:F2} TL ({taksit} taksit)");
            Console.WriteLine();

            Console.WriteLine("Ödemeyi Onaylamak İstiyormusunuz (Evet / Hayır )");
            string confirm = Console.ReadLine().ToLower();

            if (confirm == "evet" || confirm == "e")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ödeme Onaylandı ");
            }
            else if (confirm == "hayır" || confirm == "h")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ödeme Onaylanmadı ");
            }

            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
