// AULA 045 - https://youtu.be/WErvUyKkAss?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Array de estruturas
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
struct Carro045 {
  // propriedades
  public string marca;
  public string modelo;
  public string cor;

  // construtor

  // informações
  public void info() {
    Console.WriteLine("Marca..: {0}", this.marca);
    Console.WriteLine("Modelo.: {0}", this.modelo);
    Console.WriteLine("Cor....: {0}", this.cor);
    Console.WriteLine("--------------------------------------------------");
  }
}

// nossa primeira classe
class PrincipalAula045 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    // define uma estrutura do tipo Carro
    Carro045[] carros = new Carro045[5];

    carros[0].marca = "BMW";
    carros[0].modelo = "320i";
    carros[0].cor = "Preta";

    carros[1].marca = "Honda";
    carros[1].modelo = "City";
    carros[1].cor = "Prata";

    carros[2].marca = "VW";
    carros[2].modelo = "Gol";
    carros[2].cor = "Branco";

    carros[3].marca = "Fiat";
    carros[3].modelo = "Uno";
    carros[3].cor = "Bege";

    carros[4].marca = "Hyunday";
    carros[4].modelo = "Creta";
    carros[4].cor = "krosta";

    Console.WriteLine("--------------------------------------------------");

    // manual...
    carros[0].info();
    carros[1].info();
    carros[2].info();
    carros[3].info();
    carros[4].info();

    Console.WriteLine("--------------------------------------------------");

    // mostrar num loop...
    for (int i = 0; i < carros.Length; i++) {
      carros[i].info();
    }
    
    Console.WriteLine("--------------------------------------------------");
  }
 }
