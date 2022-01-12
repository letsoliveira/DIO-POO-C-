using System;
namespace ExemploPOO.Models
{
    //AULA HERANÇA
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        //AULA POLIMORFISMO
        public override void Apresentar()
        {
           Console.WriteLine($"Ola, meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}