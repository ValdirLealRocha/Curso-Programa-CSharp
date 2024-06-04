// AULA 010 - https://youtu.be/kj_-Brm4DDI?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Enumeradores (enum)
//
// abrir terminal e digital na pasta do projeto:
// dotnet new console >>>> tem que ser num terminal cmd
//
// NOTA: ir no termonal de comando e digitar csc <arquivo.cs>
//       isto irá compilar e criar um .exe deste arquivo .cs
//       e depois só digitar o nome do arquivo sem o .cs, e vai rodar no terminal...   
//
// C# é fortemente tipado!!!
//
// biblioteca padrão de uso no C#
using System;

// nossa primeira classe
class PrincipalAula010 {

  // enumerator cada elemento tem um indice, e não pode mudar no decorrer do programa
  enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    DiasSemana ds = DiasSemana.Domingo;
    Console.WriteLine(ds);

    // usando o indice
    DiasSemana ds1 = (DiasSemana)3;
    Console.WriteLine(ds1);

    // usando o variável e casting de conversão
    int n1 = (int)DiasSemana.Sexta;
    Console.WriteLine(n1);
  }
}