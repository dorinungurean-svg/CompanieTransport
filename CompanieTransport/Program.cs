using System.IO;

namespace CompanieTransport
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma();

            firma.CitireDinFisier("date.txt");

            int optiune;

            do
            {
                Console.WriteLine("\n===== MENIU =====");
                Console.WriteLine("1. Setare nume firma");
                Console.WriteLine("2. Adauga masina");
                Console.WriteLine("3. Adauga sofer");
                Console.WriteLine("4. Adauga client");
                Console.WriteLine("5. Afisare firma");
                Console.WriteLine("0. Iesire");
                Console.Write("Alege optiunea: ");

                optiune = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (optiune)
                {
                    case 1:
                        firma.Citire();
                        break;

                    case 2:
                        Masina m = new Masina();
                        m.Citire();
                        firma.Masini.Add(m);
                        Console.WriteLine("Masina adaugata!");
                        break;

                    case 3:
                        if (firma.Masini.Count == 0)
                        {
                            Console.WriteLine("Nu exista masini disponibile!");
                            break;
                        }
                        Sofer s = new Sofer();
                        s.Citire();

                        Console.WriteLine("Alege masina pentru sofer:");
                        for (int i = 0; i < firma.Masini.Count; i++)
                        {
                            Console.WriteLine($"{i} - {firma.Masini[i].Model}");
                        }
                        int index = int.Parse(Console.ReadLine());
                        s.MasinaAsignata = firma.Masini[index];

                        firma.Soferi.Add(s);
                        Console.WriteLine("Sofer adaugat!");
                        break;

                    case 4:
                        Client c = new Client();
                        c.Citire();
                        firma.Clienti.Add(c);
                        Console.WriteLine("Client adaugat!");
                        break;

                    case 5:
                        firma.Afisare();
                        break;

                    case 0:
                        Console.WriteLine("Program inchis.");
                        break;

                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }

            } while (optiune != 0);
        }
    }
}