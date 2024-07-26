using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFB_Academia
{
    internal class class_Global
    {
        // variáveis globais
        public static string versao = "1.0";
        public static Boolean logado = false;
        // 0 Básico, 1 Gerente, 2 Master
        public static int nivel = 0;
        //public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory;
        public static string caminhoSistema = System.Environment.CurrentDirectory;
        //D:\ProjetosDEV\Curso-Programa-CSharp\Aula100\CFB_Academia\bin\Debug
        public static string caminhoBancoDados = caminhoSistema + @"\DataBase\"; // ou "\\DataBase\\"
        //D:\ProjetosDEV\Curso-Programa-CSharp\Aula100\CFB_Academia\bin\Debug\DataBase\
        public static string nomeBancoDados = "banco_Academia.db";
        //D:\ProjetosDEV\Curso-Programa-CSharp\Aula100\CFB_Academia\bin\Debug\DataBase\banco_Academia.db
    }
}
