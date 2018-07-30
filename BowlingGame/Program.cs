using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            Console.Beep();
            int[] myScores = new int[22];
            bowlingTotal(myScores);
            for (int z = 0; z < 4; z++)
            {
                Console.Beep();
            }
        }

        public static int bowlingTotal(int[] scores)
        {
            int total = 0;
            int myLength = scores.Length; 
            for (int i = 0; i < myLength; i += 2)
            {
                int frameTotal = 0;
                if (i == 18 && scores.Length == 20)
                {
                    frameTotal = scores[i] + scores[i + 1];
                    if (scores[i] == 10)
                    {
                        frameTotal += Strike(scores, i);
                    }
                    else if (frameTotal == 10)
                    {
                        frameTotal += Spare(scores, i);
                    }

                }
                else if (i == 18 && scores.Length == 21)
                {
                    frameTotal = scores[i] + scores[i + 1] + scores[i + 2];
                }

                total += frameTotal;

            }


            return total;
        }

        public static int Strike(int[] scores, int position)
        {
            int bonusPoints = 0;
            bonusPoints += scores[position + 2];
            if (scores[position + 2] == 10)
            {
                bonusPoints += scores[position + 4];
            }
            else
            {
                bonusPoints += scores[position + 3];
            }
            return bonusPoints;
        }

        public static int Spare(int[] scores, int position)
        {
            int bonusPoints = 0;
            bonusPoints += scores[position + 2];
            return bonusPoints;
        }
    }
}
