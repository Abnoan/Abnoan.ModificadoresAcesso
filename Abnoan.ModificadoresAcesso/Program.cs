// See https://aka.ms/new-console-template for more information
using Abnoan.ModificadoresAcesso.Exercicios;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");



        Termometro meuTermometro = new();
        meuTermometro.AjustarTemperatura(25.5);
        Console.WriteLine(meuTermometro.LerTemperatura());  // Deve imprimir: 25.5
        meuTermometro.AjustarTemperatura(22);
        Console.WriteLine(meuTermometro.LerTemperatura());  // Deve imprimir: 22

        Carro meuCarro = new();
        meuCarro.Ligar();
        meuCarro.Acelerar();
        meuCarro.Acelerar();
        Console.WriteLine(meuCarro.VerVelocidade());  // Deve imprimir: 20
        meuCarro.Desligar();

        Pessoa p = new(-5); // Tenta inicializar com uma idade negativa.
        Console.WriteLine(p.Idade);  // Deve imprimir: 0
        p.Aniversario();
        Console.WriteLine(p.Idade);  // Deve imprimir: 1
        p.Aniversario();
        Console.WriteLine(p.Idade);  // Deve imprimir: 2

        Relogio meuRelogio = new(14, 58, 59);
        Console.WriteLine(meuRelogio.MostrarHora());  // Deve imprimir: 14:58:59
        meuRelogio.AjustarHoraCompleta(25, 60, 60);  // Valores inválidos
        Console.WriteLine(meuRelogio.MostrarHora());  // Deve imprimir: 00:00:00
        meuRelogio.AjustarHoraCompleta(12, 30, 45);
        Console.WriteLine(meuRelogio.MostrarHora());  // Deve imprimir: 12:30:45
    }
}