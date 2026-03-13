namespace CompanieTransport
{
    class Masina
    {
        public string Model { get; set; }
        public double Capacitate { get; set; }
        public double DistantaParcursa { get; set; }
        public int TransporturiEfectuate { get; set; }

        public void AfisareMasina()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Capacitate: {Capacitate}");
            Console.WriteLine($"Distanta parcursa: {DistantaParcursa}");
            Console.WriteLine($"Transporturi efectuate: {TransporturiEfectuate}");
        }
    }
    class Sofer
    {
        public string Nume { get; set; }
        public string TipTransport { get; set; }
        public double Salariu { get; set; }
        public string Orar { get; set; }

        public Masina MasinaAsignata { get; set; }

        public void AfisareSofer()
        {
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Tip transport: {TipTransport}");
            Console.WriteLine($"Salariu: {Salariu}");
            Console.WriteLine($"Orar: {Orar}");

            if (MasinaAsignata != null)
                Console.WriteLine($"Masina: {MasinaAsignata.Model}");
        }
    }
    class Firma
    {
        public string NumeFirma { get; set; }

        public List<Masina> Masini = new List<Masina>();
        public List<Sofer> Soferi = new List<Sofer>();
        public List<Client> Clienti = new List<Client>();

        public void AfisareFirma()
        {
            Console.WriteLine($"Firma: {NumeFirma}");
            Console.WriteLine($"Numar masini: {Masini.Count}");
            Console.WriteLine($"Numar soferi: {Soferi.Count}");
            Console.WriteLine($"Numar clienti: {Clienti.Count}");
        }
    }
    class Client
    {
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }

        public void AfisareClient()
        {
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Telefon: {Telefon}");
            Console.WriteLine($"Adresa: {Adresa}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma A = new Firma();
            A.NumeFirma = "Transport Rapid srl";

            Masina m1 = new Masina
            {
                Model = "Mercedes Sprinter",
                Capacitate = 1500,
                DistantaParcursa = 120000,
                TransporturiEfectuate = 350
            };

            Sofer s1 = new Sofer
            {
                Nume = "Popescu Ion",
                TipTransport = "Marfa",
                Salariu = 4500,
                Orar = "08:00 - 16:00",
                MasinaAsignata = m1
            };

            Client c1 = new Client
            {
                Nume = "Ion Popescu",
                Telefon = "0712345678",
                Adresa = "Suceava"
            };

            A.Clienti.Add(c1);
            A.Masini.Add(m1);
            A.Soferi.Add(s1);


            Firma B = new Firma();
            B.NumeFirma = "Local Transi pfa";

            Masina m2 = new Masina
            {
                Model = "Mercedes Sport",
                Capacitate = 500,
                DistantaParcursa = 8000,
                TransporturiEfectuate = 69
            };
            Masina m3 = new Masina
            {
                Model = "Minibus Capacity",
                Capacitate = 1000,
                DistantaParcursa = 3200000,
                TransporturiEfectuate = 2140
            };

            Sofer s2 = new Sofer
            {
                Nume = "Maria Iftode",
                TipTransport = "Marfa",
                Salariu = 1200,
                Orar = "12:30 - 22:00",
                MasinaAsignata = m2
            };
            Sofer s3 = new Sofer
            {
                Nume = "Nicu Pretoi",
                TipTransport = "Persoane",
                Salariu = 2400,
                Orar = "07:15 - 12:15",
                MasinaAsignata = m3
            };

            B.Masini.Add(m2);
            B.Soferi.Add(s2);
            B.Masini.Add(m3);
            B.Soferi.Add(s3);
            A.AfisareFirma();
            Console.WriteLine("  ");
            B.AfisareFirma();
            Console.ReadLine();
        }
    }
}