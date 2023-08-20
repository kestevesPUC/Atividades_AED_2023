using System;

namespace Atividade_01._2
{
    class Teste
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Kaio", 1);
            Cliente c2 = new Cliente("Kaioba", 2);
            Cliente c3 = new Cliente("Kaioshin", 3);

            c1.atualizarLimite(65132);
            c1.atualizarCategoria(true);
            c2.atualizarCategoria(true);
            c2.atualizarLimite(84561);
            c3.atualizarCategoria(false);
            c3.atualizarLimite(654132);

            Console.WriteLine($"Cliente {c1.getCodigo()} é o: {c1.getNome()}");

            Console.WriteLine($"Cliente {c2.getCodigo()} é o: {c2.getNome()}");

            Console.WriteLine($"Cliente {c3.getCodigo()} é o: {c3.getNome()}");
        }
    }
}
