class Program
{
    class Tablica
    {
        private int[] tablica;
        private int liczbaElementowTablicy;
        Random random = new Random();

        public Tablica(int liczbaElementowTablicy)
        {
            tablica = new int[liczbaElementowTablicy];
            this.liczbaElementowTablicy = liczbaElementowTablicy;
            for (int i = 0; i < liczbaElementowTablicy; i++)
            {
                tablica[i] = random.Next(1, 1000);
            }
        }

        // **********************************************
        // nazwa metody: WyswietlWszystkieElementyTablicy
        // opis metody: iteruje po elementach tablicy i wypisuje je w konsoli razem z indeksem
        // parametry: brak
        // zwracany typ i opis: tekst indeksu i po dwukropku elementu tablicy
        // autor: 0017
        // ***********************************************
        public void WyswietlWszystkieElementyTablicy()
        {
            Console.WriteLine("Wszystkie elementy tablicy");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(i+": "+tablica[i]);
            }
        }

        // **********************************************
        // nazwa metody: WyszukiwanieLiczby
        // opis metody: iteruje po tablicy i porównuje wartość z wartością liczby podanej w parametrze, jeżeli ją znajdzie wyświetli jej indeks, jeżeli nie, zwraca -1 i nie wyświetla nic
        // parametry: "wyszukiwana" int, liczba której metoda wyszukuje w tablicy
        // zwracany typ i opis: w przypadku znalezienia liczby tekst w konsoli, w przeciwnym razie int -1
        // autor: 0017
        // ***********************************************
        public int WyszukiwanieLiczby(int wyszukiwana)
        {
            Console.WriteLine("Wyszukiwanie liczby "+wyszukiwana);
            for (int i = 0; i < tablica.Length; i++)
            {
                if (wyszukiwana == tablica[i])
                {
                    Console.WriteLine(i);
                }
                return -1;
            }
            return -1;
        }

        // **********************************************
        // nazwa metody: NieparzysteZTablicy
        // opis metody: iteruje po tablicy i wypisuje liczby nieparzyste znajdujące się w tablicy
        // parametry: brak
        // zwracany typ i opis: tekst liczby
        // autor: 0017
        // ***********************************************
        public void NieparzysteZTablicy()
        {
            int liczbaNieparzystych = 0;
            Console.WriteLine("Liczby nieparzyste:");
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] % 2 != 0)
                {
                    liczbaNieparzystych += 1;
                    Console.WriteLine(tablica[i]);
                }
            }
        }

        // **********************************************
        // nazwa metody: SredniaArytmetycznaLiczb
        // opis metody: iteruje po tablicy i sumuje wszystkie elementy, potem dzieli je przez długość tablicy
        // parametry: brak
        // zwracany typ i opis: tekst "Średnia wszystkich elementów" i średnią
        // autor: 0017
        // ***********************************************
        public void SredniaArytmetycznaLiczb()
        {
            int suma = 0;
            int srednia;
            for (int i = 0; i < tablica.Length; i++)
            {
                suma += tablica[i];
            }
            srednia = suma / tablica.Length;
            Console.WriteLine("Średnia wszystkich elementów: "+srednia);
        }
    }

    static void Main()
    {
        Tablica program = new Tablica(50);
        program.WyswietlWszystkieElementyTablicy();
        program.WyszukiwanieLiczby(123);
        program.NieparzysteZTablicy();
        program.SredniaArytmetycznaLiczb();
    }
}