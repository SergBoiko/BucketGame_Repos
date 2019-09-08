using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BucketGame_ClassLibrary;

namespace BucketGame_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Player> PlayersList = new List<Player>();

            Player normalPlayer = new NormalPlayer("Normal Player");
            PlayersList.Add(normalPlayer);

            Player textbookPlayer = new TextBookPlayer("TextBook Player");
            PlayersList.Add(textbookPlayer);

            Player uberPlayer = new UberPlayer("Uber Player");
            PlayersList.Add(uberPlayer);

            Player cheater = new Cheater("Cheater");
            PlayersList.Add(cheater);

            Player uberCheater = new UberCheater("Uber Cheater");
            PlayersList.Add(uberCheater);


            
            int bucketweight = CustomRandom.GetNext();
            Player closestPlayer = null;
            int closestWeight = 150;

            Console.WriteLine($"{bucketweight} is Bucket Weight");

            bool isgamefinished = false;

            for(int i = 0; i < 100; i++)
            {
                foreach (Player player in PlayersList)
                {
                    int number = player.GetNumber();
                    Console.WriteLine($"{player.Name} select number {number}");
                    if (number == bucketweight)
                    {
                        Console.WriteLine($"{player.Name} won");
                        isgamefinished = true;
                        break;
                    }
                    else if (Math.Abs(number - bucketweight) < closestWeight)
                    {
                        closestWeight = Math.Abs(number - bucketweight);
                        closestPlayer = player;
                    }
                }

                if (isgamefinished)
                {
                    break;
                }
            }

            if (!isgamefinished)
            {
                Console.WriteLine($"{closestPlayer.Name} won because he had closest guess");
            }

            Console.ReadKey();            
        }
                
    }
}
