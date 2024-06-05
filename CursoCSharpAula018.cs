// AULA 018 - https://youtu.be/-w2-rlMcKhw?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Matrizes / Vetores Bidimensionais
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
class PrincipalAula018 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int[,] n = new int[3,5]; // 3 linhas e 5 colunas
    /*
     0  1  2  3  4
    10 20 30 40 50 - 0
    60 70 80 90 15 - 1
    25 35 45 55 65 - 2 
    */
    // linha 0
    n[0,0] = 10;
    n[0,1] = 20;
    n[0,2] = 30;
    n[0,3] = 40;
    n[0,4] = 50;

    // linha 1
    n[1,0] = 60;
    n[1,1] = 70;
    n[1,2] = 80;
    n[1,3] = 90;
    n[1,4] = 15;

    // linha 2
    n[2,0] = 25;
    n[2,1] = 35;
    n[2,2] = 45;
    n[2,3] = 55;
    n[2,4] = 65;

    Console.WriteLine("{0} {1} {2} {3} {4}", n[0,0], n[0,1], n[0,2], n[0,3], n[0,4]);
    Console.WriteLine("{0} {1} {2} {3} {4}", n[1,0], n[1,1], n[1,2], n[1,3], n[1,4]);
    Console.WriteLine("{0} {1} {2} {3} {4}", n[2,0], n[2,1], n[2,2], n[2,3], n[2,4]);

    // declaração e inicialização 
    int[,] num = new int[2,2]{{10,20}, {30,40}};
    }
}