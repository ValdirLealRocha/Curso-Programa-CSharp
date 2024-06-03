// AULA 02 - https://youtu.be/2cGjyyw5ifQ?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Primeiro programa no padrão c# .net
// biblioteca padrão de uso no C#
//
// abrir terminal e digital na pasta do projeto:
// dotnet new console
//
// NOTA: ir no termonal de comando e digitar csc <arquivo.cs>
//       isto irá compilar e criar um .exe deste arquivo .cs
//       e depois só digitar o nome do arquivo sem o .cs, e vai rodar no terminal...   
//
using System;

// nossa primeira classe
class Principal {
  
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    Console.WriteLine("CF Cursos");
    // mostra um parametro capturado na linha de comando do terminal
    // valida se tem argumento vindo da linha de comando do terminal
    if(args.GetLength(0) > 0){
      Console.WriteLine(args.GetValue(0));
    }
  }

}