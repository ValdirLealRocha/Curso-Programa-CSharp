// AULA 050 - https://youtu.be/SpEHYVHkcsQ?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Delegates - é um objeto que pode fazer referencia a n métodos...
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

// criando o delegate
delegate int Op(int n1, int n2);

// classe Matematica - usando o delegate...
class Matematica {
  // métodos
  public static int soma(int n1, int n2) {
    return n1 + n2;
  }
  
  public static int multiplicacao(int n1, int n2) {
    return n1 * n2;
  }
}

// nossa primeira classe
class PrincipalAula050 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int res;
    
    Op d1 = new Op(Matematica.soma);

    res = d1(10,50);
    Console.WriteLine("Soma: {0}", res);

    Console.WriteLine("--------------------------------------------------");
    
    d1 = new Op(Matematica.multiplicacao);
    res = d1(10,50);
    Console.WriteLine("Multiplicação: {0}", res);
    

    Console.WriteLine("--------------------------------------------------");
  }
 }
