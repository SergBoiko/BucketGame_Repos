using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketGame_ClassLibrary
{
    public class TextBookPlayer : Player
    {
        public TextBookPlayer(string name) : base(name)
        {
            this.Name = name;
        }

        private List<int> GuessedNumbers = new List<int>();
        public override int GetNumber()
        {            
            int number = CustomRandom.GetNext();
            while (GuessedNumbers.Contains(number))
            {
                number = CustomRandom.GetNext();
            }
            GuessedNumbers.Add(number);
            PlayersNumbers.Add(number);
            return number;
        }
    }
}
