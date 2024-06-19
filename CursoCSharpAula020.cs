// AULA 020 - https://youtu.be/8g-G1QT9hCk?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Loop WHILE / Estruturas de iteração
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
class PrincipalAula020 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int[] num = new int[10];

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    // loopinh while...
    int i = 0;
    while( i < 10) {
      Console.WriteLine("Valor de i: {0}", i);
      i++;
    }

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    // loopinh while...
    i = 0;
    while( i < num.Length) {
      num[i] = 0;
      Console.WriteLine("Valor de num[{0}]: {1}", i, num[i]);
      i++;
    }

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    // loopinh while...
    i = 0;
    while( i < num.Length) {
      num[i] = i;
      Console.WriteLine("Valor de num[{0}]: {1}", i, num[i]);
      i++;
    }

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    // loopinh while...
    //i = 9;
    i = num.Length - 1;
    while( i > 0) {
      num[i] = i;
      Console.WriteLine("Valor de num[{0}]: {1}", i, num[i]);
      i--;
    }

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    Console.WriteLine("FIM DO PROGRAMA---------------------");
    Console.WriteLine("------------------------------------");
  }
}