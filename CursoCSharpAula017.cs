// AULA 017 - https://youtu.be/utkQHvmmJ38?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Array / Vetor
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
class PrincipalAula017 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int[] n = new int[5];   // exemplo de um arry/vetor de 5 posiçõers do tipo int

    // o primeiro elemento do array é 0
    n[0] = 111;
    n[1] = 222;
    n[2] = 333;
    n[3] = 444;
    n[4] = 555;
    
    // mostra o valor na posição X
    Console.WriteLine("\nn[0]: {0} ", n[0]);

    // declarar e inicializar um array
    int[] num = new int[3]{55, 77, 99}; // Não permite add pois fixou com 3

    // mostra o valor na posição X
    Console.WriteLine("\nnum[2]: {0} ", num[2]);

    // declarar e inicializar simplificada
    int[] num1 = {55, 77, 99}; // a qtde de elementos define o tamanho do array

    // mostra o valor na posição X
    Console.WriteLine("\nnum1[0]: {0} ", num1[0]);

    // declaração e inicialização de array de string
    string[] veiculos = new string[3];

    veiculos[0] = "Carro";
    veiculos[0] = "Avião";
    veiculos[0] = "Navio";
    }
}