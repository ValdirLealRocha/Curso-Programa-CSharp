// AULA 033 - https://youtu.be/OuXbXZBR7gk?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Public vs Private
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

// classe JogadorA
class JogadorA {
  // propriedades
  private int energia; // iniciou como public e agora mudaremos para private
  private string nome; // iniciou como public e agora mudaremos para private

  // construtor
  public JogadorA(string nome) {
    this.nome = nome;
    energia = 100;
  }

  // métodos pra manipular as propriedades...
  public int getEnergia() {
    return energia;
  }
  public string getNome() {
    return nome;
  }
  public void setEnergia(int e) {
    if(e < 0) {
      if((energia + e) < 0) {
        energia = 0;
      }else {
        energia += e;
      }
    }else if(e > 0) {
      if((energia + e) > 100) {
        energia = 100;
      }else {
        energia += e;
      }
    }
  }
}

// nossa primeira classe
class PrincipalAula033 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    JogadorA j1 = new JogadorA("Valdir");

    //
    j1.setEnergia(-150);

    //
    Console.WriteLine("Nome.....: {0}", j1.getNome()); // private só será visivel com métodos que permitam...
    Console.WriteLine("Energia..: {0}", j1.getEnergia()); // private só será visivel com métodos que permitam...
  }
}