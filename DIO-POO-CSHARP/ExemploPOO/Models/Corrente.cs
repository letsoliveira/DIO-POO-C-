namespace ExemploPOO.Models
{
    //AULA CLASSE ABSTRATA - HERANÇA
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor;

        }
    }
}