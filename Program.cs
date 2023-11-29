namespace Proje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz.");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz.");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınızı Giriniz.");
            string yas = Console.ReadLine();
            Console.WriteLine($"Merhaba {ad} {soyad} Yaşınız {yas} dir. ");
            Console.ReadKey();
        }
    }
}