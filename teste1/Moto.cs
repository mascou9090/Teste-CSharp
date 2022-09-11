namespace teste1
{
    internal class Moto : VeiculoMotorizado
    {
        public string Nome;
        public Moto(string nome)
        {
            this.Nome = nome;
        }
        public override void LigarMotor()
        {
            Console.WriteLine("Moto " + Nome + " ligando motor!");
        }

        public override void Emplacar()
        {
            Console.WriteLine("Moto " + Nome + " emplacando!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Moto " + Nome + " acelerando!");
        }

        public override void Frear()
        {
            Console.WriteLine("Moto " + Nome + " freando!");
        }
    }
}
