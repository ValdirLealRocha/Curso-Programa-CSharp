// AULA 05 - https://youtu.be/f8rDk6nJ9DE?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Operadores e Operações
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
class PrincipalAula005 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    // Operadores '=' e '+'
    int res = 10 + 5;
    Console.WriteLine(res);

    // Operadores '=', '+' e '*' - precedencia na operação '()'
    res = (10 + 5) * 2; // os parenteses altera o resultado com e sem...
    Console.WriteLine(res);

    // Operadores relacional > < >= <= !=
    bool res1 = 10 < 5; // retorna false
    Console.WriteLine(res1);

    // Operadores de incremento e decremento - de 1 em 1
    int num1 = 10;
    //num1 = num1 + 1; // versão 1
    //num1 += 1;       // versão 2
    num1++;            // versão 3 - mais utilizada e o C# vai dar esta dica
    Console.WriteLine(num1);

    num1 +=10; // adição faz o mesmo: num1 = num1 + 10
    Console.WriteLine(num1);

    num1 -=10; // subtração faz o mesmo: num1 = num1 - 10
    Console.WriteLine(num1);

    num1 *=10; // multiplicação faz o mesmo: num1 = num1 * 10
    Console.WriteLine(num1);

    num1 /=10; // divisão faz o mesmo: num1 = num1 / 10
    Console.WriteLine(num1);

    // Operadores lógicos
    bool res2 = (5 > 3);
    Console.WriteLine(res2);

    // & = AND / E
    // operado & - todas as condições devem ser verdadeiras para validar a operação
    // V V = V
    // V F = F
    // F V = F
    // F F = F
    res2 = (5 > 7) & (10 > 5);
    Console.WriteLine(res2);

    // | - OR / OU
    // operador | - uma das condições deve ser verdadeira para validar a operação
    // V V = V
    // V F = V
    // F V = V
    // F F = F
    res2 = (5 > 7) | (10 < 5);
    Console.WriteLine(res2);

  }
}