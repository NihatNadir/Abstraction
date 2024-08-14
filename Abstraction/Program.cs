using System;
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Profession(); // Employee sınıfının türünden Profession nesnesi oluşturuyoruz.

            employee1.Name = "Ali"; // Nesnenin bilgilerini giriyoruz.

            employee1.SurName = "Güneş"; // Nesnenin bilgilerini giriyoruz.

            Console.WriteLine($"{employee1.Name} yaptığınız işi giriniz.");

            employee1.Mission(); // Nesnenin çalıştığı pozisyon bilgisi metot içerisinde girilecek ve ekranda yazdırılacak.


            // ------------------------------------------------------------------------

            Employee employee2 = new Profession();

            Console.WriteLine("\nAdınızı giriniz...");

            employee2.Name = Console.ReadLine() ?? ""; // Nesnenin bilgilerini konsoldan giriyoruz.

            Console.WriteLine("Soyadınızı giriniz...");

            employee2.SurName = Console.ReadLine() ?? ""; // Nesnenin bilgilerini konsoldan giriyoruz.

            Console.WriteLine($"{employee2.Name} yaptığınız işi giriniz.");

            employee2.Mission(); // Nesnenin çalıştığı pozisyon bilgisi metot içerisinde girilecek ve ekranda yazdırılacak.

        }
    }
}