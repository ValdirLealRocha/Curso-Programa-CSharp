// AULA 006 - https://youtu.be/BVNhK3lQyww?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Formatando a saída no console
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
class PrincipalAula006 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int n1, n2, n3; // declaração em linha
    n1 = 10; n2 = 20; n3 = 30; // inicializa em linha
    Console.Write(n1 + ", " + n2 + ", " + n3);

    // Modelo de indices
    Console.Write("n1={0}, n2={1} e n3={2}", n1, n2, n3);
    
    // \n quebra linha
    Console.Write("\nn1={0}\nn2={1}\nn3={2}", n1, n2, n3);

    // \t tabulação
    Console.Write("\tn1={0}\tn2={1}\tn3={2}", n1, n2, n3);

    // declaração de variáveis - boas práticas no topo :)
    double valorCompra = 5.50;
    double valorVenda;
    double lucro = 0.1;
    string produto = "Pastel";

    // calcula venda
    valorVenda = (valorCompra + (valorCompra * lucro));

    // Qubra duas linhas
    Console.Write("\n\n");

    // {0,15} = {indice,tamanho}
    Console.WriteLine("Produto........: {0,15}", produto);
    // {0,15:c} = {indice,tamanho:formato monetário}
    Console.WriteLine("Valor de Compra: {0,15:c}", valorCompra);
    // {0,15:p} = {indice,tamanho:formato porcentagem}
    Console.WriteLine("Lucro..........: {0,15:p}", lucro);
    // {0,15:c} = {indice,tamanho:formato monetário}
    Console.WriteLine("Valor de Venda.: {0,15:c}", valorVenda);
  }
}