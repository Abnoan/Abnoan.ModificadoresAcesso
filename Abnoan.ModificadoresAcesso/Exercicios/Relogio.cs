using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.ModificadoresAcesso.Exercicios
{
    public class Relogio
    {
        // Atributos privados para armazenar a hora, os minutos e os segundos
        private int hora;
        private int minuto;
        private int segundo;

        // Construtor que inicializa o relógio com uma hora específica
        public Relogio(int hora, int minuto, int segundo)
        {
            AjustarHoraCompleta(hora, minuto, segundo);  // Usamos um método interno para configurar a hora
        }

        // Propriedade pública para a hora com validação
        public int Hora
        {
            get { return hora; } // Retorna a hora atual
            set
            {
                // Valida e ajusta a hora, se necessário
                if (value >= 0 && value < 24)
                    hora = value;
                else
                    hora = 0;  // Redefine para 0 se o valor for inválido
            }
        }

        // Propriedade pública para os minutos com validação
        public int Minuto
        {
            get { return minuto; }  // Retorna o minuto atual
            set
            {
                // Valida e ajusta os minutos, se necessário
                if (value >= 0 && value < 60)
                    minuto = value;
                else
                    minuto = 0;  // Redefine para 0 se o valor for inválido
            }
        }

        // Propriedade pública para os segundos com validação
        public int Segundo
        {
            get { return segundo; }  // Retorna o segundo atual
            set
            {
                // Valida e ajusta os segundos, se necessário
                if (value >= 0 && value < 60)
                    segundo = value;
                else
                    segundo = 0;  // Redefine para 0 se o valor for inválido
            }
        }

        // Método para ajustar a hora completa
        public void AjustarHoraCompleta(int hora, int minuto, int segundo)
        {
            Hora = hora;      // Ajusta a hora usando a propriedade Hora
            Minuto = minuto;  // Ajusta os minutos usando a propriedade Minuto
            Segundo = segundo;  // Ajusta os segundos usando a propriedade Segundo
        }

        // Método para mostrar a hora no formato HH:mm:ss
        public string MostrarHora()
        {
            // Formata a hora, minutos e segundos em uma string
            return $"{Hora:00}:{Minuto:00}:{Segundo:00}";
        }
    }
}