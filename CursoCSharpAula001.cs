// AULA 001 - https://youtu.be/dVzJ3bx68FA?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Curso Programação Completo C#
// Na aula de hoje do curso programação C#, vamos baixar todo conteúdo necessário, 
// instalar as ferramentas e configurar tudo para que possamos aprende a programar em C#.
// C# é uma linguagem de programação, multiparadigma, desenvolvida pela Microsoft como 
// parte da plataforma .NET. A sua sintaxe orientada a objetos foi baseada no C++ mas inclui 
// muitas influências de outras linguagens de programação como Java.
// Nosso curso de C# será dividido em duas grandes partes, a primeira parte iremos aprender 
// toda lógica de programação usando a linguagem C# no Visual Studio Code, na segunda parte 
// iremos partir para a parte gráfica, usando o Visual Studio Community para criar programar 
// no padrão Windows, com formulários, botões, elementos interativos, relatórios e banco de dados.
// Instalamos:
// Run time - ndp481-x86-x64-allos-ptb.exe
// O SDK do .NET - dotnet-sdk-8.0.300-win-x64.exe
// Dev pack - ndp481-devpack-ptb.exe
// Configuramos a variável de ambiente do compilador do C#
// C:\Windows\Microsoft.NET\Framework64\v4.0.30319
// Programamos a saída de comandos no terminal
//
// NOTA: ir no termonal de comando e digitar csc <arquivo.cs>
//       isto irá compilar e criar um .exe deste arquivo .cs
//       e depois só digitar o nome do arquivo sem o .cs, e vai rodar no terminal...   
//
using System; // biblioteca das definições do C#, entrada e saída, console, tecklado...

// nossa primeira classe
class PrincipalAula001 {
  
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    Console.Write("Primeiro programa C#...");
  }

}