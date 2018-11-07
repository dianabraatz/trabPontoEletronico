using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPonto.Model;

namespace ProjetoPonto.DAO
{
    class FuncionarioDAO
    {
        //static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Charlan\Desktop\bdponto.mdf';Integrated Security=True;Connect Timeout=30";
        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\diana\source\repos\bdponto\bdponto.mdf';Integrated Security=True;Connect Timeout=30";


        public Boolean verificaLogin(Funcionario f)
        {
            String sql = "SELECT * FROM funcionario WHERE numRegistro=@numRegistro AND senha=@senha;";
            bool result;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@numRegistro", f.GetNumeroRegistro());
            sqlcmd.Parameters.AddWithValue("@senha", f.GetSenha());

            try
            {
                conn.Open();
                SqlDataReader rows = sqlcmd.ExecuteReader();
                result = rows.Read();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int VerificaNivelAcesso(Funcionario f)
        {
            string sql = "select f.nivelAcesso FROM funcao f JOIN funcionario func ON f.codFuncao = func.codFuncao WHERE func.numRegistro = @numRegistro AND func.senha = @senha;";
            int nivelAcesso = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@numRegistro", f.GetNumeroRegistro());
            sqlcmd.Parameters.AddWithValue("@senha", f.GetSenha());

            try
            {
                conn.Open();
                SqlDataReader result = sqlcmd.ExecuteReader();

                while (result.Read())
                {
                    nivelAcesso = Convert.ToInt32(result["nivelAcesso"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return nivelAcesso;
        }

        public int CadastraFuncionario(Funcionario f)
        {
            String sql = "INSERT INTO funcionario ([senha], [dataNascimento], [nome], [rg], [cpf], [cnh], [dataAdmissao], [ctps], [codFuncao], [codSetor]) VALUES " +
                                                 "(@senha, @DataNascimento, @Nome, @RG, @CPF, @CNH, @DataAdmissao, @CTPS , @CodFuncao, @CodSetor)";
            int result;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@senha", f.GetSenha());
            sqlcmd.Parameters.AddWithValue("@DataNascimento", f.GetDataNascimento());
            sqlcmd.Parameters.AddWithValue("@Nome", f.GetNome());
            sqlcmd.Parameters.AddWithValue("@RG", f.GetRG());
            sqlcmd.Parameters.AddWithValue("@CPF", f.GetCPF());
            sqlcmd.Parameters.AddWithValue("@CNH", f.GetCNH());
            sqlcmd.Parameters.AddWithValue("@DataAdmissao", f.GetDataAdmissao());
            sqlcmd.Parameters.AddWithValue("@CTPS", f.GetCTPS());
            sqlcmd.Parameters.AddWithValue("@CodSetor", f.GetCodSetor());
            sqlcmd.Parameters.AddWithValue("@CodFuncao", f.GetCodFuncao());


            try
            {
                conn.Open();
                result = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static DataTable PreencheCBFuncao()
        {
            string sql = "SELECT codFuncao, nome FROM funcao ORDER BY nome ASC;";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                reader = sqlcmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static DataTable PreencheCBSetor()
        {
            string sql = "SELECT codSetor, nome from setor ORDER BY nome ASC;";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                reader = sqlcmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        public static DataSet PreencheTabela()
        {
            string sql = "SELECT f.numRegistro as 'Numero de Registro', f.nome as 'Nome do Funcionario', s.nome as Setor, fu.nome as Função, f.cpf as CPF, f.dataNascimento AS 'Data de Nascimento' " +
                             "FROM funcionario f JOIN setor s ON f.codSetor = s.codSetor JOIN funcao fu ON f.codFuncao = fu.codFuncao;";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open(); 
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dataSet;
        }

        public static DataSet ExecutaFiltro(string sql, string valor)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;

            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dataSet;
        }

        public List<Funcionario> PreencheCampos(int numeroRegistro)
        {
            string sql = "SELECT * FROM funcionario WHERE numREgistro = @registro;";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            List<Funcionario> lista = new List<Funcionario>();

            sqlcmd.Parameters.AddWithValue("@registro", numeroRegistro);

            try
            {
                conn.Open();
                SqlDataReader result = sqlcmd.ExecuteReader();

                while (result.Read())
                {
                    Funcionario f = new Funcionario();
                    f.SetNumeroRegistro(Convert.ToInt32(result["numRegistro"]));
                    f.SetNome(Convert.ToString(result["nome"]));
                    f.SetCPF(Convert.ToString(result["cpf"]));
                    f.SetCNH(Convert.ToString(result["cnh"]));
                    f.SetCodFuncao(Convert.ToInt32(result["codFuncao"]));
                    f.SetCodSetor(Convert.ToInt32(result["codSetor"]));
                    f.SetCTPS(Convert.ToString(result["ctps"]));
                    f.SetDataAdmissao(Convert.ToDateTime(result["dataAdmissao"]));
                    f.SetDataNascimento(Convert.ToDateTime(result["dataNascimento"]));
                    f.SetRG(Convert.ToString(result["rg"]));
                    f.SetSenha(Convert.ToString(result["senha"]));

                    lista.Add(f);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public Boolean ExcluirFuncionario(int numeroRegistro)
        {
            string sql = "delete from funcionario where numRegistro = @registro";
            bool result = false;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            List<Funcionario> lista = new List<Funcionario>();

            sqlcmd.Parameters.AddWithValue("@registro", numeroRegistro);

            try
            {
                conn.Open();
                SqlDataReader rows = sqlcmd.ExecuteReader();
                result = rows.Read();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int EditarFuncionario(Funcionario f)
        {
            string sql = "UPDATE funcionario SET dataNascimento = @DataNascimento, nome = @Nome, rg = @RG, cpf = @CPF, cnh = @CNH,dataAdmissao = @DataAdmissao, ctps = @CTPS, codFuncao = @CodFuncao, codSetor = @CodSetor WHERE numRegistro = @numRegistro;";
            int result = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@numRegistro", f.GetNumeroRegistro());
            sqlcmd.Parameters.AddWithValue("@DataNascimento", f.GetDataNascimento());
            sqlcmd.Parameters.AddWithValue("@Nome", f.GetNome());
            sqlcmd.Parameters.AddWithValue("@RG", f.GetRG());
            sqlcmd.Parameters.AddWithValue("@CPF", f.GetCPF());
            sqlcmd.Parameters.AddWithValue("@CNH", f.GetCNH());
            sqlcmd.Parameters.AddWithValue("@DataAdmissao", f.GetDataAdmissao());
            sqlcmd.Parameters.AddWithValue("@CTPS", f.GetCTPS());
            sqlcmd.Parameters.AddWithValue("@CodSetor", f.GetCodSetor());
            sqlcmd.Parameters.AddWithValue("@CodFuncao", f.GetCodFuncao());

            try
            {
                conn.Open();
                result = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(""+ e.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public List<Funcionario> PreencheCamposAVF(int numeroRegistro)
        {
            string sql = "select f.numRegistro as 'num', f.dataNascimento as 'data', f.nome, f.rg, f.cpf, f.cnh, f.dataAdmissao 'dataAdm', f.ctps, fun.nome as 'Funcao', s.nome as 'Setor' from funcionario f JOIN setor s ON f.codSetor = s.codSetor JOIN funcao fun ON f.codFuncao = fun.codFuncao WHERE f.numRegistro = @registro";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            List<Funcionario> lista = new List<Funcionario>();

            sqlcmd.Parameters.AddWithValue("@registro", numeroRegistro);

            try
            {
                conn.Open();
                SqlDataReader result = sqlcmd.ExecuteReader();

                while (result.Read())
                {
                    Funcionario f = new Funcionario();
                    f.SetNumeroRegistro(Convert.ToInt32(result["num"]));
                    f.SetNome(Convert.ToString(result["nome"]));
                    f.SetCPF(Convert.ToString(result["cpf"]));
                    f.SetCNH(Convert.ToString(result["cnh"]));
                    f.SetNomeFuncao(Convert.ToString(result["Funcao"]));
                    f.SetNomeSetor(Convert.ToString(result["Setor"]));
                    f.SetCTPS(Convert.ToString(result["ctps"]));
                    f.SetDataAdmissao(Convert.ToDateTime(result["dataAdm"]));
                    f.SetDataNascimento(Convert.ToDateTime(result["data"]));
                    f.SetRG(Convert.ToString(result["rg"]));

                    lista.Add(f);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public static DataSet PreencheTabelaPontoAVF(int numeroRegistro)
        {
            string sql = "SELECT codPonto as Código, CONVERT(date, dh_ponto1) as 'Data', CONVERT(VARCHAR(10), dh_ponto1, 108) as 'Primeiro', CONVERT(VARCHAR(10), dh_ponto2, 108) as 'Segundo' ,CONVERT(VARCHAR(10), dh_ponto3, 108) as 'Terceiro', CONVERT(VARCHAR(10), dh_ponto4, 108) as 'Quarto' FROM ponto WHERE numRegistro = @numRegistro;";
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@numRegistro", numeroRegistro);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();  
                adapter.Fill(dataSet);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dataSet;
        }

        public int AlteraSenha(Funcionario f)
        {
            string sql = "UPDATE funcionario SET senha = @senha WHERE numRegistro = @numRegistro;";
            int result = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@numRegistro", f.GetNumeroRegistro());
            sqlcmd.Parameters.AddWithValue("@senha", f.GetSenha());

            try
            {
                conn.Open();
                result = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}

