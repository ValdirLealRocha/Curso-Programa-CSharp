// AULA 055 - https://youtu.be/XwrnpWGYxJ0?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Coleção Dictionary
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
using System.Collections.Generic; // trabalhar com coleções...

// nossa primeira classe
class PrincipalAula055 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) { // lista de argumentos do programa...
    // declaração de variáveis
    // construtor genérico...
    Dictionary <int, string> veiculos = new Dictionary<int, string> ();

    // adicionar elementos ao dicionário...
    veiculos.Add(10, "Carro");
    veiculos.Add(5, "Avião");
    veiculos.Add(0, "Navio");
    veiculos.Add(20, "Moto");
    veiculos.Add(15, "Patinete");

    Console.WriteLine("--------------------------------------------------");

    // manipular o dicionário
    Console.WriteLine("Tamanho do Dicionário: {0}", veiculos.Count);
    int chave = 22;
    if(veiculos.ContainsKey(chave)) {
      Console.WriteLine("A chave {0} está na coleção.", chave);
    }else{
      Console.WriteLine("A chave {0} não está na coleção.", chave);
    }

    Console.WriteLine("--------------------------------------------------");

    // remover um item do dicionário...
    veiculos.Remove(20);


    Console.WriteLine("--------------------------------------------------");

    // outra forma de inicializar/adicionar como um array...
    veiculos[15] = "Moto";

    // valor da chave
    string valor = "Moto";
    if(veiculos.ContainsValue(valor)) {
      Console.WriteLine("O valor {0} está na coleção.", valor);
    }else{
      Console.WriteLine("A valor {0} não está na coleção.", valor);
    }

    Console.WriteLine("--------------------------------------------------");

    // listar o dicionário...
    foreach(KeyValuePair<int,string> v in veiculos) {
      Console.WriteLine("{0} | {1} | {2}", v, v.Key, v.Value);
    }

    Console.WriteLine("--------------------------------------------------");

    // outra forma de varrer o dicionário...
    Dictionary<int, string>.ValueCollection valores = veiculos.Values;
    // listar o dicionário...
    foreach(string v in valores) {
      Console.WriteLine("{0}", v);
    }

    Console.WriteLine("--------------------------------------------------");

    // outra forma de varrer o dicionário...
    Dictionary<int, string>.KeyCollection chaveX = veiculos.Keys;
    // listar o dicionário...
    foreach(int v in chaveX) {
      Console.WriteLine("{0}", v);
    }

    Console.WriteLine("--------------------------------------------------");

    // limpar o dicionário...
    veiculos.Clear();
    Console.WriteLine("Tamanho Atual do Dicionário: {0}", veiculos.Count);

    Console.WriteLine("--------------------------------------------------");
  }
}