using static System.Console; // Permite usar WriteLine diretamente
using System; // Biblioteca padrão

namespace Calculadora
{
    public class Principal
    {
        static void Main(string[] args)
        {
            WriteLine("Seja bem vindo(a)!");
            WriteLine("Digite o valor da sua hora:");
            double valorHora = double.Parse(ReadLine());
            WriteLine("Digite quantas horas extras foram feitas:");
            double qtdHoras = double.Parse(ReadLine());
            WriteLine("Sua hora extra vale quantos %:");
            double porcertagem = double.Parse(ReadLine());
            double extra = valorHora * (1 + porcertagem / 100) * qtdHoras;

            WriteLine($"Você irá receber aproximadamente R${extra} de extra.");
        }
    }
}