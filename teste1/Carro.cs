namespace teste1
{
    internal class Carro : VeiculoMotorizado
    {
        public string Nome;
        public Carro(string nome)
        {
            this.Nome = nome;
        }
        public override void LigarMotor()
        {
            Console.WriteLine( "Carro " + Nome + " ligando motor!");
        }

        public override void Emplacar()
        {
            Console.WriteLine("Carro " + Nome + " emplacando!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Carro " + Nome + " acelerando!");
        }

        public override void Frear()
        {
            Console.WriteLine("Carro " + Nome + " freando!");
        }
    }
}
