using System;

namespace _008_structures_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Accountant accountant = new Accountant();
            bool premija = accountant.AskForBonus(Post.djun, 300);
            if (premija)
                Console.WriteLine("Срочно дайте ему премию!");
            else;
                Console.WriteLine("Премию не давать!");
        }
    }

    enum Post
    {
        djun = 240,
        midl = 160,
        senjor = 100 
    }

    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker <= hours)
                return true;
            else
                return false;
        }
    }
}
