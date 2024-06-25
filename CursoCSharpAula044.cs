// AULA 044 - https://youtu.be/3TJRfIOkbBg?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Struct - define um tipo que vai permitir armazenar diferentes tipos de dados...
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

// Criar uma strutura de dados do tipo Carro
// podemos ter construtores na estrutura de tipo de dados...
struct Carro044 {
  // propriedades
  public string marca;
  public string modelo;
  public string cor;

  // construtor
  public Carro044(string marca, string modelo, string cor) {
    this.marca = marca;
    this.modelo = modelo;
    this.cor = cor;
  }

  // informações
  public void info() {
    Console.WriteLine("Marca..: {0}", this.marca);
    Console.WriteLine("Modelo.: {0}", this.modelo);
    Console.WriteLine("Cor....: {0}", this.cor);
  }
}

// nossa primeira classe
class PrincipalAula044 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    // define uma estrutura do tipo Carro
    Carro044 c1;

    Console.WriteLine("--------------------------------------------------");

    c1.marca = "VW";
    c1.modelo = "Golf";
    c1.cor = "Azul";

    Console.WriteLine("Marca..: {0}", c1.marca);
    Console.WriteLine("Modelo.: {0}", c1.modelo);
    Console.WriteLine("Cor....: {0}", c1.cor);

    Console.WriteLine("--------------------------------------------------");

    Carro044 c2 = new Carro044("BMW", "320i", "Preto");
    Console.WriteLine("Marca..: {0}", c2.marca);
    Console.WriteLine("Modelo.: {0}", c2.modelo);
    Console.WriteLine("Cor....: {0}", c2.cor);


    Console.WriteLine("--------------------------------------------------");

    c1.info();
    Console.WriteLine("==");
    c2.info();

    Console.WriteLine("--------------------------------------------------");
  }
 }
