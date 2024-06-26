// AULA 046 - https://youtu.be/gmQLuOZ-2g0?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Métodos que retornam objetos
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

// CLASSES
class Galinha {
  // propriedades
  private string nomeGalinha;
  private int numOvo;

  // construtor
  public Galinha(string nomeGalinha) {
    this.nomeGalinha = nomeGalinha;
    this.numOvo = 0;
  }

  // destrutor

  // métodos
  public Ovo botar() { // Método que retorna um OBJETO...
    this.numOvo++;
    return new Ovo(this.numOvo, this.nomeGalinha);
  }
}

class Ovo {
  // propriedades
  private int numOvo;
  private string minhaGalinha;

  // construtor
  public Ovo(int numOvo, string minhaGalinha) {
    this.numOvo = numOvo;
    this.minhaGalinha = minhaGalinha;
    Console.WriteLine("Ovo criado: {0} - Galinha: {1}", this.numOvo, this.minhaGalinha);
  }

  // destrutor

  // métodos
}

// nossa primeira classe
class PrincipalAula046 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    Galinha g1 = new Galinha("Galinha Pintadinha");
    Galinha g2 = new Galinha("Galinha Amarelinha");
    Galinha g3 = new Galinha("Galinha Vilares");
    
    g1.botar();
    g1.botar();
    g1.botar();
        
    Console.WriteLine("--------------------------------------------------");

    g2.botar();

    Console.WriteLine("--------------------------------------------------");

    g3.botar();
    g3.botar();
    
    Console.WriteLine("--------------------------------------------------");
  }
 }
