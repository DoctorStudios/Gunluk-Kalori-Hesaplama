using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Günlük_Kalori_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilo;
            int yaş;
            double boy;
            int cinsiyet = 0;
            double BMR = 0;
            int hareket = 0;
            double TDEE;
            double seçim;
            double sonuç;
        AnaMenu:
            Console.WriteLine("Bazal Metabolizma Hızını (BMR) Hesaplama");
            Console.WriteLine("Lütfen cinsiyetinizi girin:");
            Console.WriteLine("[1] Erkek:");
            Console.WriteLine("[2] Kadın:");
            cinsiyet = int.Parse(Console.ReadLine());
            switch (cinsiyet)
            {
                default:
                    Console.Clear();
                    Console.WriteLine("Lütfen Geçerli bir sayı giriniz;");
                    goto AnaMenu;

                case 1:
                    Console.WriteLine("Lütfen Kilonuzu girin");
                    kilo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen Boyunuzu girin");
                    boy = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen Yaşınızı girin");
                    yaş = int.Parse(Console.ReadLine());
                    BMR = (88.36 + (13.4 * kilo)) + (4.8 * boy) - (5.7 * yaş);
                    Console.WriteLine($"Bazal Metabolizma Hızınız {BMR}'dır");

                    break;

                case 2:
                    Console.WriteLine("Lütfen Kilonuzu girin");
                    kilo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen Boyunuzu girin");
                    boy = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lütfen Yaşınızı girin");
                    yaş = int.Parse(Console.ReadLine());
                    BMR = (447.6 + (9.2 * kilo)) + (3.2 * boy) - (4.3 * yaş);
                   
                    
                    break;





            }
        hareket:
            Console.Clear();
            Console.WriteLine("Gün içinde ne kadar hareket ediyorsunuz?");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("[1]Hareketsiz (masa başı, hiç spor yok)");
            Console.WriteLine("[2]Az aktif (haftada 1-3 gün hafif spor)");
            Console.WriteLine("[3]Orta aktif (haftada 3-5 gün orta düzey spor)");
            Console.WriteLine("[4]Çok aktif (haftada 6-7 gün ağır spor):");
            Console.WriteLine("[5]Aşırı aktif (profesyonel sporcu, ağır işçi):");
            hareket = int.Parse(Console.ReadLine());

            switch (hareket)
            {
                default:
                    Console.Clear();
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                    goto hareket;

                case 1:
                    TDEE = (BMR * 1.2);
                    break;
                case 2:
                    TDEE = (BMR * 1.375);
                    break;
                case 3:
                    TDEE = (BMR * 1.55);
                    break;
                case 4:
                    TDEE = (BMR * 1.725);
                    break;
                case 5:
                    TDEE = (BMR * 1.9);
                    break;

            }
        hedef:
            Console.Clear();
            Console.WriteLine("Hedefin nedir?");
            Console.WriteLine("--------------");
            Console.WriteLine("[1]Kilo vermek istiyorum");
            Console.WriteLine("[2]Kilo almak istiyorum");
            Console.WriteLine("[3]Kilomu korumak istiyorum");
            seçim = double.Parse(Console.ReadLine());
            switch (seçim)
            {
                default:
                    Console.Clear();
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                    goto hedef;
                case 1:
                    sonuç = (TDEE - 500);
                    break;
                case 2:
                    sonuç = (TDEE + 500);
                    break;
                case 3:
                    sonuç = (TDEE);
                    break;

            }
            Console.WriteLine($"Günlük almanız gerek kalori {sonuç} Kcal'dır");
        }
    }
}
