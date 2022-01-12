using System;

namespace ExemploPOO.Models
{
    //AULA ABSTRAÇÃO
    public class Pessoa
    {
        public string Nome {get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }
        //AULA POLIMORFISMO
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}