using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1
{
    public class Cachorro: Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au au");
        }
        public override void Comer(double peso)
        {
            Console.WriteLine("Cachorro comeu " + peso*2.0 + " kg de ração");
        }
    }
}