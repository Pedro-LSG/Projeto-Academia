using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLife.Controle
{
    public class BD
    {
        /*MÉTODOS*/
        //Criação do método INSERIR USUÁRIO
        public int InserirUsuario(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "INSERT INTO Usuario([nome], [telefone], [idade], [altura], [peso], [metaPeso], [usuario], [senha], [email]) VALUES (@nome, @telefone, @idade, @altura, @peso, @metaPeso , @usuario, @senha, @email)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objTabela.Telefone;
                cn.Parameters.Add("idade", SqlDbType.Int).Value = objTabela.Idade;
                cn.Parameters.Add("altura", SqlDbType.Float).Value = objTabela.Altura;
                cn.Parameters.Add("peso", SqlDbType.Float).Value = objTabela.Peso;
                cn.Parameters.Add("metaPeso", SqlDbType.VarChar).Value = objTabela.MetaPeso;
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                //Abrindo mais uma conexão
                cn.Connection = con;
                //Executando e, eventualmente, exibindo
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        //Método para pesquisar ID
        public Entidade PesquisaId(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT IdUsuario FROM Usuario WHERE usuario = @usuario";
                cn.Connection = con;
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                SqlDataReader dr;
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        objTabela.IdUsuario2 = Convert.ToInt32(dr["IdUsuario"]);
                    }                    
                }
                else
                {
                    objTabela.IdUsuario2 = 0;
                }
                return objTabela;
            }
        }

        //Método para perfil cliente
        public List<Entidade> PerfilCliente(Entidade objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT * FROM Usuario WHERE IdUsuario = @IdUsuario2";
                cn.Connection = con;
                cn.Parameters.Add("IdUsuario2", SqlDbType.VarChar).Value = objTabela.IdUsuario2;
                SqlDataReader dr;
                List<Entidade> Lista = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.IdUsuario2 = Convert.ToInt32(dr["idUsuario"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Idade = Convert.ToInt32(dr["idade"]);
                        dado.Altura = Convert.ToSingle(dr["altura"]);
                        dado.Peso = Convert.ToSingle(dr["peso"]);
                        dado.MetaPeso = Convert.ToString(dr["metaPeso"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }

        //Listando no grid
        public List<Entidade> ListaEx(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT * FROM ClienteExercicio WHERE idUsuario = @idUsuario2";
                cn.Parameters.Add("idUsuario2", SqlDbType.VarChar).Value = objTabela.IdUsuario2;
                cn.Connection = con;
                SqlDataReader dr;
                List<Entidade> Lista = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.IdExercicio = Convert.ToString(dr["idExercicio"]);
                        dado.Exercicio = Convert.ToString(dr["exercicio"]);
                        dado.Repeticao = Convert.ToString(dr["repeticao"]);
                        dado.Descanso = Convert.ToString(dr["descanso"]);
                        dado.Sessao = Convert.ToString(dr["sessao"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }

        //Método para pegar email
        public int PegaEmail(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT email FROM Usuario WHERE email = @email";
                cn.Connection = con;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                SqlDataReader dr;
                List<Entidade> Lista = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    //Verificação de todos os email cadastrados
                    return 1;
                }
                //Se o email estivere cadastrado
                return 0;
            }
        }

        //Método para salvar datagrid do usuário
        public void ExUsu(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos os parâmetros para o comando funcionar
                cn.CommandText = "INSERT INTO ClienteExercicio VALUES (@idExercicio, @idUsuario, @exercicio, @repeticao, @descanso, @sessao)";
                cn.Parameters.Add("idExercicio", SqlDbType.VarChar).Value = objTabela.IdExercicio;
                cn.Parameters.Add("idUsuario", SqlDbType.VarChar).Value = objTabela.IdUsuario;
                cn.Parameters.Add("exercicio", SqlDbType.VarChar).Value = objTabela.Exercicio;
                cn.Parameters.Add("repeticao", SqlDbType.VarChar).Value = objTabela.Repeticao;
                cn.Parameters.Add("descanso", SqlDbType.VarChar).Value = objTabela.Descanso;
                cn.Parameters.Add("sessao", SqlDbType.VarChar).Value = objTabela.Sessao;
                //Abrindo mais uma conexão
                cn.Connection = con;
                cn.ExecuteNonQuery();
            }
        }

        //Método usado para atualizar senha esquecida
        public Entidade EsqSenha(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT * FROM Usuario WHERE usuario = @usuario AND email = @email AND idUsuario = @idUsuario";
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cn.Parameters.Add("idUsuario", SqlDbType.Int).Value = objTabela.IdUsuario;
                cn.Connection = con;
                SqlDataReader dr;
                List<Entidade> Pesquisa = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    //Verificação de todos os usuários cadastrados
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Email = Convert.ToString(dr["senha"]);
                        dado.IdUsuario = Convert.ToString(dr["idUsuario"]);
                    }
                }
                else
                {
                    //Se o usuário ou senha não estiverem cadastrados ambos os campos ficam vazios
                    objTabela.Usuario = null;
                    objTabela.Email = null;
                }
                return objTabela;
            }
        }

        //Método para atualizar senha esquecida
        public int AtuSenha(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "UPDATE Usuario SET senha = @senha WHERE idUsuario = @idUsuario";
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cn.Parameters.Add("idUsuario", SqlDbType.Int).Value = objTabela.IdUsuario;
                //Abrindo mais uma conexão
                cn.Connection = con;
                //Executando e, eventualmente, exibindo
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        //Criação do método ATUALIZAR EXERCÍCIO
        public int AtualizarExercicio(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "UPDATE Sistema SET exercicio = @exercicio,  repeticao = @repeticao, descanso = @descanso, sessao = @sessao WHERE idExercicio = @idExercicio";
                cn.Parameters.Add("idExercicio", SqlDbType.Int).Value = objTabela.IdExercicio;
                cn.Parameters.Add("exercicio", SqlDbType.VarChar).Value = objTabela.Exercicio;
                cn.Parameters.Add("repeticao", SqlDbType.Int).Value = objTabela.Repeticao;
                cn.Parameters.Add("descanso", SqlDbType.Int).Value = objTabela.Descanso;
                cn.Parameters.Add("sessao", SqlDbType.Int).Value = objTabela.Sessao;
                //Abrindo mais uma conexão
                cn.Connection = con;
                //Executando e, eventualmente, exibindo
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        //Criação do método EXCLUIR EXERCÍCIO
        public int ExcluirExercicio(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "DELETE FROM Sistema WHERE idExercicio = @idExercicio";
                cn.Parameters.Add("idExercicio", SqlDbType.Int).Value = objTabela.IdExercicio;
                //Abrindo mais uma conexão
                cn.Connection = con;
                //Executando e, eventualmente, exibindo
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        //Criação do método LOGIN
        public Entidade Login(Entidade obj)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT * FROM Usuario WHERE usuario = @usuario AND senha = @senha";
                cn.Connection = con;
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = obj.Usuario;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;
                SqlDataReader dr;
                List<Entidade> Lista = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    //Verificação de todos os usuários cadastrados
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                    }
                }
                else
                {
                    //Se o usuário ou senha não estiverem cadastrados ambos os campos ficam vazios
                    obj.Usuario = null;
                    obj.Senha = null;
                }
                return obj;
            }
        }

        //Método para listar os dados dos USUÁRIOS no datagrid
        public List<Entidade> ListarUsuario()
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT * FROM Usuario ORDER BY nome ASC";

                cn.Connection = con;

                SqlDataReader dr;
                List<Entidade> Lista = new List<Entidade>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.IdUsuario2 = Convert.ToInt32(dr["idUsuario"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Idade = Convert.ToInt32(dr["idade"]);
                        dado.Altura = Convert.ToSingle(dr["altura"]);
                        dado.Peso = Convert.ToSingle(dr["peso"]);
                        dado.MetaPeso = Convert.ToString(dr["metaPeso"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Email = Convert.ToString(dr["email"]);

                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }

        //Criação do método para listar os EXERCÍCIOS
        public List<Entidade> ListarExercicio()
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT * FROM Sistema ORDER BY idExercicio ASC";
                //Abrindo mais uma conexão
                cn.Connection = con;
                SqlDataReader dr;
                List<Entidade> Lista = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.IdExercicio = Convert.ToString(dr["idExercicio"]);
                        dado.Exercicio = Convert.ToString(dr["exercicio"]);
                        dado.Repeticao = Convert.ToString(dr["repeticao"]);
                        dado.Descanso = Convert.ToString(dr["descanso"]);
                        dado.Sessao = Convert.ToString(dr["sessao"]);
                        Lista.Add(dado);
                    }
                }
                return Lista;
            }
        }

        //Criação do método para inserção dos EXERCÍCIOS
        public int InserirExercicio(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "INSERT INTO Sistema([exercicio], [repeticao], [descanso], [sessao]) VALUES (@exercicio, @repeticao, @descanso, @sessao)";
                cn.Parameters.Add("exercicio", SqlDbType.VarChar).Value = objTabela.Exercicio;
                cn.Parameters.Add("repeticao", SqlDbType.Int).Value = objTabela.Repeticao;
                cn.Parameters.Add("descanso", SqlDbType.Int).Value = objTabela.Descanso;
                cn.Parameters.Add("sessao", SqlDbType.Int).Value = objTabela.Sessao;
                //Abrindo mais uma conexão
                cn.Connection = con;
                //Executando e, eventualmente, exibindo
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        //Criação do método EXCLUIR USUÁRIO
        public int ExcluirUsuario(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "DELETE FROM Usuario WHERE idUsuario = @idUsuario";
                cn.Parameters.Add("IdUsuario", SqlDbType.Int).Value = objTabela.IdUsuario;

                //Abrindo mais uma conexão
                cn.Connection = con;
                //Executando e, eventualmente, exibindo
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        //Criação do método ATUALIZAR USUÁRIO
        public int AtualizarUsuario(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "UPDATE Usuario SET nome = @nome, telefone = @telefone, idade = @idade, altura = @altura, peso = @peso, metaPeso = @metaPeso, usuario = @usuario, senha = @senha, email = @email WHERE idUsuario = @idUsuario";
                cn.Parameters.Add("idUsuario", SqlDbType.Int).Value = objTabela.IdUsuario;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objTabela.Telefone;
                cn.Parameters.Add("idade", SqlDbType.Int).Value = objTabela.Idade;
                cn.Parameters.Add("altura", SqlDbType.Float).Value = objTabela.Altura;
                cn.Parameters.Add("peso", SqlDbType.Float).Value = objTabela.Peso;
                cn.Parameters.Add("metaPeso", SqlDbType.VarChar).Value = objTabela.MetaPeso;
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                //Abrindo mais uma conexão
                cn.Connection = con;
                //Executando e, eventualmente, exibindo
                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;
            }
        }

        //Método para pesquisa de um USUÁRIO
        public List<Entidade> PesquisarUsuario(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT * FROM Usuario WHERE nome = @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Connection = con;
                SqlDataReader dr;
                List<Entidade> Pesquisa = new List<Entidade>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.IdUsuario2 = Convert.ToInt32(dr["idUsuario"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Idade = Convert.ToInt32(dr["idade"]);
                        dado.Altura = Convert.ToSingle(dr["altura"]);
                        dado.Peso = Convert.ToSingle(dr["peso"]);
                        dado.MetaPeso = Convert.ToString(dr["metaPeso"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        Pesquisa.Add(dado);
                    }
                }
                return Pesquisa;
            }
        }

        //Método para pesquisa de um EXERCICIO
        public List<Entidade> PesquisarExercicio(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT * FROM Sistema WHERE exercicio = @exercicio";
                cn.Parameters.Add("exercicio", SqlDbType.VarChar).Value = objTabela.Exercicio;
                cn.Connection = con;
                SqlDataReader dr;
                List<Entidade> Pesquisa = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.IdExercicio2 = Convert.ToInt32(dr["idExercicio"]);
                        dado.Exercicio = Convert.ToString(dr["exercicio"]);
                        dado.Repeticao = Convert.ToString(dr["repeticao"]);
                        dado.Descanso = Convert.ToString(dr["descanso"]);
                        dado.Sessao = Convert.ToString(dr["sessao"]);
                        Pesquisa.Add(dado);
                    }
                }
                return Pesquisa;
            }
        }

        //Verificando se o nome de usuário inserido já existe
        public int ExistUsu(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                cn.CommandText = "SELECT usuario FROM Usuario WHERE usuario = @usuario";
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cn.Connection = con;
                SqlDataReader dr;
                List<Entidade> Pesquisa = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        //Cálculo IMC
        public string CalcImc(Entidade objTabela)
        {
            //Criação da string de conexão 
            using (SqlConnection con = new SqlConnection())
            {
                //String conexão
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                //Abrindo conexão
                con.Open();
                //Dandos s parâmetros para o comando funcionar
                //cn.CommandText = "SELECT Altura, Peso, (Peso/(Altura*Altura)) FROM Usuario WHERE usuario = @usuario";
                cn.CommandText = "SELECT SUM(peso / (altura * altura)) AS total FROM Usuario WHERE IdUsuario = @IdUsuario2";
                cn.Parameters.Add("idUsuario2", SqlDbType.VarChar).Value = objTabela.IdUsuario2;
                cn.Connection = con;
                SqlDataReader dr;
                //List<Entidade> Pesquisa = new List<Entidade>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Entidade dado = new Entidade();
                        dado.Imc = Convert.ToDouble(dr["total"]);
                        //Pesquisa.Add(dado);
                        string formatado = string.Format("{0:n2}", Math.Round(dado.Imc, 2));
                        return formatado;
                    }
                }
                return null;
            }
        }

    }
}
