using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coprel.Model;

namespace Coprel.DAO
{
    class OcorrenciaDAO
    {
        //static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Charlan\Desktop\bdponto.mdf';Integrated Security=True;Connect Timeout=30";
        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\diana\source\repos\bdponto\bdponto.mdf';Integrated Security=True;Connect Timeout=30";
        

        public DataSet VerificaPontos(int numRegistro)
        {
            //string sql = "select p.codPonto as Código, CONVERT(VARCHAR(10), p.dh_ponto1, 108) as 'Primeiro', CONVERT(VARCHAR(10), p.dh_ponto2, 108) as 'Segundo' ,CONVERT(VARCHAR(10), p.dh_ponto3, 108) as 'Terceiro', CONVERT(VARCHAR(10), p.dh_ponto4, 108) as 'Quarto', CONVERT(date, p.dh_ponto1) as Data from ponto p JOIN funcionario f ON p.numRegistro = f.numRegistro WHERE f.numRegistro = @numRegistro AND (p.dh_ponto1 is null or p.dh_ponto2 is null or p.dh_ponto3 is null or p.dh_ponto4 is null)";
            //string sql = "select p.codPonto as Código, CONVERT(VARCHAR(10), p.dh_ponto1, 108) as 'Primeiro', CONVERT(VARCHAR(10), p.dh_ponto2, 108) as 'Segundo' ,CONVERT(VARCHAR(10), p.dh_ponto3, 108) as 'Terceiro', CONVERT(VARCHAR(10), p.dh_ponto4, 108) as 'Quarto', CONVERT(date, p.dh_ponto1) as Data from ponto p JOIN funcionario f ON p.numRegistro = f.numRegistro WHERE f.numRegistro = @numRegistro AND (p.dh_ponto1 is null or p.dh_ponto2 is null or p.dh_ponto3 is null or p.dh_ponto4 is null)";
            string sql = "select codPonto as Código, CONVERT(date, dh_ponto1) as 'Data', CONVERT(VARCHAR(10), dh_ponto1, 108) as 'Primeiro', CONVERT(VARCHAR(10), dh_ponto2, 108) as 'Segundo' ,CONVERT(VARCHAR(10), dh_ponto3, 108) as 'Terceiro', CONVERT(VARCHAR(10), dh_ponto4, 108) as 'Quarto' from ponto  WHERE numRegistro = @numRegistro AND (CONVERT(date, dh_ponto1) != CONVERT(date, CURRENT_TIMESTAMP)) AND (dh_ponto1 is null or dh_ponto2 is null or dh_ponto3 is null or dh_ponto4 is null)";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@numRegistro", numRegistro);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();    //abre a conexao com o banco
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

        public int CadastraOcorrencia(Ocorrencia o)
        {
            string sql = "INSERT INTO ocorrencia ([justificativa], [status], [codPonto]) VALUES (@justificativa, @status, @codPonto);";

            int result;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@justificativa", o.GetJustificativa());
            sqlcmd.Parameters.AddWithValue("@status", o.GetStatus());
            sqlcmd.Parameters.AddWithValue("@codPonto", o.GetCodPonto());

            try
            {
                conn.Open();

                //verifica se possui algum resultado na consulta
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

        public static DataTable PreencheCBStatus()
        {
            string sql = "SELECT idStatus, descricao FROM statusOcorrencia ORDER BY descricao ASC;";

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

        public DataSet PreencheTabelaAdm()
        {
            string sql = "select o.codOcorrencia as 'Código da Ocorrencia', f.numRegistro as 'Numero de Registro', f.nome as 'Nome do Funcionário', s.descricao as 'Descricao do Status', p.codPonto as 'Código', CONVERT(date, p.dh_ponto1) as 'Data', o.justificativa as 'Justificativa' " +
                         "FROM funcionario f " +
                            "INNER JOIN ponto p ON(f.numRegistro = p.numRegistro) " +
                            "INNER JOIN ocorrencia o ON(p.codPonto = o.codPonto) " +
                            "INNER JOIN statusOcorrencia s ON(o.status = s.idStatus) " +
                         "WHERE o.status != 2; ";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();    //abre a conexao com o banco
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

        public IList<Ocorrencia> PreencherCampos(int codigoOcorrencia)
        {
            string sql = "SELECT codOcorrencia, codPonto, status, justificativa FROM ocorrencia WHERE codOcorrencia = @codigoOcorrencia";


            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            List<Ocorrencia> lista = new List<Ocorrencia>();

            sqlcmd.Parameters.AddWithValue("@codigoOcorrencia", codigoOcorrencia);

            try
            {
                conn.Open();
                SqlDataReader result = sqlcmd.ExecuteReader();

                while (result.Read())
                {
                    Ocorrencia o = new Ocorrencia();
                    o.SetCodOcorrencia(Convert.ToInt32(result["codOcorrencia"]));
                    o.SetCodPonto(Convert.ToInt32(result["codPonto"]));
                    o.SetJustificativa(Convert.ToString(result["justificativa"]));
                    o.SetStatus(Convert.ToInt32(result["status"]));
                    lista.Add(o);
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

        public int EditarOcorrencia(Ocorrencia o)
        {
            string sql = "UPDATE ocorrencia SET status = @status WHERE [codOcorrencia ] = @codOcorrencia;";
            int result = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@status", o.GetStatus());
            sqlcmd.Parameters.AddWithValue("@codOcorrencia", o.GetCodOcorrencia());

            try
            {
                conn.Open();
                //verifica se possui algum resultado na consulta
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

        public DataSet FiltraNome(string nome)
        {
            string sql = "select o.codOcorrencia as 'Código da Ocorrencia', f.numRegistro as 'Numero de Registro', f.nome as 'Nome do Funcionário', s.descricao as 'Descricao do Status', p.codPonto as 'Código', CONVERT(date, p.dh_ponto1) as 'Data', o.justificativa as 'Justificativa' " +
                         "FROM funcionario f " +
                            "INNER JOIN ponto p ON(f.numRegistro = p.numRegistro) " +
                            "INNER JOIN ocorrencia o ON(p.codPonto = o.codPonto) " +
                            "INNER JOIN statusOcorrencia s ON(o.status = s.idStatus) " +
                         "WHERE f.nome LIKE @nome ORDER BY s.descricao ASC";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

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

        public DataSet PreencheTabelaTodos()
        {
            string sql = "select o.codOcorrencia as 'Código da Ocorrencia', f.numRegistro as 'Numero de Registro', f.nome as 'Nome do Funcionário', s.descricao as 'Descricao do Status', p.codPonto as 'Código', CONVERT(date, p.dh_ponto1) as 'Data', o.justificativa as 'Justificativa' " +
                         "FROM funcionario f " +
                            "INNER JOIN ponto p ON(f.numRegistro = p.numRegistro) " +
                            "INNER JOIN ocorrencia o ON(p.codPonto = o.codPonto) " +
                            "INNER JOIN statusOcorrencia s ON(o.status = s.idStatus) " +
                         "ORDER BY s.descricao ASC";

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlcmd;
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();    //abre a conexao com o banco
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
    }
}