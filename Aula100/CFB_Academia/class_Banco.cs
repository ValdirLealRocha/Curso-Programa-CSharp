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
            // cria uma instância do objeto sqlite o caminho do banco de dados
            conexao = new SQLiteConnection("Data Source=D:\\ProjetosDEV\\Curso-Programa-CSharp\\Aula100\\CFB_Academia\\DataBase\\banco_Academia.db");
            
            // abre a conexão com o banco de dados
            conexao.Open();
            
            // retorna a conexão do banco de dados...
            return conexao;
        }

        // método ObterTodosUsuarios()
        public static DataTable ObterTodosUsuarios() 
        {
            // cria uma instância nula do data adapter
            SQLiteDataAdapter da = null;

            // cria uma instância do data table
            DataTable dt = new DataTable();

            // validação de erros...
            try
            {
                // executa um bloco de comandos e garante a limpeza da memória ao finalizar processos...
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    // seleciona todos os usuários...
                    cmd.CommandText = "SELECT FROM * tb_usuarios";

                    // o data adapter irá executar o comando e a conexão no banco de dados
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    // preencher o data table com os dados do banco de dados
                    da.Fill(dt);

                    // fecha conexão
                    ConexaoBanco().Close();

                    // retorna um data table - tabela de todos os usuários
                    return dt;
                }
            }
            catch (Exception ex)
            {
                // fecha conexão
                ConexaoBanco().Close();

                // controle de erro...
                throw ex;
            }
        }

        // método genérico para consulta de dados...
        public static DataTable ConsultaGenerica(string sql) 
        {
            // cria uma instância nula do data adapter
            SQLiteDataAdapter da = null;

            // cria uma instância do data table
            DataTable dt = new DataTable();

            // validação de erros...
            try
            {
                // executa um bloco de comandos e garante a limpeza da memória ao finalizar processos...
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    // seleciona todos os usuários...
                    cmd.CommandText = sql;

                    // o data adapter irá executar o comando e a conexão no banco de dados
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    // preencher o data table com os dados do banco de dados
                    da.Fill(dt);

                    // fecha conexão
                    ConexaoBanco().Close();

                    // retorna um data table - tabela de todos os usuários
                    return dt;
                }
            }
            catch (Exception ex)
            {
                // fecha conexão
                ConexaoBanco().Close();

                // controle de erro...
                throw ex;
            }
        }
    }
}
