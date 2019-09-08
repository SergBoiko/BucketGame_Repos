using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketGame_ClassLibrary
{
    public class UberPlayer : Player
    {
        public UberPlayer(string name) : base(name)
        {
            this.Name = name;
        }

        private int currentNumber = 40;
        
        public override int GetNumber()
        {
            PlayersNumbers.Add(currentNumber);
            return currentNumber++;
        }
    }
}
