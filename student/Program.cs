// See https://aka.ms/new-console-template for more information
using student;

//Console.WriteLine("Hello, World!");


class program
{
    static void Main(string[] args)
    {
        Studentgrade ki = new Studentgrade();
        ki.id = 102213;
        ki.Name = "Ariyo Tetisimi";
        ki.age = 24;
        ki.course101 = 87;
        ki.course102 = 10;
        ki.PrintInfo();
        ki.printnow();
    }
}