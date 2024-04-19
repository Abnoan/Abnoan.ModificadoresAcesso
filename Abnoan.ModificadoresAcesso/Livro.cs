using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso
{
    public class Livro
    {
        #region Propriedades públicas
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int CopiasDisponiveis { get; set; }

        #endregion

        // Atributos privados para detalhes internos
        private int numeroDeEdicoes;
        private DateTime dataUltimaEdicao;
        
        // Construtor para inicializar um novo livro
        public Livro(string titulo, string autor, int copias)
        {
            Titulo = titulo;
            Autor = autor;
            CopiasDisponiveis = copias;
            numeroDeEdicoes = 1;  // Inicializa com 1 edição ao criar o livro
            dataUltimaEdicao = DateTime.Now;  // A data da última edição é hoje
        }
        // Método privado para atualizar edições
        private void AtualizarEdicao()
        {
            numeroDeEdicoes++;
            dataUltimaEdicao = DateTime.Now;
        }
        // Método público para exibir informações do livro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Cópias disponíveis: {CopiasDisponiveis}");
            Console.WriteLine($"Número de edições: {numeroDeEdicoes}");
            Console.WriteLine($"Última edição: {dataUltimaEdicao.ToShortDateString()}");
        }
    }
}