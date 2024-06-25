// AULA 038 - https://youtu.be/0Ya17g9g62Y?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// HMétodos virtuais
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

// Classe BASE_
class Base_ {
  public Base_() {
    Console.WriteLine("Construtor da Classe Base_");
  }

  // método virtual da classe base_...
  // só informar a assinatura, além de ser virtual será sobrescrito...
  virtual public void info() {}
}

// Classe Derivada_1 herdada da classe BASE_
class Derivada_1 : Base_ {
  public Derivada_1() {
    Console.WriteLine("Construtor da Classe Derivada_1");
  }

  // método virtual da classe Derivada_1...
  override public void info() {
    Console.WriteLine("Derivada_1");
  }
}

// Classe Derivada_2 herdada da classe BASE_
class Derivada_2 : Derivada_1 {
  public Derivada_2() {
    Console.WriteLine("Construtor da Classe Derivada_2");
  }

  // método virtual da classe Derivada_2...
  override public void info() {
    Console.WriteLine("Derivada_2");
  }
}

// nossa primeira classe
class PrincipalAula038 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    Base_ Ref;
    Derivada_1 derivada_1 = new Derivada_1();
    Derivada_2 derivada_2 = new Derivada_2();

    Ref = derivada_2;
    Ref.info();

    //base_.info();
    //derivada_1.info();
    //derivada_2.info();
    
    Console.WriteLine("--------------------------------------------------");
  }
 }
