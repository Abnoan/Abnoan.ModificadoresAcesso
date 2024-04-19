using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso.Exercicios
{
    public class Termometro
    {
        private double temperaturaCelsius;

        public Termometro()
        {
            temperaturaCelsius = 20.0; // Temperatura inicial padrão
        }

        public void AjustarTemperatura(double novaTemperatura)
        {
            temperaturaCelsius = novaTemperatura;
        }

        public double LerTemperatura()
        {
            return temperaturaCelsius;
        }
    }
}