using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso.Exercicios
{
    public class Pessoa
    {
        private int idade;

        public Pessoa(int idadeInicial)
        {
            Idade = idadeInicial;  // Usando o setter para inicializar a idade, garantindo a validação.
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value < 0)
                {
                    idade = 0;  // Garante que a idade não seja negativa.
                }
                else
                {
                    idade = value;
                }
            }
        }

        public void Aniversario()
        {
            Idade++;  // Incrementa a idade por 1 a cada chamada, usando o setter para manter a validação.
        }
    }
}