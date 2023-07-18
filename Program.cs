using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Bir Sayi Giriniz: ");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girilen Sayi: "+sayi);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata Oluştu! " + ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.Write("İslem Tamamlandi.");
            // }

            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-200000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok Küçük ya da çok büyük Bir Değer Girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.Write("İslem  Başariyla Tamamlandi.");
            }
        }
    }
}