// AULA 024 - https://youtu.be/9A_nFLoRLU8?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Métodos
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
class PrincipalAula024 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    Console.WriteLine("-----------------------------------------");
    // executa o método
    cfb();

    Console.WriteLine("-----------------------------------------");
    // executa 10 vezes o método
    for (int i = 0; i < 10; i++) {
      cfb();
    }

    Console.WriteLine("-----------------------------------------");
    // executa o método
    soma(10, 20);

    Console.WriteLine("-----------------------------------------");
    int v1, v2;
    Console.WriteLine("Digite o valor 1: ");
    v1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor 2: ");
    v2 = Convert.ToInt32(Console.ReadLine());
    // executa o método
    soma(v1, v2);

    Console.WriteLine("-----------------------------------------");
    // executa o método
    Console.WriteLine("Digite o valor 1: ");
    v1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor 2: ");
    v2 = Convert.ToInt32(Console.ReadLine());
    int r = soma1(v1, v2);
    Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, r);
    Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, soma1(v1, v2));

    Console.WriteLine("\n-----------------------------------------");
  }

  // CRIAR MÉTODOS DENTRO DA CLASS...
  // mostrar texto na tela...
  static void cfb() {
    Console.WriteLine("CFB Cursos");
    Console.WriteLine("Curso de C#");
    Console.WriteLine("Bruno\n");
  }

  // somar dois valores
  static void soma(int n1, int n2) {
    int res = n1 + n2;
    Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);  
  }

  // somar dois valores
  static int soma1(int n1, int n2) {
    return n1 + n2; 
  }
}