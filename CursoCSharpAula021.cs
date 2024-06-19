// AULA 021 - https://youtu.be/cIIJ-Gb4k6o?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Loop DO WHILE / Estruturas de iteração
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
using System.Globalization;

// nossa primeira classe
class PrincipalAula021 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    string senha = "123";
    string senhauser;
    int tentativas = 0;

    // lopping do while...
    // do while garante a primeira execução do bloco, com while não tem esta garantia...
    do {
      // limpa a tela
      Console.Clear();

      // imprime mensagem na tela...
      Console.WriteLine("Digite a senha: ");

      // captura senha do teclado...
      senhauser = Console.ReadLine();

      // incrementa tentativas
      tentativas++;
    } while (senha != senhauser);

      // limpa a tela
      Console.Clear();

      // imprime mensagem na tela...
      Console.WriteLine("Senha correta, tentativas: {0}", tentativas);

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    Console.WriteLine("FIM DO PROGRAMA---------------------");
    Console.WriteLine("------------------------------------");
  }
}