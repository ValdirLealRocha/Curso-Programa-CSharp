// AULA 012 - https://youtu.be/m_0y_k-sCcI?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Comando condicional IF
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
class PrincipalAula012 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int nota = 80;
    string resultado = "Reprovado";

    // estrutura condicional IF
    if(nota >= 60) {
        resultado = "Aprovado";
    }
    Console.WriteLine("Resultado: {0}", resultado);

    // atualizando variaveis
    nota = 50;
    resultado = "Reprovado";
    // estrutura condicional IF
    if(nota >= 60) {
        resultado = "Aprovado";
    }
    Console.WriteLine("Resultado: {0}", resultado);

    // pega o que foi digitado...
    nota = int.Parse(Console.ReadLine());

    resultado = "Reprovado";
    // estrutura condicional IF
    if(nota >= 60) {
        resultado = "Aprovado";
    }
    Console.WriteLine("Resultado: {0}", resultado);

    // boas práticas de variáveis declaradas no topo
    int n1, n2, n3, n4, res;
    n1 = n2 = n3 = n4 = res = 0;

    resultado = "Reprovado";

    // pega do teclado...
    Console.Write("Digite a nota 1: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite a nota 2: ");
    n2 = int.Parse(Console.ReadLine());
    Console.Write("Digite a nota 3: ");
    n3 = int.Parse(Console.ReadLine());
    Console.Write("Digite a nota 4: ");
    n4 = int.Parse(Console.ReadLine());

    res = n1 + n2 + n3 + n4;
    
    // estrutura condicional IF
    //if((n1 + n2 + n3 + n4) >= 60) { 
    if(res >= 60) {
        resultado = "Aprovado";
    }
    Console.WriteLine("\nResultado: {0} com a Nota: {1}", resultado, res);
  }
}