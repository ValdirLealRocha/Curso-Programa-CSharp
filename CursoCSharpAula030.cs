// AULA 030 - https://youtu.be/1FAicpgPCO4?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Sobrecarga de Construtores
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
using System.Globalization;

// criando CLASSES
public class JogadorXX {
  // propriedades
  public int energia; // inicializado no construtor
  public bool vivo; // inicializado no construtor
  public string nome; // inicializado como parametro no construtor

  // método construtor - é chamado e responsavel por inicializar as propriedades..
  public JogadorXX() { // mesmo nome da classe...
    energia = 100;
    vivo = true;
    nome = "Jogador";
  }

  public JogadorXX(string n) { // mesmo nome da classe...
    energia = 100;
    vivo = true;
    nome = n;
  }

  public JogadorXX(string n, int e) { // mesmo nome da classe...
    energia = e;
    vivo = true;
    nome = n;
  }

  public JogadorXX(string n, int e, bool v) { // mesmo nome da classe...
    energia = e;
    vivo = v;
    nome = n;
  }

  // Informações
  public void info() {
    Console.WriteLine("=========================");
    // mostra em tela o nome do jogador...
    Console.WriteLine("Nome do jogador.....: {0}", nome);
    // mostra em tela o valor da energia do jogador...
    Console.WriteLine("Energia do jogador..: {0}", energia);
    // mostra em tela se o jogador está vivo...
    Console.WriteLine("O jogador está vivo.: {0}", (vivo) ? "Sim" : "Não");
    Console.WriteLine("-------------------------------");
  }

  // método DESTRUTOR primeiro caracter é um ~ - antes do GarbageColector...
  ~JogadorXX() {
    Console.WriteLine("*******************************");
    Console.WriteLine("Objeto {0} removido da memória!", nome);
    Console.WriteLine("*******************************");
  }
}

// inicializar as propriedades da classe - construtor tem o mesmo nome da classe...


// nossa primeira classe
class PrincipalAula030 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    JogadorXX j1 = new JogadorXX(); // criamos uma instancia da classe jogador...
    JogadorXX j2 = new JogadorXX("Bruno"); //
    JogadorXX j3 = new JogadorXX("Théo", 100); //
    JogadorXX j4 = new JogadorXX("Pablo", 0, false); //

    // mostra dados
    j1.info();
    j2.info();
    j3.info();
    j4.info();
  }
}