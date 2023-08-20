using System;

namespace Atividade_01
{
    class TesteAluno
    {
        public static bool perguntaFormado()
        {
            Console.WriteLine("Você já é formado?");
            Console.WriteLine("1- Sim");
            Console.WriteLine("2- Não");

            return int.Parse(Console.ReadLine()) == 1 ? true : false;
        }
        public static double perguntaPeso()
        {
            Console.Write("Peso: ");
            double peso = double.Parse(Console.ReadLine());
            return peso;
        }
        public static int perguntaIdade()
        {
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            return idade;
        }
        public static char perguntaSexo()
        {
            Console.WriteLine("Sexo: ");
            Console.WriteLine("1- Masculino \n2- Feminino");
            char sexo = char.Parse(int.Parse(Console.ReadLine()) == 1 ? "M" : "F");
            return sexo;
        }
        
        public static string perguntaNome()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            return nome;
        }


        public static Aluno criaAluno()
        {

            Console.WriteLine("Informe os seguintes dados: ");

            return (new Aluno(perguntaNome(), perguntaIdade(), perguntaPeso(), perguntaSexo()));
        }
        static void Main(string[] args)
        {
            Aluno a1 = criaAluno();

            Console.Clear();
            string sexo = a1.getSexo().ToString().ToLower() == "m" ? "Masculino" : "Feminino";

            Console.WriteLine($"Nome do aluno {a1.getNome()}");
            Console.WriteLine($"Idade do aluno {a1.getIdade()}");
            Console.WriteLine($"Peso do aluno {a1.getPeso().ToString("#.##")}");
            Console.WriteLine($"Sexo do aluno {sexo}");

            Console.WriteLine();
            Console.Clear();

            a1.setIdade(perguntaIdade());
            a1.setPeso(perguntaPeso());
            a1.setFormando(perguntaFormado());

            Console.Clear();

            Console.WriteLine($"Nome do aluno {a1.getNome()}");
            Console.WriteLine($"Idade do aluno {a1.getIdade()}");
            Console.WriteLine($"Peso do aluno {a1.getPeso().ToString("#.##")}");
            Console.WriteLine($"Sexo do aluno {sexo}");

            Console.ReadKey();
        }
    }
}
