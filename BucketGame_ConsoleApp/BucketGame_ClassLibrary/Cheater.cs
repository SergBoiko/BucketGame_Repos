using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketGame_ClassLibrary
{
    public class Cheater : Player
    {
        public Cheater(string name) : base(name)
        {
            this.Name = name;
        }

        public override int GetNumber()
        {            
            int number = CustomRandom.GetNext();
            while (PlayersNumbers.Contains(number))
            {
                number = CustomRandom.GetNext();
            }
            PlayersNumbers.Add(number);
            return number;
        }
    }
}
