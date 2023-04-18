using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class Studentdata
    {
        public string Name;
        public int id;
        public int age;

        public void PrintInfo()
        {
            Console.WriteLine( Name );
            Console.WriteLine(".......");
            Console.WriteLine(id);
            Console.WriteLine(".......");
            Console.WriteLine(age);
            Console.WriteLine("......");
        }
    }
}
