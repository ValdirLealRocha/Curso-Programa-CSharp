// AULA 026 - https://youtu.be/hUwprNIStBw?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Argumento out - retornar mais que um valor de retorno...
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
class PrincipalAula026 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int divid, divis, quoc, rest;

    //
    divid = 10;
    divis = 3;
    quoc = divide(divid, divis, out rest); // rest = testo que está dentro do método...

    Console.WriteLine("{0} / {1}: quociente={2} e resto={3}", divid, divis, quoc, rest);
  }
  
  // retornar dois parametros...
  static int divide(int dividendo, int divisor, out int resto) {
    int quociente;

    quociente = dividendo / divisor;
    resto = dividendo % divisor;

    return quociente;
  }
}