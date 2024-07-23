using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace CFB_Academia
{
    internal class class_Banco
    {
        // propriedades
        private static SQLiteConnection conexao;

        // método ConexaoBanco()
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=D:\\ProjetosDEV\\Curso-Programa-CSharp\\Aula100\\CFB_Academia\\DataBase\\banco_Academia.db");
            conexao.Open();
            return conexao;
        }
    }
}
