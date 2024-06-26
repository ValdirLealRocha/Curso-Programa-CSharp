// AULA 048 - https://youtu.be/paF5tgW527s?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Recursividade
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
using System.Runtime.CompilerServices;

// classe pra fazer sobre carga de metodos...
class Calci {

  // Calcular um Fatorial
  // Recursividade chama ela mesma... Substitui o for chamando ela mesmo...
  // 5! = 5*4*3*2*1
  // 10! = 9*8*7*6*5*4*3*2*1
  public int fat(int n) {
    int res = 0;
    if(n <= 1) {
      res = 1;
    }else {
      res = n * fat(n-1); // recursividade...
    }

    return res;
  }
}

// nossa primeira classe
class PrincipalAula048 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    Calci calci= new Calci();

    Console.WriteLine("--------------------------------------------------");

    Console.WriteLine("Fatorial de um número: {0}", calci.fat(5));

    Console.WriteLine("--------------------------------------------------");
  }
 }
