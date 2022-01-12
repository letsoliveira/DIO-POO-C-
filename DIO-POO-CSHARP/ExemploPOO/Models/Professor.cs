using System;
namespace ExemploPOO.Models
{
    //AULA HERANÇA
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar()
        {
           Console.WriteLine($"Ola, meu nome é {Nome} e sou um professor, ganho {Salario}");
        }
    }
}