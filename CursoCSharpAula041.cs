// AULA 041 - https://youtu.be/5WpXoMTKJ4o?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Acessors GET e SET
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

// Classe Carro
class CarroA41 {
  // propriedades
  private int velMax;
  // Propriedade Acessors GET e SET-substitui os métodos setVelMax() e getVelMax()
  public int vm {
    get {
      return velMax;
    }
    
    set {
      // value será o conteudo a ser inicializado...
      if(value < 0) {
        velMax = 0;
      }else if(value > 300) {
        velMax = 300;
      }else {
        velMax = value;
      }
    }
  }

  // contrutor
  public CarroA41() {
    // inicialização padrão..
    //this.velMax = 120;

    // inicialização com a propriedade vm
    vm = 120;
  }

  // para manipular velMax preciso do setVelMax() e getVelMax()

  // métodos

}

// nossa primeira classe
class PrincipalAula041 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    CarroA41 c1 = new CarroA41();

    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Velocidade..: {0}", c1.vm);

    c1.vm = 200;
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Velocidade..: {0}", c1.vm);

    Console.WriteLine("--------------------------------------------------");
  }
 }
