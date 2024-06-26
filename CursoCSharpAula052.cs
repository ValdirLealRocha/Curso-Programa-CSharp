// AULA 052 - https://youtu.be/GgrjBRhhncI?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Exceções - Try Catch Finally - P1
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

// nossa primeira classe
class PrincipalAula052 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) { // lista de argumentos do programa...
    // declaração de variáveis
    int n1, n2, res;
    res = n1 = n2 = 0;

    n1 = 10;
    n2 = 5; // 5 sem erro, 0 vai dar o erro de divisão por zero...
    
    Console.WriteLine("--------------------------------------------------");

    // tratar erro genérico...
    try {
      res = n1 / n2;
      Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
    }
    catch {
      Console.WriteLine("ERROR!");    
    }

    Console.WriteLine("--------------------------------------------------");
    // tratar erro controlado pela messagem do erro...
    n1 = 10;
    n2 = 5; // 5 sem erro, 0 vai dar o erro de divisão por zero...
    try {
      res = n1 / n2;
      Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
    }
    catch(Exception e) {
      Console.WriteLine("ERROR! {0}", e);
      Console.WriteLine("ERROR! {0}", e.Message);
      Console.WriteLine("ERROR! {0}", e.GetType());
    }

    Console.WriteLine("--------------------------------------------------");
    // tratar erro controlado pela messagem do erro...
    n1 = 10;
    n2 = 0; // 5 sem erro, 0 vai dar o erro de divisão por zero...
    try {
      res = n1 / n2;
      Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
    }
    catch(DivideByZeroException e) {
      Console.WriteLine("ERROR! {0}", e);
      Console.WriteLine("ERROR! {0}", e.Message);
      Console.WriteLine("ERROR! {0}", e.GetType());
    }

    Console.WriteLine("--------------------------------------------------");
  }
}
