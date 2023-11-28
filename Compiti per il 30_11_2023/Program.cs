using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_30_11_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Es. 24.1
            Console.WriteLine("Inserisci il lato");
            Quadrato quadrato = new Quadrato();
            quadrato.lato = float.Parse(Console.ReadLine());
            Console.WriteLine("L'area è: " + quadrato.CalcolaSuperficeLato(quadrato.lato));
            Console.ReadKey();
        }
    }
}