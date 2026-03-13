using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanieTransport
{
    class Client
    {
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }

        public void Citire()
        {
            Console.Write("Nume client: ");
            Nume = Console.ReadLine();

            Console.Write("Telefon: ");
            Telefon = Console.ReadLine();

            Console.Write("Adresa: ");
            Adresa = Console.ReadLine();
            Console.Clear();
        }

        public void Afisare()
        {
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Telefon: {Telefon}");
            Console.WriteLine($"Adresa: {Adresa}");
        }
    }
}
