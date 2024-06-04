// AULA 013 - https://youtu.be/Ojm98Gg1rVw?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Condicional IF-ELSE
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
class PrincipalAula013 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // boas práticas de variáveis declaradas no topo
    // declaração de variáveis
    string resultado = "Nota inválida!";
    int n1, n2, n3, n4, res;
    n1 = n2 = n3 = n4 = res = 0;

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
    
    // estrutura condicional IF ELSE...
    //if((n1 + n2 + n3 + n4) >= 60) { 
    if(res >= 60) {
        resultado = "Aprovado";
    }else{
        resultado = "Reprovado";
    }
    Console.WriteLine("\nResultado: {0} com a Nota: {1}", resultado, res);

    // >= 60 - Aprovado
    // 59 e 20 - Recuperação
    // < 40 - Reprovado
    // estrutura condicional IF ELSE...
    if(res < 40) {
        resultado = "Reprovado";
    }else if(res < 60){
        resultado = "Recuperação";
    }else{
        resultado = "Aprovado";
    }
    Console.WriteLine("\nResultado: {0} com a Nota: {1}", resultado, res);
  }
}