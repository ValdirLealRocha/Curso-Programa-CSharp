// AULA 039 - https://youtu.be/2-nHNivx6bA?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Classes e métodos abstratos - classe de referência...
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

// VeiculoCA Classe ABSTRACT - não pode ser intanciada...
// Classe BASE Abstrata, só pode ser herdada
abstract class VeiculoCA {
  // propriedades
  protected int velMaxima;
  protected int velAtual;
  protected bool ligado;

  // construtor
  protected VeiculoCA() {
    ligado = false;
    velAtual = 0;
  }

  // método pra ligar o veiculo
  public void setLigado(bool ligado) {
    this.ligado = ligado;
  }

  // método pra mostrar a velocidade atual do veiculo
  public int getVelAtual() {
    return velAtual;
  }

  // método abstrato que vai setar a aceleração...
  abstract public void aceleracao(int mult);
}

// A classe CarroHV herda da classe abstrata VeiculoCA
class CarroHV : VeiculoCA {
  // propriedades

  // construtor
  public CarroHV() {
    velMaxima = 120;
  }

  // métodos...
  override public void aceleracao(int mult) {
    velAtual += 10 * mult;
  }
}

// nossa primeira classe
class PrincipalAula039 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    CarroHV carro1 = new CarroHV();

    Console.WriteLine("--------------------------------------------------");
    
    Console.WriteLine("Velocidade Atual.: {0}", carro1.getVelAtual());

    Console.WriteLine("--------------------------------------------------");

    carro1.aceleracao(1); 
    Console.WriteLine("Velocidade Atual.: {0}", carro1.getVelAtual());

    Console.WriteLine("--------------------------------------------------");

    carro1.aceleracao(1); 
    Console.WriteLine("Velocidade Atual.: {0}", carro1.getVelAtual());

    Console.WriteLine("--------------------------------------------------");

    carro1.aceleracao(-1); 
    Console.WriteLine("Velocidade Atual.: {0}", carro1.getVelAtual());

    Console.WriteLine("--------------------------------------------------");
  }
 }
