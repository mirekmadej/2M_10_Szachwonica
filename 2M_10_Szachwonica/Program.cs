namespace _2M_10_Szachwonica
{

    class Szachownica
    {
        const int N = 8;
        private string[,] tab = new string[N+1,N+1];
                            // numerujemy od 1 do 8

        private bool czyCyfra(char z)
        {
            //1
            if(z>='0' && z <= '9')
                return true;
            return false;
            //2
            string cyfry = "0123456789";
            return cyfry.Contains(z);
            //3
            int x;
            return int.TryParse(cyfry, out x);

        }
        public string sprawdzPole(string pole)
        {  // a1 c3 F2
            //przygotować obsługę błędów:
            // ""
            //"a"
            //"k3"
            //"1a"
            //"bb"
            //"b12"
            pole = pole.ToLower();
            int w = int.Parse(pole[1].ToString());
            int k = pole[0]-'a'+1;
            if (tab[w, k] == null) return "__";
            return tab[w,k];
        }
        public bool ustawPole(string pole, string figura)
        {
            pole = pole.ToLower();
            int w = int.Parse(pole[1].ToString());
            int k = pole[0] - 'a' + 1;
            //kod powtarza się dwa razy - warto zrobić metodę
            //pola w klasie: w, k oraz czyPoprawne 
            if (tab[w,k]!=null)
                return false;
            tab[w, k] = figura;
            return true;
        }
        public void wyczyscPole(string pole)
        {
            pole = pole.ToLower();
            int w = int.Parse(pole[1].ToString());
            int k = pole[0] - 'a' + 1;
                // to już trzeci raz :)
                // hmm - a co będzie jeżeli ktoś poda złe pole?
                //dla złej nazwy zwrócić false?

            tab[w,k] = null;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Szachownica s1 = new Szachownica();
            Console.WriteLine(s1.sprawdzPole("A1"));
            Console.WriteLine(s1.ustawPole("A1","BW"));
            Console.WriteLine(s1.sprawdzPole("A1"));
            Console.WriteLine(s1.ustawPole("A1","BQ"));
            Console.WriteLine(s1.sprawdzPole("A1"));

         //   Console.WriteLine('b'-'a');
        }
    }
}