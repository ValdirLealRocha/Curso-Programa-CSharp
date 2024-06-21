// AULA 031 - https://youtu.be/2tCbg4HkWFQ?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Classes static - não permite instanciar e não permite criar static - memória fixa na memória...
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
static public class JogadorXXX {
  // propriedades
  static public int energia; // inicializado no construtor
  static public bool vivo; // inicializado no construtor
  static public string nome; // inicializado como parametro no construtor

  // método construtor - é chamado e responsavel por inicializar as propriedades..
  static public void iniciar(string n) { // mesmo nome da classe...
    energia = 100;
    vivo = true;
    nome = n;
  }

  // Informações
  static public void info() {
    Console.WriteLine("==========================================");
    // mostra em tela o nome do jogador...
    Console.WriteLine("Nome do jogador.....: {0}", nome);
    // mostra em tela o valor da energia do jogador...
    Console.WriteLine("Energia do jogador..: {0}", energia);
    // mostra em tela se o jogador está vivo...
    Console.WriteLine("O jogador está vivo.: {0}", (vivo) ? "Sim" : "Não");
    Console.WriteLine("------------------------------------------");
  }
}

// Classe Inimigo
class InimigoXXX {
  // declaração das propriedades da classe...
  static public bool alerta; // se tornou static 
  public string nome;

  // construtor
  public InimigoXXX(string n) {
    alerta = false;
    nome = n;
  }

  // informações
  public void info() {
    Console.WriteLine("Nome...: {0}", nome);
    Console.WriteLine("Alerta.: {0}", alerta);
    Console.WriteLine("---------------------------------");
  }
} 

// inicializar as propriedades da classe - construtor tem o mesmo nome da classe...


// nossa primeira classe
class PrincipalAula031 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis

    // mostra dados da classe static
    JogadorXXX.iniciar("Bruno");
    JogadorXXX.info();

    // instancia dados da classe inimigo
    InimigoXXX i1 = new InimigoXXX("Peter");
    InimigoXXX i2 = new InimigoXXX("Malu");
    InimigoXXX i3 = new InimigoXXX("Darla");

    // inicialização de alerta antes de ser static
    //i1.alerta = true;
    // como iniciar o alerta depois de receber o static
    InimigoXXX.alerta = true; //******************** ficou global na classe...

    // mostra dados
    i1.info();
    i2.info();
    i3.info();
  }
}