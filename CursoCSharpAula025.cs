// AULA 025 - https://youtu.be/TQ6hfImMkWk?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Passagem por valor e por referência
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
class PrincipalAula025 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int num = 10;

    dobrar2(num); // passagem por referencia...
    // mostra num
    Console.WriteLine(num);

    // executa o método
    //dobrar(num); // passagem por valor, num não muda...
    dobrar(ref num); // passagem por referencia...
    // mostra num
    Console.WriteLine(num);
  }

  // método para dobrar um determinado valor...
  static void dobrar(ref int valor) { // passando por referencia...
    valor *= 2;
  }

  // método para dobrar um determinado valor...
  static void dobrar2(int valor) { // passando por valor...
    valor *= 2;
  }
}