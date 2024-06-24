// AULA 034 - https://youtu.be/E8WJ_z-osqE?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Herança
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

// Classe BASE...
class Veiculo {
  // propriedades
  public int velMax;
  //public bool ligado;
  private bool ligado;
  public int rodas;

  // método ligar da classe veiculo
  public void ligar() {
    ligado = true;
  }

  // método ligar da classe veiculo
  public void desligar() {
    ligado = false;
  }

  // método de retorno da pripriedade ligado
  public string getLigado() {
    return ligado ? "Sim" : "Não";
  }
}

// A classe DERIVADA Carro Herda da classe Veiculo
class Carro : Veiculo {
  // propriedades
  public string nome;
  public string cor;

  // construtor
  public Carro( string nome, string cor) {
    // acessa propriedades e métodos public da classe Veiculo, é uma herança...
    //ligado = false; // a propriedade passou de public para private não pode ver fora da classe.

    // pode chamar o m étodo que é public para desligar o carro...
    desligar();
    rodas = 4;
    velMax = 120;
    this.nome = nome;
    this.cor = cor;
  }
}

// nossa primeira classe
class PrincipalAula034 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    Carro c1 = new Carro("Rapidão", "Vermelho");
    // a classe carro não tem nada implementado mas como herda da classe veiculos
    // pode ver as propriedades e métodos publicos da classe veiculo.
    //c1.ligado = true; // a propriedade passou de public para private não pode ver fora da classe.
    Console.WriteLine("Nome........: {0}", c1.nome);
    Console.WriteLine("Cor.........: {0}", c1.cor);
    Console.WriteLine("Rodas.......: {0}", c1.rodas);
    Console.WriteLine("Vel. Máxima.: {0}", c1.velMax);
    Console.WriteLine("Ligado......: {0}", c1.getLigado());
  }
}