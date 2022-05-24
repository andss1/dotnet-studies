using System;
using Revisao;

Aluno[] alunos = new Aluno[5];
string opc = obterOpcao();
int idx = 0;

while (opc.ToUpper() != "X")
{
    switch (opc)
    {
        case "1":
            Console.WriteLine("Informe o nome do aluno:");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno:");
            if (decimal.TryParse(Console.ReadLine(), out decimal res))
                aluno.Nota = res;
            else {
                throw new ArgumentException("Valor da nota inválida!");
            }

            alunos[idx] = aluno;
            idx++;
            
            break;
        case "2":
            foreach (var alu in alunos){
                if (!string.IsNullOrEmpty(alu.Nome))
                    Console.WriteLine($"Aluno: {alu.Nome} - Nota: {alu.Nota}");
            }
            Console.WriteLine();
            break;
        case "3":
            decimal total = 0;
            var nrAlunos = 0;

            for (int i = 0; i < alunos.Length; i++) {
                if (!string.IsNullOrEmpty(alunos[i].Nome)) {
                    total += alunos[i].Nota;
                    nrAlunos++;
                }
            }

            var media = total / nrAlunos;
            Conceito conceitoGeral;

            if (media < 3) {
                conceitoGeral = Conceito.D;
            } else if (media < 5) {
                conceitoGeral = Conceito.C;
            } else if (media < 7) {
                conceitoGeral = Conceito.B;
            } else {
                conceitoGeral = Conceito.A;
            }

            Console.WriteLine($"Média da sala: {media} - Conceito: {conceitoGeral}");

            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    opc = obterOpcao();
}

static string obterOpcao()
{
    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine("1 - Adicionar novo aluno");
    Console.WriteLine("2 - Lista alunos");
    Console.WriteLine("3 - Mostrar média da sala");
    Console.WriteLine("X - Sair");
    Console.WriteLine();

    string opc = Console.ReadLine();
    return opc;
}
