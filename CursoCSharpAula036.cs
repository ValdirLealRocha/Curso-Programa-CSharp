// AULA 036 - https://youtu.be/DgkWEzQsCMw?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Membros Protected
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
//   //abstract: Classe-Base para outras classes, não podem ser instanciados
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

// classe BASE Veiculo_
class Veiculo_ {
  // propriedades
  public int velAtual; // publico na classe e externamente...
  private int velMax; // privado e visivel somente dentro da classe.. métodos publicos da classe que manipulam externamente...
  protected bool ligado; // permite o acesso aos membros somente pelas classes base e derivadas...

  // construtor
  public Veiculo_(int velMax) {
    velAtual = 0;
    this.velMax = velMax;
    ligado = false;
  }

  // Manipular o retorno da propriedade ligado
  public bool getLigado() {
    return ligado;
  }

  // Manipular o retorno da propriedade velMax
  public int getVelMax() {
    return velMax;
  }
}

// Classe Carro_ DERIVADA de Veiculo_ que vai herdar da classe Veiculo_
class Carro_ : Veiculo_ {
  // propriedade
  public string nome;

  // construtor
  public Carro_(string nome, int vm) : base(vm) {
    this.nome = nome;
    //this.velMax = velMax; // private...  vm que recebe e que repassa na base...
    ligado = false; // protected ...
  }
}

// nossa primeira classe
class PrincipalAula036 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    Carro_ carro = new Carro_("BMW", 220);

    Console.WriteLine("--------------------------------------------------");
    // informações
    Console.WriteLine("Nome........: {0}", carro.nome);
    Console.WriteLine("Vel. Máxima.: {0}", carro.getVelMax());
    Console.WriteLine("Ligado......: {0}", (carro.getLigado() ? "Sim" : "Não"));

    Console.WriteLine("--------------------------------------------------");
 }
}