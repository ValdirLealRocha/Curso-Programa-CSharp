// AULA 056 - https://youtu.be/RCWPih5bEVs?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Coleção LinkedList / Lista duplamente encadeada
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
class PrincipalAula056 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) { // lista de argumentos do programa...
    // declaração de variáveis
    // lista duplamente encadeada...
    LinkedList<string> transp = new LinkedList<string>();

    // manipular lista - first add o último no inicio da lista...
    transp.AddFirst("Carro");
    transp.AddFirst("Avião");
    transp.AddFirst("Navio");
    transp.AddFirst("Motocicleta");

    // manipular lista - last add o último no fim da lista...
    transp.AddLast("Bicicleta");

    // manipular lista - after add depois do item informado na lista...
    LinkedListNode<string>no;
    no = transp.FindLast("Navio"); // nó possibilita mais metodos e propriedades colocando ponto
    transp.AddAfter(no, "Patinete");

    // manipular lista - before add antes do item informado na lista...
    LinkedListNode<string>no1;
    no1 = transp.FindLast("Navio"); // nó possibilita mais metodos e propriedades colocando ponto
    transp.AddBefore(no1, "Patins");

    //transp.Clear(); // limpa toda a lista...

    Console.WriteLine("--------------------------------------------------");

    // procura item na lista...
    if(transp.FindLast("Carro") == null) {
      Console.WriteLine("Carro Não encontrado");
    }else {
      Console.WriteLine("Carro encontrado!");
    }

    Console.WriteLine("--------------------------------------------------");

    // remove um item da lista...
    transp.Remove("Navio");
    transp.RemoveFirst(); // remove o primeiro item da lista
    transp.RemoveLast(); // remove o último item da lista

    Console.WriteLine("--------------------------------------------------");

    // percorrer a lista
    foreach (string s in transp) {
      Console.WriteLine("Transporte: {0}", s);
    }

    Console.WriteLine("--------------------------------------------------");
  }
}