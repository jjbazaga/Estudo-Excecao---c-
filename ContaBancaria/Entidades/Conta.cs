using System.Globalization;
using ContaBancaria.Entidades.Excecao;

namespace ContaBancaria.Entidades
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta()
        {
        }
        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double montante)
        {
            Saldo += montante;
        }
        public void Saque(double montante)
        {
            if(montante > LimiteSaque)
            {
                throw new DominioExcecao("Ultrapassou o limite de saque! "); 
            }
            else if(montante > Saldo)
            {
                throw new DominioExcecao("Limite de saldo ultrapassado! ");
            }
            Saldo -= montante;
        }
        public override string ToString()
        {
            return "Saldo da conta: "
                + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}