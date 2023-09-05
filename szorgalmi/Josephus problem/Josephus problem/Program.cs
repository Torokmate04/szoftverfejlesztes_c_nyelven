using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GIve me a number!!");
            string key = Console.ReadLine();
            int howmuch = int.Parse(key);
            Console.WriteLine($"If there are {howmuch} people and evryone kill the next person you should be the {problemJosephus(howmuch)} person to survive! Thanks me later!");







            int n = 7; // Number of people
            int survivor = Josephus(n);
            Console.WriteLine(survivor);
        }
        static int Josephus(int n)
        {
            // Base case: If there is only one person, return their position (1-based).
            if (n == 1)
                return 1;

            // Calculate the position of the survivor in a smaller circle (n-1 people) after the next person is eliminated.
            int smallerCircleSurvivor = Josephus(n - 1);

            // Calculate the position of the survivor in the original circle (n people) based on the position in the smaller circle.
            int position = (smallerCircleSurvivor % (n - 1)) + 1;

            return position;
        }

        public static int problemJosephus(int howmany)
        {
            double witch = 0;
            int pow = 0;
            while (witch <= howmany)
            {
                witch = Math.Pow(2, pow);
                pow++;
            }

            int maradek = howmany - (int.Parse(witch.ToString())/2) ;

         

            return  2 * maradek + 1;
        }
        static int recurzionJosephus(int howmany,int pow)
        {
            double currentnumber = Math.Pow(2, pow);
            if (currentnumber <= howmany)
            {
                return recurzionJosephus(howmany, pow++);
            }
            else
            {
                int maradek = howmany - (int.Parse(currentnumber.ToString()) / 2);
                return 2 * maradek + 1;
            }
        }
    }
}
