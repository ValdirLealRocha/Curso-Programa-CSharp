// AULA 029 - https://youtu.be/DqmESqZ6YXQ?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Construtores e Destrutores
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
public class JogadorX {
  // propriedades
  public int energia; // inicializado no construtor
  public bool vivo; // inicializado no construtor
  public string nome; // inicializado como parametro no construtor

  // método construtor - é chamado e responsavel por inicializar as propriedades..
  public JogadorX(string n) { // mesmo nome da classe...
    energia = 100;
    vivo = true;
    nome = n;
  }

  // método DESTRUTOR primeiro caracter é um ~ - antes do GarbageColector...
  ~JogadorX() {
    Console.WriteLine("Objeto {0} removido da memória!", nome);
  }
}

// inicializar as propriedades da classe - construtor tem o mesmo nome da classe...


// nossa primeira classe
class PrincipalAula029 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    string nome1;
    Console.WriteLine("Digite o nome do logador 1: ");
    nome1 = Console.ReadLine();

    JogadorX j1 = new JogadorX(nome1); // criamos uma instancia da classe jogador...
    JogadorX j2 = new JogadorX("Théo"); //

    // mostra em tela o nome do jogador...
    Console.WriteLine("Nome do jogador 1.....: {0}", j1.nome);
    // mostra em tela o valor da energia do jogador...
    Console.WriteLine("Energia do jogador 1..: {0}", j1.energia);
    // mostra em tela se o jogador está vivo...
    Console.WriteLine("O jogador 1 está vivo.: {0}", (j1.vivo) ? "Sim" : "Não");

    // mostra em tela o valor da energia do jogador...
    j1.energia = 50;
    Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
    // mostra em tela o valor da energia do jogador...
    Console.WriteLine("Energia do jogador 2: {0}", j2.energia);
    // mostra em tela o nome do jogador...
    Console.WriteLine("Nome do jogador 2.....: {0}", j2.nome);
  }
}