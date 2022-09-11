using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    internal class Bicicleta : Veiculo
    {
        public string Nome { get; set; }
        public Bicicleta(string nome)
        {
            this.Nome = nome;
        }

        public override void Acelerar()
        {
            Console.WriteLine("Bicicleta " + Nome + " acelerando!");
        }
        public override void Frear()
        {
            Console.WriteLine("Bicicleta " + Nome + " freando!");
        }
    }
}
