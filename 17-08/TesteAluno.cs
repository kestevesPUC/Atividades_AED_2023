using System;
using System.Collections.Generic;
using System.Text;

namespace _17_08
{
    class TesteAluno
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Kaio", 24, 86.4, 'M');
            string sexo = a1.getSexo().ToString().ToLower() == "m" ? "Masculino" : "Feminino";

            Console.WriteLine($"Nome do aluno {a1.getNome()}");
            Console.WriteLine($"Idade do aluno {a1.getIdade()}");
            Console.WriteLine($"Peso do aluno {a1.getPeso().ToString("#.##")}");
            Console.WriteLine($"Sexo do aluno {sexo}");
        }
    }
}
