using Coprel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coprel.DAO
{
    class FuncaoDAO
    {
        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Charlan\Desktop\bdponto.mdf';Integrated Security=True;Connect Timeout=30";
        //static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\diana\source\repos\bdponto\bdponto.mdf';Integrated Security=True;Connect Timeout=30";
        public static DataSet PreencheTabela()
        {

            string sql = "SELECT codFuncao as 'Código', nivelAcesso as 'Nível de Acesso', nome as 'Descrição' FROM funcao;";

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

        public static DataTable PreencheCBNivelAcesso()
        {
            string sql = "SELECT DISTINCT nivelAcesso FROM funcao ORDER BY nivelAcesso ASC;";

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

        public int CadastraFuncao(Funcao f)
        {
            String sql = "INSERT INTO funcao ([nome], [nivelAcesso]) VALUES " +
                                                 "(@nome, @nivelAcesso)";
            int result;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);
            sqlcmd.Parameters.AddWithValue("@nivelAcesso", f.GetNivelAcesso());
            sqlcmd.Parameters.AddWithValue("@nome", f.GetNome());

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

        public int ExcluiFuncao(Funcao f)
        {
            string sql = "delete from funcao where codFuncao = @codigo";
            int result = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@codigo", f.GetCodFuncao());

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

        public int EditarFuncao(Funcao f)
        {
            string sql = "UPDATE funcao SET nivelAcesso = @nivelAcesso, nome = @nome WHERE codFuncao = @codigo;";
            int result = 0;

            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand sqlcmd = new SqlCommand(sql, conn);

            sqlcmd.Parameters.AddWithValue("@codigo", f.GetCodFuncao());
            sqlcmd.Parameters.AddWithValue("@nivelAcesso", f.GetNivelAcesso());
            sqlcmd.Parameters.AddWithValue("@nome", f.GetNome());

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
    }
}

