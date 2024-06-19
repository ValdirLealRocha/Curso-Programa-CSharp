// AULA 019 - https://youtu.be/cG1VokOCoJA?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Loop FOR / Estruturas de iteração
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
class PrincipalAula019 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis

    // looping for é muito utilizado quando sabe a quandidade de vezes
    Console.WriteLine("------------------------------------");
    for(int i = 0; i < 10; i++) { // i=i+1 ou i+=1 ou i++
      Console.WriteLine("Valor de num: {0}", i);
    }

    // looping for é muito utilizado quando sabe a quandidade de vezes
    int[] num = new int[10]; // declara um vetor
    Console.WriteLine("------------------------------------");
    for(int i = 0; i < num.Length; i++) { // i=i+1 ou i+=1 ou i++
      num[i] = 0;
      Console.WriteLine("Valor de num[{0}] = {1}", i, num[i]);
    }

    // looping for é muito utilizado quando sabe a quandidade de vezes
    int[] num1 = new int[10]; // declara um vetor
    Console.WriteLine("------------------------------------");
    for(int i = 0; i < num1.Length; i++) { // num1=num1+1 ou num1+=1 ou num1++
      num1[i] = i;
      Console.WriteLine("Valor de num1[{0}] = {1}", i, num1[i]);
    }

    // imprime na tela...
    Console.WriteLine("------------------------------------");
    Console.WriteLine("FIM DO PROGRAMA---------------------");
    Console.WriteLine("------------------------------------");
  }
}