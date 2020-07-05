using System;

namespace Dobbelsteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dobbelsteen dobbelsteen = new Dobbelsteen();

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                dobbelsteen.Gooi();
                Console.WriteLine(dobbelsteen.GetAantalOgen());
            }
            while (keyinfo.Key != ConsoleKey.Escape);
        }
    }
}
