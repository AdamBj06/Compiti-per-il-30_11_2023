using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_30_11_2023 //Esercizio 24.1
{
    internal class Quadrato
    {
        public float lato { get; set; }
        public float CalcolaSuperficeLato()
        {
            return lato * lato;
        }
    }
}
