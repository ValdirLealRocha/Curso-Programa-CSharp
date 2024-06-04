// AULA 03 - https://youtu.be/25gWhVRRYDI?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Variáveis
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
class PrincipalAula003 {
  
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    byte n1 = 10; // entre 0 e 255
    int num = 0;
    char letra = 'c'; // aspas simples para char e aspas duplas para string
    float valor = 5.3f; // C# exige o f no final da inicialização para identificar o float.
    string nome = "Bruno"; // aspas simples para char e aspas duplas para string

    var aux = nome; // var não definie o tipo da variável... Se define na compilação
    
    // mostra no terminal
    Console.WriteLine("\nValor da variável: " + aux);

    // Na aula declaro no ponto de estudo, 
    // boas práticas é sempre declarar no topo
    int num1, num2, res;

    // inicialização de variáveis
    num1 = 10;
    num2 = 2;
    res = num1 * num2;

    // mostra no terminal
    Console.WriteLine("\nA multiplicação de " + 
                      num1 + " com " + 
                      num2 + " é igual a: " + 
                      res);

    // mostra no terminal
    Console.WriteLine("\nA multiplicação de " + 
                      num1 + " com " + 
                      num2 + " é igual a: " + 
                      (num1 * num2));
  }

}