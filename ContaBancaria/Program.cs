﻿using System;
using System.Globalization;
using ContaBancaria.Entidades;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com dados da conta");
            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de saque: ");
            double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Entre com o montante de saque: ");
            double montanteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new Conta(numero, titular, saldo, limiteSaque);
            conta.Saque(montanteSaque);
            Console.WriteLine("Montante de saque: " + montanteSaque.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(conta);
            Console.WriteLine();
        }
    }
}