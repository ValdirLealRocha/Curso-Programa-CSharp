// AULA 027 - https://youtu.be/5mptkK4KVZ8?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Argumento params
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
class PrincipalAula027 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis

    // executa o método...
    soma(10, 5);

    System.Console.WriteLine("-------------------------------------\n");
    // executa o método...
    soma1(); // sem valores como parametro
    soma1(6); // um valor como parametro
    soma1(10, 5, 2, 4, 7); // passando valores como parametro
  }

  // soma dois valores
  static void soma(int n1, int n2) {
    int res = n1 + n2;
    System.Console.WriteLine("A soma de {0} com {1} é {2}", n1, n2, res);
  }

  // soma dois valores com PARAMS
  static void soma1(params int[] n) {
    int res = 0;

    if(n.Length == 0) {
      System.Console.WriteLine("Não existem valores a serem somados!");
    }else if(n.Length == 1) {
      System.Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
    }else { // caso maior que 1
      for(int i =0; i < n.Length; i++) {
        res += n[i];
      }
      System.Console.WriteLine("A soma dos valores é: {0}", res);
    }
  }
}