// AULA 059 - https://youtu.be/RdNbnZ7ioF4?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Coleção Queue (Fila)
// abrir terminal e digital na pasta do projeto:
// dotnet new console >>>> tem que ser num terminal cmd
//
// NOTA: ir no termonal de comando e digitar csc <arquivo.cs>
//       isto irá compilar e criar um .exe deste arquivo .cs
//       e depois só digitar o nome do arquivo sem o .cs, e vai rodar no terminal...   
//
// C# é fortemente tipado!!!
//
// [ModificadorClasse] class NOME_DA_CLASSE {
//   //Variaveis / propiedades
//   [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
//   
//    //Métodos
//    [EspecificadorAcesso] retorno NOME_METODO([arg1, ...]) {
//      //Corpo do método
//    }
//  }
//
// **************************************************************************** 
// ModificadorClasse: Define a visibilidade da classe
//   //public: Pública, sem restrição de visualização
//   //abstract: Classe-Base_ para outras classes, não podem ser instanciados
//   //          objetos desta classe
//   //sealed: Classe não pode ser herdada
//   //static: Classe não permite a instanciação de objetos e seus
//   //        membros devem ser static também...
//
// EspecificadorAcesso: Onde um membro da classe pode ser acessado
//   //public: Sem restrição de acesso
//   //private: Só podem ser acessado pela própria classe
//   //protected: Podem ser acessados na própria classe e nas classes derivadas
//   //abstract: Os métodos não tem implementaão somente os cabeçalhos
//   //sealed: O método não pode ser redefinido
//   //virtual: O método pode ser redefinido em uma classe derivada
//   //static: O método pode ser chamado mesmo sem a instanciação de um objeto
// **************************************************************************** 
//
// biblioteca padrão de uso no C#
using System;
using System.Collections.Generic;

// nossa primeira classe
class PrincipalAula059 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) { // lista de argumentos do programa...
    // declaração de variáveis
    // Queue é semelhante a FIFO
    //string[] v = {"Carro", "Moto", "Navio", "Avião"};
    //Queue<string> veiculos = new Queue<string>(v); // já inicializa...
    Queue<string> veiculos = new Queue<string>();

    // add elementos no final da fila...
    veiculos.Enqueue("Carro");
    veiculos.Enqueue("Moto");
    veiculos.Enqueue("Navio");
    veiculos.Enqueue("Avião");

    Console.WriteLine("--------------------------------------------------");

    // verifica se o elemento existe...
    string v = "Avião";
    if(veiculos.Contains(v)) {
      Console.WriteLine("{0} encontrado na FILA!", v);
    }else {
      Console.WriteLine("{0} NÃO encontrado na FILA.", v);
    }

    Console.WriteLine("--------------------------------------------------");

    // mostra o primeiro elemento da fila...
    Console.WriteLine("Mostra o Primeiro Veículo da FILA: {0}", veiculos.Peek());

    Console.WriteLine("--------------------------------------------------");

    // mostra e remove o primeiro elemento da fila...
    Console.WriteLine("Mostra o Primeiro Veículo da FILA e depois remove: {0}", veiculos.Dequeue());

    Console.WriteLine("--------------------------------------------------");

    Console.WriteLine("Tamanho da FILA: {0}", veiculos.Count);

    Console.WriteLine("--------------------------------------------------");

    // lista todos os elementos da FILA...
    foreach (string q in veiculos) {
      Console.WriteLine("{0}", q);      
    }

    // remover elementos com while...
    veiculos.Enqueue("Carro");
    veiculos.Enqueue("Moto");
    veiculos.Enqueue("Navio");
    veiculos.Enqueue("Avião");
    Console.WriteLine("WHILE Tamanho da FILA: {0}", veiculos.Count);
    while(veiculos.Count > 0) {
      Console.WriteLine(veiculos.Dequeue());
    }
    Console.WriteLine("WHILE Tamanho da FILA: {0}", veiculos.Count);

    Console.WriteLine("--------------------------------------------------");

    veiculos.Enqueue("Carro");
    veiculos.Enqueue("Moto");
    veiculos.Enqueue("Navio");
    veiculos.Enqueue("Avião");
    veiculos.Clear(); // limpa toda a fila...
    Console.WriteLine("Tamanho da FILA: {0}", veiculos.Count);

    Console.WriteLine("--------------------------------------------------");
  }
}