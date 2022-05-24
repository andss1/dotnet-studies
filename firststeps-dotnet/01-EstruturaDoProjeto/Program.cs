using System;
using EstruturaDoProjeto.Exemplo;

namespace EstruturaDoProjeto{
    class Program {
        static void Main() {
            var pilha = new Pilha();

            pilha.Empilha(1);
            pilha.Empilha(10);
            pilha.Empilha(100);

            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
        }
    }
}