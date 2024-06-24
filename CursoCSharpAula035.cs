// AULA 035 - https://youtu.be/QQIUdTYc3sA?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Cadeia de herança e Construtor da classe base
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
class VeiculoX {
  // propriedades
  public int velMax;
  //public bool ligado;
  private bool ligado;
  // rodas passa nesta aula a ser private, para ser inicializada no construtor da classe...
  //public int rodas;
  private int rodas;

  // Construtor
  // com isso vamos precisar de um método para manipular externamente esta propriedade...
  public VeiculoX(int rodas) {
    this.rodas = rodas;
  }

  // método ligar da classe veiculoX
  public void ligar() {
    ligado = true;
  }

  // método ligar da classe veiculoX
  public void desligar() {
    ligado = false;
  }

  // método de retorno da pripriedade ligado
  public string getLigado() {
    return ligado ? "Sim" : "Não";
  }

  // método para manipular rodas...
  public int getRodas() {
    return rodas;
  }

  // método para manipular rodas...
  public void setRodas(int rodas) {
    if(rodas < 0) {
      this.rodas = 0;
    }else if(rodas > 40) {
      this.rodas = 40;
    }else {
      this.rodas = rodas;
    }
  }
}

// A classe DERIVADA CarroX Herda da classe VeiculoX
class CarroX : VeiculoX {
  // propriedades
  public string nome;
  public string cor;

  // construtor
  //public CarroX( string nome, string cor) {
  // o construtuor da classe carro vai precisar derivar o construtor 
  // da classe veiculo... e passar o número de rodas...
  public CarroX( string nome, string cor) : base(4) {
    // acessa propriedades e métodos public da classe VeiculoX, é uma herança...
    //ligado = false; // a propriedade passou de public para private não pode ver fora da classe.

    // pode chamar o m étodo que é public para desligar o carroX...
    desligar();
    //rodas = 4; // deixou de ser publico e precisa ser manipulada por método...
    velMax = 120;
    this.nome = nome;
    this.cor = cor;
  }
}

// CADEIA DE HERANÇA...
// Carro Combate é uma classe derivada da classe Carro, 
// logo Carro é uma clase base para CarroCombate,
// que a classe Carro é derivada da classe Veiculo... 
// Classe Veiculo é a callse Base...
class CarroCombate : CarroX {
  // propriedades
  public int municao;

  // construtor
  public CarroCombate() : base("Carro de Combate", "Verde") {
    this.municao = 100;
    setRodas(6);
  }
}
// nossa primeira classe
class PrincipalAula035 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    CarroX c1 = new CarroX("Rapidão", "Vermelho");
    CarroCombate cc1 = new CarroCombate();

    Console.WriteLine("------------------------------------------------");

    // a classe carroX não tem nada implementado mas como herda da classe veiculoXs
    // pode ver as propriedades e métodos publicos da classe veiculoX.
    //c1.ligado = true; // a propriedade passou de public para private não pode ver fora da classe.
    Console.WriteLine("Nome........: {0}", c1.nome);
    Console.WriteLine("Cor.........: {0}", c1.cor);
    //Console.WriteLine("Rodas.......: {0}", c1.rodas); // deixou de ser publica e precisa ser manipulada por método...
    Console.WriteLine("Rodas.......: {0}", c1.getRodas());
    Console.WriteLine("Vel. Máxima.: {0}", c1.velMax);
    Console.WriteLine("Ligado......: {0}", c1.getLigado());

    Console.WriteLine("------------------------------------------------");
    // ligar o carro...
    c1.ligar();
    Console.WriteLine("Nome........: {0}", c1.nome);
    Console.WriteLine("Cor.........: {0}", c1.cor);
    //Console.WriteLine("Rodas.......: {0}", c1.rodas); // deixou de ser publica e precisa ser manipulada por método...
    Console.WriteLine("Rodas.......: {0}", c1.getRodas());
    Console.WriteLine("Vel. Máxima.: {0}", c1.velMax);
    Console.WriteLine("Ligado......: {0}", c1.getLigado());
 
    Console.WriteLine("------------------------------------------------");
 
    Console.WriteLine("Nome........: {0}", cc1.nome);
    Console.WriteLine("Cor.........: {0}", cc1.cor);
    Console.WriteLine("Rodas.......: {0}", cc1.getRodas());
    Console.WriteLine("Vel. Máxima.: {0}", cc1.velMax);
    Console.WriteLine("Ligado......: {0}", cc1.getLigado());
    Console.WriteLine("Munição.....: {0}", cc1.municao);

    Console.WriteLine("------------------------------------------------");
 }
}