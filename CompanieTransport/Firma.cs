using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanieTransport
{
    class Firma
    {
        public string NumeFirma { get; set; }

        public List<Masina> Masini { get; set; } = new List<Masina>();
        public List<Sofer> Soferi { get; set; } = new List<Sofer>();
        public List<Client> Clienti { get; set; } = new List<Client>();

        public void Citire()
        {
            Console.Write("Nume firma: ");
            NumeFirma = Console.ReadLine();
            Console.Clear();
        }

        public void Afisare()
        {
            Console.WriteLine($"\nFirma: {NumeFirma}");

            Console.WriteLine("\n--- Masini ---");
            foreach (var m in Masini)
                m.Afisare();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n--- Soferi ---");
            foreach (var s in Soferi)
                s.Afisare();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n--- Clienti ---");
            foreach (var c in Clienti)
                c.Afisare();
            Console.ReadKey();
            Console.Clear();
        }
        public void CitireDinFisier(string numeFisier)
        {
            // verificam daca fisierul exista
            if (!File.Exists(numeFisier))
            {
                Console.WriteLine("Fisierul nu a fost gasit!");
                return;
            }

            // evitam dublarea datelor
            Masini.Clear();
            Soferi.Clear();
            Clienti.Clear();

            string[] linii = File.ReadAllLines(numeFisier);

            foreach (string linie in linii)
            {
                if (string.IsNullOrWhiteSpace(linie))
                    continue;

                string[] parti = linie.Split(';');

                switch (parti[0])
                {
                    case "FIRMA":
                        NumeFirma = parti[1];
                        break;

                    case "MASINA":
                        Masina m = new Masina
                        {
                            Model = parti[1],
                            Capacitate = double.Parse(parti[2]),
                            DistantaParcursa = double.Parse(parti[3]),
                            TransporturiEfectuate = int.Parse(parti[4])
                        };
                        Masini.Add(m);
                        break;

                    case "SOFER":
                        Sofer s = new Sofer
                        {
                            Nume = parti[1],
                            TipTransport = parti[2],
                            Salariu = double.Parse(parti[3]),
                            Orar = parti[4]
                        };

                        // asignare masina dupa index
                        int indexMasina = int.Parse(parti[5]);
                        if (indexMasina >= 0 && indexMasina < Masini.Count)
                            s.MasinaAsignata = Masini[indexMasina];

                        Soferi.Add(s);
                        break;

                    case "CLIENT":
                        Client c = new Client
                        {
                            Nume = parti[1],
                            Telefon = parti[2],
                            Adresa = parti[3]
                        };
                        Clienti.Add(c);
                        break;
                }
            }
        }
    }
}
