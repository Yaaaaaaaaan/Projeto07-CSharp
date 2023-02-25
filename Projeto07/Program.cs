using System;
using System.Globalization;

namespace Projeto07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();
            Console.WriteLine("Insira o nome do aluno;");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Insira as três do aluno;");
            al.N1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            al.N2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            al.N3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Nota final; " + al.NF().ToString("F2", CultureInfo.InvariantCulture));
            if (al.Aprovado())
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado, faltando apenas " + al.NR().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }

            Console.ReadLine();
        }
    }
}
