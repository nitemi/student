using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class Studentgrade: Studentdata
    {
       public int course101;
        public int course102;

        public void printnow() 
        {
            if (course101 + course102 >= 176)
             {
                Console.WriteLine ("A");

            }
            else
                Console.WriteLine ("B");

        }
    }
}
