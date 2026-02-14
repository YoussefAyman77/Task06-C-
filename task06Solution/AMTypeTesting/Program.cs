using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace AMTypeTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeB t2 = new TypeB();
            Console.WriteLine(t2.H);
        }
    }
}
