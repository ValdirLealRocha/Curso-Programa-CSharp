// AULA 011 - https://youtu.be/ucGefp2i4As?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Conversões de tipos (typecast)
//
// abrir terminal e digital na pasta do projeto:
// dotnet new console >>>> tem que ser num terminal cmd
//
// NOTA: ir no termonal de comando e digitar csc <arquivo.cs>
//       isto irá compilar e criar um .exe deste arquivo .cs
//       e depois só digitar o nome do arquivo sem o .cs, e vai rodar no terminal...   
//
// C# é fortemente tipado!!!
//
// biblioteca padrão de uso no C#
using System;

// nossa primeira classe
class PrincipalAula011 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int n1 = 10;
    float n2 = n1; // recebe tipo diferente... o compilador converteu automaticamente
    Console.WriteLine("int n1:{0} e float n2:{1}", n1, n2); // sem erro...

    float n3 = 10.5f;
    // typecast... (int)
    int n4 = (int)n3; // erro ao recebe tipo diferente... sem typecast da Erro no compilador...
    Console.WriteLine("float n3:{0} e int n4:{1}", n3, n4);

    int vInt = 10;
    // typecast... (short)
    short vShort = (short)vInt; // erro ao recebe tipo diferente... sem typecast da Erro no compilador...
    Console.WriteLine("int vInt:{0} e short vShort:{1}", vInt, vShort);
  }
}