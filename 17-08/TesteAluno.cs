using System;
using System.Collections.Generic;
using System.Text;

namespace _17_08
{
    class TesteAluno
    {

        public static Aluno criaAluno()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Sexo: ");
            char sexo = Console.ReadLine();

            return (new Aluno(nome, idade, peso, sexo)); 
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Informe os seguintes dados: ");

            Aluno a1 = criaAluno(); 
            string sexo = a1.getSexo().ToString().ToLower() == "m" ? "Masculino" : "Feminino";

            Console.WriteLine($"Nome do aluno {a1.getNome()}");
            Console.WriteLine($"Idade do aluno {a1.getIdade()}");
            Console.WriteLine($"Peso do aluno {a1.getPeso().ToString("#.##")}");
            Console.WriteLine($"Sexo do aluno {sexo}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
