using System;
namespace ExemploPOO.Models
{
    //AULA CLASSE SELADA
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
           Console.WriteLine($"Diretor");
        }
    }
}  