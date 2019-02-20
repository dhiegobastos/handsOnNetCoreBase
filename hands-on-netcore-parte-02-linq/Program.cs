using System;
using System.Collections.Generic;
using System.Linq;
using hands_on_netcore.Model;
using hands_on_netcore.Service;

namespace hands_on_netcore_parte_02_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var turmas = TurmaService.ObterTurmas();

            // Quantidade de alunos em todas as turmas
            var quatidadeTotalAlunos = -1;
            Console.WriteLine($"1) Quantidade de alunos em todas as turmas: {quatidadeTotalAlunos}");

            // Quantidade de alunos distintos entre todas as turmas
            var quatidadeDistintoslunos = -1;
            Console.WriteLine($"2) Quantidade de alunos distintos entre todas as turmas: {quatidadeDistintoslunos}");

            // Maior nota entre todos os alunos
            var maiorNota = -1;
            Console.WriteLine($"3) Maior nota entre todos os alunos: {maiorNota}");

            // Quantidade de alunos do sexo masculino
            var quantidadeAlunosM = -1;
            Console.WriteLine($"4) Quantidade de alunos do sexo masculino: {quantidadeAlunosM}");

            // Media de nota por turma
            var mediaNotaAlunoPorTurma = new int[] { -1, -1 };
            Console.WriteLine($"5) Média nota por turma:");
            foreach (var turma in mediaNotaAlunoPorTurma)
            {
                //Console.WriteLine($"\tTurma: {turma.NomeTurma} - Média: {turma.Media}");
            }

            // Nome da turma com maior número de alunos
            var maiorTurma = new Turma() { NomeTurma = "", Alunos = new List<Aluno>() };
            Console.WriteLine($"6) Turma que tem o maior número de alunos: {maiorTurma.NomeTurma} - Quantidade de alunos: {maiorTurma.Alunos.Count()}");

            // Quantidade de alunas mulheres que fazem parte de mais de uma turma
            var quantidadeMulheres = -1;
            Console.WriteLine($"7) Quantidade de alunas que fazem parte de mais de uma turma: {quantidadeMulheres}");
        }
    }
}