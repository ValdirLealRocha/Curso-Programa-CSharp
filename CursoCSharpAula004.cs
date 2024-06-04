// AULA 004 - https://youtu.be/1tsK4u4Hmck?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Escopo de variáveis
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
class PrincipalAula004 {
  // variaveis global
  static int num = 10;

  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int num2 = 0; // scopo da variável somente dentro do Main() (local)...
    
    // o método teste não foi chamado... Só criado...

    // Como ficou global a classe, mostra o NUM e deve ser static, pois Main() é static
    Console.WriteLine(num);

    Console.WriteLine("Fim do Programa!");
  }

  // o método teste não foi chamado... Só criado... Exemplo só para o scopo de variável
  void Teste() { // C# exigiu que a primeira letra do método fosse maiúscula...
    int num3 = 0; // scopo da variável somente dentro do Teste() (local)...
    Console.WriteLine(num3);
  }
}