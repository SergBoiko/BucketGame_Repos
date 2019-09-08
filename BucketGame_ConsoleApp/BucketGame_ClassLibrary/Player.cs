using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BucketGame_ClassLibrary
{
    public abstract class Player
    {
        public Player(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public abstract int GetNumber();

        protected static List<int> PlayersNumbers = new List<int>();
    }
}
