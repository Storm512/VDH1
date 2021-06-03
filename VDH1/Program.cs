using System;
using VDH1.Teachers.Niels;

namespace VDH1
{
    class Program
    {
        // Code momments.
        static void Main(string[] args)
        {
            Students.Kasper.KS ks = new Students.Kasper.KS();
            Console.WriteLine((new Niels()).FullName);
            Console.WriteLine(ks.GetName());
        }
    }
}
