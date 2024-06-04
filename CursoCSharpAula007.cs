// AULA 007 - https://youtu.be/y5M_9AfhLs4?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Constantes em C#
// Em muitos casos vamos precisar usar as CONSTANTES 
// para não deixar mudar o valor no decorrer do programa
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
class PrincipalAula007 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    // constante após receber seu valor não poderá mudar mais no decorrer do programa
    const string canal = "CFB Cursos";
    const double pi = 3.1415;

    // canal = "Cursos"; // Vai dar erro, pois é uma constante... Não altera...

    // mostrar conteúdo...
    Console.WriteLine("Canal {0}\nPi: {1}", canal, pi);
    Console.WriteLine("Canal {0}", canal);
    Console.WriteLine("PI    {0}", pi);
  }
}