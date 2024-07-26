using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CFB_Academia
{
    internal class class_Banco
    {
        // propriedades
        private static SQLiteConnection conexao;

        // ****************
        // Funções GENÉRICA
        // ****************

        // método ConexaoBanco()
        private static SQLiteConnection ConexaoBanco()
        {
            // cria uma instância do objeto sqlite o caminho do banco de dados
            //conexao = new SQLiteConnection("Data Source=D:\\ProjetosDEV\\Curso-Programa-CSharp\\Aula100\\CFB_Academia\\DataBase\\banco_Academia.db");
            conexao = new SQLiteConnection("Data Source=" + class_Global.caminhoBancoDados + class_Global.nomeBancoDados);

            // abre a conexão com o banco de dados
            conexao.Open();
            
            // retorna a conexão do banco de dados...
            return conexao;
        }

        // método genérico para consulta de dados...
        // Data Query Language
        public static DataTable DQL_ConsultaGenerica(string sql)
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

                    // retorna um data table - tabela de todos os usuários
                    return dt;
                }
            }
            catch (Exception ex)
            {
                // controle de erro...
                throw;
            }
        }

        // método genérico para consulta de dados...
        // Data Manipulation Language (insert, delete e update)
        public static void DML_CrudGenerico(string q, string msgOK = null, string msgERRO = null)
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
                    cmd.CommandText = q;

                    // o data adapter irá executar o comando e a conexão no banco de dados
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    // executar qyery
                    cmd.ExecuteNonQuery();

                    // valida msgOK
                    if (msgOK != null)
                    {
                        // mostra msgOK
                        MessageBox.Show(msgOK);
                    }
                }
            }
            catch (Exception ex)
            {

                // valida msgERRO
                if (msgERRO != null)
                {
                    // mostra msgERRO
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                // controle de erro...
                throw;
            }
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

                    // retorna um data table - tabela de todos os usuários
                    return dt;
                }
            }
            catch (Exception ex)
            {
                // controle de erro...
                throw;
            }
        }

        // métodos do Formulário frm_GestaUsuarios
        // método ObterTodosUsuarios()
        public static DataTable ObterUsuariosIdNome()
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
                    cmd.CommandText = "SELECT n_idusuario AS 'ID Usuário', t_nomeusuario AS 'Nome Usuário' FROM tb_usuarios";

                    // o data adapter irá executar o comando e a conexão no banco de dados
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    // preencher o data table com os dados do banco de dados
                    da.Fill(dt);

                    // retorna um data table - tabela de todos os usuários
                    return dt;
                }
            }
            catch (Exception ex)
            {
                // controle de erro...
                throw;
            }
        }

        // método ObterDadosUsuario()
        public static DataTable ObterDadosUsuario(string nid)
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
                    //cmd.CommandText = "SELECT n_idusuario, t_nomeusuario, t_username, t_senhausuario, t_statususuario, n_nivelusuario FROM tb_usuarios WHERE n_idusuario=@idusuario";
                    cmd.CommandText = "SELECT n_idusuario, t_nomeusuario, t_username, t_senhausuario, t_statususuario, n_nivelusuario FROM tb_usuarios WHERE n_idusuario=" + nid;

                    // parametros
                    //cmd.Parameters.AddWithValue("@idusuario", nid);
                    
                    // o data adapter irá executar o comando e a conexão no banco de dados
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    // preencher o data table com os dados do banco de dados
                    da.Fill(dt);

                    // retorna um data table - tabela de todos os usuários
                    return dt;
                }
            }
            catch (Exception ex)
            {
                // controle de erro...
                throw;
            }
        }

        // método AtualizarUsuario()
        public static void AtualizarUsuario(class_Usuario classUsuario)
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
                    cmd.CommandText = "UPDATE tb_usuarios SET t_nomeusuario='" + classUsuario.P_t_nomeusuario + "', t_username='" + classUsuario.P_t_username + "', t_senhausuario='" + classUsuario.P_t_senhausuario + "', t_statususuario='" + classUsuario.P_t_statususuario + "', n_nivelusuario=" + classUsuario.P_n_nivelusuario + " WHERE n_idusuario=" + classUsuario.P_n_idusuario;

                    // o data adapter irá executar o comando e a conexão no banco de dados
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    // executar qyery
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // controle de erro...
                throw;
            }
        }

        // método ExcluirUsuario()
        public static void ExcluirUsuario(string id)
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
                    cmd.CommandText = "DELETE FROM tb_usuarios WHERE n_idusuario=" + id;

                    // o data adapter irá executar o comando e a conexão no banco de dados
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    // executar qyery
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // controle de erro...
                throw;
            }
        }
        // FIM dos métodos do Formulário frm_GestaUsuarios

        // métodos do Formulário frm_NovoUsuario
        public static void NovoUsuario(class_Usuario usuario)
        {
            // valida se existe usuário (UserName)...
            if (ExisteUserName(usuario))
            {
                // existe!
                MessageBox.Show("UserName já existe! Informe novo UserName!");
                return; // para a execução...
            }
            else 
            {
                // validação de erros...
                try
                {
                    // executa um bloco de comandos e garante a limpeza da memória ao finalizar processos...
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {
                        // seleciona todos os usuários...
                        cmd.CommandText = "INSERT INTO tb_usuarios (t_nomeusuario, t_username, t_senhausuario, t_statususuario, n_nivelusuario) VALUES (@nomeusuario, @username, @senhausuario, @statususuario, @nivelusuario)";

                        // parametros
                        cmd.Parameters.AddWithValue("@nomeusuario", usuario.P_t_nomeusuario);
                        cmd.Parameters.AddWithValue("@username", usuario.P_t_username);
                        cmd.Parameters.AddWithValue("@senhausuario", usuario.P_t_senhausuario);
                        cmd.Parameters.AddWithValue("@statususuario", usuario.P_t_statususuario);
                        cmd.Parameters.AddWithValue("@nivelusuario", usuario.P_n_nivelusuario);
                        
                        // executar qyery
                        cmd.ExecuteNonQuery();
                        
                        // mostra mensagem pro usuário...
                        MessageBox.Show("Novo Usuário Inserido com Sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    // mostra mensagem pro usuário...
                    MessageBox.Show("ERRO ao Inserir Novo Usuário!");
                }
            }
        }
        // FIM dos métodos do Formulário frm_NovoUsuario

        // ROTINAS GERAIS
        public static bool ExisteUserName(class_Usuario usuario)
        {
            // declaração de ariáveis
            bool res = false;

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
                    cmd.CommandText = "SELECT t_username FROM tb_usuarios WHERE t_username='" + usuario.P_t_username + "'";
                    
                    // o data adapter irá executar o comando e a conexão no banco de dados
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());

                    // preencher o data table com os dados do banco de dados
                    da.Fill(dt);

                    // valida dt - tem linhas...
                    if (dt.Rows.Count > 0)
                    {
                        res = true;
                    }
                    else 
                    {
                        res = false;
                    }

                    // retorna um data table - tabela de todos os usuários
                    return res;
                }
            }
            catch (Exception ex)
            {
                // controle de erro...
                throw;
            }
        }
    }
}
