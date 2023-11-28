using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti_per_il_30_11_2023 //Esercizio 28.1
{
    public class Scuola
    {
        public class Studente
        {
            public class Persona
            {
                public string Nome { get; set; }
                public string Cognome { get; set; }
                public DateTime DataDiNascita { get; set; }
            }
            public class Voto
            {
                public class Materia
                {
                    public string Descrizione { get; set; }
                    public int Id { get; set; }
                }
                public DateTime Data { get; set; }
                public int Valore { get; set; }
            }
        }
        public class Insegnante
        {
            public class Persona
            {
                public string Nome { get; set; }
                public string Cognome { get; set; }
                public DateTime DataDiNascita { get; set; }
            }
            public class Materia
            {
                public string Descrizione { get; set; }
                public int Id { get; set; }
            }
        }
    }
}