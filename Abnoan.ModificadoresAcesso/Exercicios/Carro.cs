using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso.Exercicios
{
    public class Carro
    {
        private bool estado;  // true se o carro estiver ligado
        private int velocidade;  // velocidade em km/h

        public void Ligar()
        {
            estado = true;
        }

        public void Desligar()
        {
            estado = false;
            velocidade = 0;  // Resetar a velocidade quando o carro é desligado
        }

        public void Acelerar()
        {
            if (estado)
            {
                velocidade += 10;
            }
        }

        public int VerVelocidade()
        {
            return velocidade;
        }
    }

}