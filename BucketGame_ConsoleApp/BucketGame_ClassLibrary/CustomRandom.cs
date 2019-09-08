using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketGame_ClassLibrary
{
    public class CustomRandom
    {
        public static Random rand = new Random();
        public static int GetNext()
        {
            return rand.Next(40, 140);
        }
    }
}
