using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso
{
    public class Maquina
    {
        // Atributos protegidos
        protected bool estaLigada;
        protected int velocidadeOperacao;
        
        // Construtor
        public Maquina()
        {
            this.estaLigada = false;
            this.velocidadeOperacao = 0;
        }

        // Método público para ligar a máquina
        public void Ligar()
        {
            if (!estaLigada)
            {
                estaLigada = true;
                AjustarVelocidade(10); // Configura uma velocidade inicial segura
                Console.WriteLine("Máquina ligada com sucesso!");
            }
        }

        // Método público para desligar a máquina
        public void Desligar()
        {
            if (estaLigada)
            {
                estaLigada = false;
                velocidadeOperacao = 0;
                Console.WriteLine("Máquina desligada com segurança.");
            }
        }

        // Método protegido para ajustar a velocidade da máquina
        protected void AjustarVelocidade(int novaVelocidade)
        {
            if (estaLigada && novaVelocidade > 0 && novaVelocidade <= 100)
            {
                velocidadeOperacao = novaVelocidade;
                Console.WriteLine($"Velocidade ajustada para {velocidadeOperacao} RPM.");
            }
            else
            {
                Console.WriteLine("Operação inválida: Verifique se a máquina está ligada e se a velocidade é adequada.");
            }
        }
    }

}