using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanieTransport
{
    class Masina
    {
        public string Model { get; set; }
        public double Capacitate { get; set; }
        public double DistantaParcursa { get; set; }
        public int TransporturiEfectuate { get; set; }
        public void Citire()
        {
            Console.Write("Model: ");
            Model = Console.ReadLine();

            Console.Write("Capacitate: ");
            Capacitate = double.Parse(Console.ReadLine());

            Console.Write("Distanta parcursa: ");
            DistantaParcursa = double.Parse(Console.ReadLine());

            Console.Write("Transporturi efectuate: ");
            TransporturiEfectuate = int.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void Afisare()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Capacitate: {Capacitate}");
            Console.WriteLine($"Distanta parcursa: {DistantaParcursa}");
            Console.WriteLine($"Transporturi efectuate: {TransporturiEfectuate}");
        }
    }
}
