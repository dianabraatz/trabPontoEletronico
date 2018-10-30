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
        //static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Charlan\Desktop\bdponto.mdf';Integrated Security=True;Connect Timeout=30";
        static string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\diana\source\repos\bdponto\bdponto.mdf';Integrated Security=True;Connect Timeout=30";
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

        public static DataTable PreencheCBNivelAcesso()
        {
                string sql = "SELECT nivelAcesso FROM funcao ORDER BY nivelAcesso ASC;";

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
        }
    }
