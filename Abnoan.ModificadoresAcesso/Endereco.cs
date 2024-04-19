using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso
{
    public class Endereco
    {
        private string codigoPostal;
        public string CodigoPostal
        {
            get { return codigoPostal; }
            set
            {
                 // Garante que o código postal tenha exatamente 5 caracteres
                if (string.IsNullOrEmpty(value) || value.Length != 5) 
                {
                    throw new ArgumentException("Código postal fornecido é inválido. Deve conter 5 caracteres.");
                }
                codigoPostal = value;
            }
        }
        // Construtor
        public Endereco(string codigoInicial)
        {
            CodigoPostal = codigoInicial;
        }
    }
}