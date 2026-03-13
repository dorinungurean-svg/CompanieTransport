using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanieTransport
{
    class Sofer
    {
        public string Nume { get; set; }
        public string TipTransport { get; set; }
        public double Salariu { get; set; }
        public string Orar { get; set; }

        public Masina MasinaAsignata { get; set; }

        public void Citire()
        {
            Console.Write("Nume sofer: ");
            Nume = Console.ReadLine();

            Console.Write("Tip transport: ");
            TipTransport = Console.ReadLine();

            Console.Write("Salariu: ");
            Salariu = double.Parse(Console.ReadLine());

            Console.Write("Orar: ");
            Orar = Console.ReadLine();
            Console.Clear();
        }

        public void Afisare()
        {
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Tip transport: {TipTransport}");
            Console.WriteLine($"Salariu: {Salariu}");
            Console.WriteLine($"Orar: {Orar}");

            if (MasinaAsignata != null)
            {
                Console.WriteLine("Masina asignata:");
                MasinaAsignata.Afisare();
            }
        }
    }
}
