// AULA 023 - https://youtu.be/UX7Xb4tSme0?list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi
// Métodos para arrays #P1 - vetor e matriz
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
using System.Globalization;

// nossa primeira classe
class PrincipalAula023 {
  // Main é o principal para executar um programa em C#
  static void Main(string[] args) {
    // declaração de variáveis
    int[] vetor1 = new int[5];
    int[] vetor2 = new int[5];
    int[] vetor3 = new int[5];
    int[,] matriz = new int[2,5]{ {11, 22, 00, 44, 55}, {66, 77, 88, 99, 00} };

    // cria var com numero aleatórios/randomico
    Random random = new Random();
    // inicializa o array vetor1
    for(int i = 0; i < vetor1.Length; i++) {
      vetor1[i] = random.Next(50); // gera número randomico... de 0 a 49
    }

    // mostra elementos do vetor1 na tela
    Console.WriteLine("Elementos do Vetor1");
    foreach(int n in vetor1) {
      Console.WriteLine(n);
    }

    // Retorna a posição do elemento procurado...
    //public static int BinarySearch(array, valor);
    Console.WriteLine("BinarySearch");
    int procurado = 33;
    int pos = Array.BinarySearch(vetor1, procurado); // se retornar -1 não encontrou...
    Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
    Console.WriteLine("------------------------------------------");

    // Faz copia dos elementos de um array pra outro...
    //public static void Copy(Ar_origem, Ar_destino, qtde_elementos);
    Console.WriteLine("Copy");
    Array.Copy(vetor1, vetor2, vetor1.Length);
    foreach(int n in vetor2) {
      Console.WriteLine(n); 
    }
    Console.WriteLine("------------------------------------------");

    // Método que faz copia dos elementos de um array pra outro...
    //public void Copy(Ar_destino, a_partir_desta_posicao);
    Console.WriteLine("CopyTo");
    vetor1.CopyTo(vetor3, 0);
    foreach(int n in vetor3) {
      Console.WriteLine(n); 
    }
    Console.WriteLine("------------------------------------------");

    // Retorna a quantidade de elementos
    //public long GetLongLength(dimensao);
    Console.WriteLine("GetLongLength");
    long qtdaElementosVetor = vetor1.GetLongLength(0);
    Console.WriteLine("Quantidade de elementos {0}", qtdaElementosVetor);
    Console.WriteLine("------------------------------------------");

    // Retorna o menor índice do array/matriz
    //public int GetLowerBound(dimensao);
    Console.WriteLine("GetLowerBound");
    int MenorIndiceVetor = vetor1.GetLowerBound(0);
    int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
    Console.WriteLine("Menor Índice do Vetor1 {0}", MenorIndiceVetor);
    Console.WriteLine("------------------------------------------");

    // Retorna o maior índice do array/matriz
    //public int GetUpperBound(dimensao);
    Console.WriteLine("GetUpperBound");
    int MaiorIndiceVetor = vetor1.GetUpperBound(0);
    int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
    Console.WriteLine("Maior Índice do Vetor1 {0}", MaiorIndiceVetor);
    Console.WriteLine("------------------------------------------");

    // retorna o valor de uma posição de um elemento...
    //public object GetValue(long indice);
    Console.WriteLine("GetValue");
    int valor0 = Convert.ToInt32(vetor1.GetValue(3));
    int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
    Console.WriteLine("Valor da posição do Vetor1: {0}", valor0);
    Console.WriteLine("------------------------------------------");

    // retorna o indice do primeiro valor indicado do array
    //public static int IndexOf(array, valor);
    Console.WriteLine("IndexOf");
    int indice1 = Array.IndexOf(vetor1, 3);
    Console.WriteLine("Índice do primeiro valor 3: {0}", indice1);
    Console.WriteLine("------------------------------------------");

    // etorna o indice do último valor indicado do array
    //public static int LastIndexOf(array, valor);
    Console.WriteLine("LastIndexOf");
    int indice2 = Array.LastIndexOf(vetor1, 3);
    Console.WriteLine("Índice do último valor 33: {0}", indice2);
    Console.WriteLine("------------------------------------------");

    // inverte a ordem dos elementos do array - contrário de sort()
    //public static void Reverse(array)
    Array.Reverse(vetor1);
    foreach(int n in vetor1) {
      Console.WriteLine(n);
    }

    // define um valor numa determinada posição de um elemento...
    //public void SetValue(object valor, long pos);
    vetor2.SetValue(99, 0);
    for(int i = 0; i < vetor2.Length; i++) {
      vetor2.SetValue(0,i);
    }
    // mostra a alteração em tela
    Console.WriteLine("Vetor 2");
    foreach(int n in vetor2) {
      Console.WriteLine(n);
    } 

    // ordena crescente os array´s
    //public static void Sort(array)
    Array.Sort(vetor1);
    Array.Sort(vetor2);
    Array.Sort(vetor3);
    // lista o vetor1
    Console.WriteLine("Vetor1");
    foreach(int n in vetor1) {
      Console.WriteLine(n);
    }
    // lista o vetor2
    Console.WriteLine("\nVetor2");
    foreach(int n in vetor2) {
      Console.WriteLine(n);
    }
    // lista o vetor3
    Console.WriteLine("\nVetor3");
    foreach(int n in vetor3) {
      Console.WriteLine(n);
    }
  }
}