using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Animal
    {
        public string? Raca { get; set; }
        public string? Tamanho { get; set; }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som generico de animal");
        }
        public virtual void Comer(double peso)
        {
            Console.WriteLine("Animal comeu " + peso*1.0 + " kg de ração");
        }
    }
}