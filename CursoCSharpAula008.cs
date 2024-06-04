// AULA 008 - https://youtu.be/jKM9NjtihmU?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Lendo valores do teclado
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
class PrincipalAula008 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int v1, v2, soma;
    string nome;

    // Pega o que está vendi do teclado...
    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Nome Digitado: {0}", nome);

    // Calculadora vinda do teclado...
    Console.Write("\nDigite o primeiro valor: ");
    // converte usando o int.Parse()
    v1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo valor: ");
    // converte usando o Convert.ToInt32()
    v2 = Convert.ToInt32(Console.ReadLine());
    soma = v1 + v2;
    Console.Write("A soma de {0} + {1} = {2}", v1, v2, soma);

  }
}