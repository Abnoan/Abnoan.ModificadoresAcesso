using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso
{
    public class ContaBancaria
    {
        // Saldo é um atributo interno privado
        private double saldo;
        public ContaBancaria(double saldoInicial)
        {
            // O saldo só pode ser definido na criação da conta
            saldo = saldoInicial;  
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito realizado: R$ {valor}");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > 0 && saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado: R$ {valor}");
            }
        }
        public double ConsultarSaldo()
        {
            // Apenas retorna o saldo sem permitir modificação direta
            return saldo;  
        }
    }
}