// AULA 047 - https://youtu.be/RmxFymtQoNI?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Sobrecarga de métodos
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
class Calc {

  public int soma(int n1, int n2) {
    return n1 + n2;
  }

  public int soma(int n1, int n2, int n3) {
    return n1 + n2 + n3;
  }

  public int soma(int n1, int n2, int n3, int n4) {
    return n1 + n2 + n3 + n4;
  }

  public double soma(params double[] n) {
    double res = 0;

    for(int i = 0; i< n.Length; i++) {
      res += n[i];  
    }

    return res;
  }

  public int soma(params int[] n) {
    int res = 0;

    for(int i = 0; i< n.Length; i++) {
      res += n[i];  
    }

    return res;
  }
}

// nossa primeira classe
class PrincipalAula047 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    Calc calc= new Calc();

    Console.WriteLine("Soma: {0}", calc.soma(10, 5));
    Console.WriteLine("Soma: {0}", calc.soma(10, 5, 20));
    Console.WriteLine("Soma: {0}", calc.soma(10, 5, 20, 30));
    Console.WriteLine("Soma: {0}", calc.soma(10.4, 5.2, 20.7, 30.9));
    Console.WriteLine("Soma: {0}", calc.soma(10, 5, 20, 30));

    Console.WriteLine("--------------------------------------------------");
  }
 }
