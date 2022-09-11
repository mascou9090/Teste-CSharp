using System;
using System.Collections.Generic;

namespace teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> Veiculos = new List<Veiculo>();
                Veiculos.Add(new Bicicleta("Kaloi"));
                Veiculos.Add(new Bicicleta("Monark"));
                Veiculos.Add(new Carro("Celta"));
                Veiculos.Add(new Carro("Corsa"));
                Veiculos.Add(new Carro("Corola"));
                Veiculos.Add(new Carro("Audi"));
                Veiculos.Add(new Moto("Titan"));
                Veiculos.Add(new Moto("Start"));
                Veiculos.Add(new Moto("Fazer"));
                Veiculos.Add(new Moto("Bros"));

         
            foreach (Veiculo Automovel in Veiculos)
            {
                switch (Automovel.GetType().Name)
                {
                    case "Carro":
                    case "Moto":
                        var CarroMotorizado = (VeiculoMotorizado)Automovel;
                        CarroMotorizado.LigarMotor();
                        CarroMotorizado.Emplacar();
                        break;
                }
                Automovel.Acelerar();
                Automovel.Frear();
               
            }
        }


    }
}
