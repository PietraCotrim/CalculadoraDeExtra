using static System.Console; // Permite usar WriteLine diretamente
using System.Globalization;

namespace Calculadora
{
    public class Principal
    {
        static void Main(string[] args)
        {
            CultureInfo cultura = CultureInfo.InvariantCulture;

            WriteLine("Seja bem vindo(a)!");
            WriteLine("Digite o valor da sua hora:");
            double valorHora = double.Parse(ReadLine(), cultura);
            WriteLine("Digite quantas horas extras foram feitas:");
            double qtdHoras = double.Parse(ReadLine(), cultura);
            WriteLine("Sua hora extra vale quantos %:");
            double porcentagem = double.Parse(ReadLine(), cultura);
            double extra = valorHora * (1 + porcentagem / 100) * qtdHoras;

            double dsr = extra / 26 * 4;
            WriteLine($"Você irá receber aproximadamente R${extra:f2} de extra e aproximadamente R${dsr:f2} de DSR.");
        }
    }
}