using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Gato: Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }
        public override void Comer(double peso)
        {
            Console.WriteLine("Gato comeu " + peso*0.5 + " kg de ração");
        }
    }
}