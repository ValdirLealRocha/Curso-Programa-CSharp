// AULA 022 - https://youtu.be/n3Ns1_F7yUo?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Loop FOREACH / Estruturas de iteração
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
class PrincipalAula022 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    //int[] num = new int[3]{11, 22, 33}; // declara e inicializa o array...
    int[] num = new int[5]{11, 22, 33, 44, 55}; // declara e inicializa o array...

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    // forech para coleção...
    for(int i = 0; i < num.Length; i++) { // bom pra inicializar coleção...
      Console.WriteLine(num[i]);
    }

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    // looping próprio para percorrer uma coleção... Forech..
    foreach (int n in num) { // var deve ser igual ao tipo da coleção...
     Console.WriteLine(n);
    }

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    // forech para coleção...
    for(int i = 0; i < num.Length; i++) { // bom pra inicializar coleção...
      num[i] = 0;
    }

    // looping próprio para percorrer uma coleção... Forech..
    foreach (int n in num) { // var deve ser igual ao tipo da coleção...
     Console.WriteLine(n);
    }

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    Console.WriteLine("FIM DO PROGRAMA---------------------");
    Console.WriteLine("------------------------------------");
  }
}