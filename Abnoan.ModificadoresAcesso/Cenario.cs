using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso
{
    internal class Cenario
    {
        // Atributo interno para armazenar o ambiente atual
        internal string AmbienteAtual { get; private set; }

        // Construtor que define o ambiente inicial
        public Cenario(string ambienteInicial)
        {
            AmbienteAtual = ambienteInicial;
            Console.WriteLine($"Iniciando no ambiente: {AmbienteAtual}");
        }

        // Método para mudar o ambiente
        public void MudarAmbiente(string novoAmbiente)
        {
            AmbienteAtual = novoAmbiente;
            Console.WriteLine($"Ambiente alterado para: {AmbienteAtual}");
        }
    }
}