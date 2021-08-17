using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Crud_DatabaseFirst
{
    class ComandosSQL
    {
        static string connectionString = "Data Source=AUSTREGISELO-JU;Initial Catalog=DB_ECCUSBET;Persist Security Info=True;User ID=sa;Password=AstroSQLserver1";

        /// <summary>
        /// Método parea adicionar dados a grid <see cref="Form1.dataGridView1"/>
        /// </summary>
        /// <param name="ViewVolumeUtio"></param>
        /// <param name="ViewLargura"></param>
        /// <param name="ViewComprimento"></param>
        /// <param name="ViewProfundidade"></param>
        /// <param name="ViewQtePeneus"></param>
        public void AdicionarDadosTbDimensionamento(float ViewVolumeUtio, float ViewLargura, float ViewComprimento, float ViewProfundidade, int ViewQtePeneus)
        {
            try
            {
                using (SqlConnection conexaoSql = new SqlConnection(connectionString))
                {
                    var comandosSQL = new SqlCommand("SP_InserirDados_TbDimensionamento", conexaoSql);
                    comandosSQL.CommandType = CommandType.StoredProcedure;
                    comandosSQL.Parameters.AddWithValue("@Novo_Volume_Util", ViewVolumeUtio);
                    comandosSQL.Parameters.AddWithValue("@Nova_Largura", ViewLargura);
                    comandosSQL.Parameters.AddWithValue("@Novo_Comprimento", ViewComprimento);
                    comandosSQL.Parameters.AddWithValue("@Nova_Profundidade", ViewProfundidade);
                    comandosSQL.Parameters.AddWithValue("@NovaQte_Pneus", ViewQtePeneus);

                    conexaoSql.Open();
                    SqlDataReader reader = comandosSQL.ExecuteReader();
                }
            }
            catch (SqlException msg)
            {
                MessageBox.Show($"Erro, {msg.Message}", MessageBoxButtons.OK.ToString());
            }
        }

        /// <summary>
        /// Método para atualizar os dados da grid "<see cref="Form1.dataGridView1"/>"
        /// </summary>
        /// <param name="ViewVolumeUtio"></param>
        /// <param name="ViewLargura"></param>
        /// <param name="ViewComprimento"></param>
        /// <param name="ViewProfundidade"></param>
        /// <param name="ViewQtePeneus"></param>
        public void AtualizarDadosTbDimensionamento(int ViewId, float ViewVolumeUtio, float ViewLargura, float ViewComprimento, float ViewProfundidade, int ViewQtePeneus)
        {
            try
            {
                using (SqlConnection conexaoSql = new SqlConnection(connectionString))
                {
                    var comandosSQL = new SqlCommand("SP_AtualizarDados_TbDimensionamento", conexaoSql);
                    comandosSQL.CommandType = CommandType.StoredProcedure;
                    comandosSQL.Parameters.AddWithValue("@IdAtualizado", ViewId);
                    comandosSQL.Parameters.AddWithValue("@Novo_Volume_Util", ViewVolumeUtio);
                    comandosSQL.Parameters.AddWithValue("@Nova_Largura", ViewLargura);
                    comandosSQL.Parameters.AddWithValue("@Novo_Comprimento", ViewComprimento);
                    comandosSQL.Parameters.AddWithValue("@Nova_Profundidade", ViewProfundidade);
                    comandosSQL.Parameters.AddWithValue("@NovaQte_Pneus", ViewQtePeneus);

                    conexaoSql.Open();
                    SqlDataReader reader = comandosSQL.ExecuteReader();
                }
            }
            catch (SqlException msg)
            {
                MessageBox.Show($"Erro, {msg.Message}", MessageBoxButtons.OK.ToString());
            }
        }

        /// <summary>
        /// Método para excluir linha da grid a parti do id "<see cref="Form1.TxtId"/>"
        /// </summary>
        /// <param name="id"></param>
        public void ExcluirDadosTbDimensionamentop(int id)
        {
            try
            {
                using (SqlConnection conexaoSql = new SqlConnection(connectionString))
                {
                    var comandosSQL = new SqlCommand("SP_ExcluirDados_TbDimensionamento", conexaoSql);
                    comandosSQL.CommandType = CommandType.StoredProcedure;
                    comandosSQL.Parameters.AddWithValue("@LinhaExcluida", id);

                    conexaoSql.Open();
                    SqlDataReader reader = comandosSQL.ExecuteReader();
                }
            }
            catch (SqlException msg)
            {
                MessageBox.Show($"Erro, {msg.Message}", MessageBoxButtons.OK.ToString());
            }
        }

        /// <summary>
        /// Método para carregar a grid "<see cref="Form1.dataGridView1"/>"
        /// </summary>
        /// <param name="ViewGrid"></param>
        public void CarregarGridTbDimensionamento(Form1 ViewGrid)
        {
            try
            {
                using (SqlConnection conexaoSql = new SqlConnection(connectionString))
                {
                    conexaoSql.Open();
                    var comandoSQL = new SqlCommand("SP_Carregar_TbDimensionamento", conexaoSql);
                    comandoSQL.CommandType = CommandType.StoredProcedure;

                    var da = new SqlDataAdapter(comandoSQL);
                    var ds = new DataSet();
                    da.Fill(ds, "Tabela de Dimensionamento");
                    ViewGrid.dataGridView1.DataSource = ds.Tables["Tabela de Dimensionamento"];
                }
            }
            catch (SqlException msg)
            {
                MessageBox.Show($"Erro, {msg.Message}", MessageBoxButtons.OK.ToString());
            }
        }
    }
}
