using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketGame_ClassLibrary
{
    public class NormalPlayer : Player
    {

        public NormalPlayer(string name) : base(name)
        {
            this.Name = name;
        }

        public override int GetNumber()
        {            
            return CustomRandom.GetNext(); 
        }
    }
}
