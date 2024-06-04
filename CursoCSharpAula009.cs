// AULA 009 - https://youtu.be/Br1M23Qphmw?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Operações de Bitwise
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
class PrincipalAula009 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int num = 10;

    // BitWise deslocar em 1 a esquerda
    num = num << 1;
    Console.WriteLine(num);

    // BitWise deslocar em 1 a direita
    num = num >> 1;
    Console.WriteLine(num);

    // BitWise deslocar em 2 a esquerda
    num = 10;
    num = num << 2;
    Console.WriteLine(num);
  }
}