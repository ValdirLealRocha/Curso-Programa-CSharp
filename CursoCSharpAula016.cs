// AULA 016 - https://youtu.be/uE8csfcJLFk?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Comando goto
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
class PrincipalAula016 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int tempo = 0;
    char escolha;
    
    // goto apontando pra este Label
    // permite o usuário parar o andamento do programa, 
    // quando for interrogado a continuar....
    // deste ponto da sequencia ao programa, 
    // lá abaixo questiona se procegue com o programa...
    inicio:

    Console.Clear();

    // Trajeto e tempo...
    Console.WriteLine("Belo Horizonte/MG à Vitória/ES");
    Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus ");
    
    // captura digitação...
    escolha = char.Parse(Console.ReadLine());

    // valida os dados de entrada
    switch (escolha) {
        case 'a':
        case 'A':
            tempo = 50;
            break;
        case 'c':
        case 'C':
            tempo = 480;
            break;
        case 'o':
        case 'O':
            tempo = 660;
            break;
        default:
            tempo = -1; // tempo indefinido...
            break;
    }

    // mostra mensagens da validação dos dados.
    if(tempo < 0) {
        Console.WriteLine("Transporte Indisponível");
    }else{
        Console.WriteLine("Tempo para o transporte escolhido é: {0}", tempo);
    }
    // questiona usuário, se continuar vai para p Goto... Senão fim do programa...
    Console.Write("\n\nCalcular outro transporte? [s/n]: ");
    escolha = char.Parse(Console.ReadLine());
    if(escolha == 's' | escolha == 'S') {
        goto inicio;
    }else{
        Console.Clear();
        Console.WriteLine("\n\nFim do Programa!");
    }
  }
}