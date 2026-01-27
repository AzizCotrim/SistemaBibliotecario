using Microsoft.Data.SqlClient;
using Sistema_de_Biblioteca.Domain.Entities.Categoria;
using Sistema_de_Biblioteca.Infrastructure.Database;
using System.Data;

namespace Sistema_de_Biblioteca.Infrastructure.Repositories
{
    internal class CategoriaRepository
    {
        public bool ExisteCategoria(SqlConnection con, string nome)
        {

            string sql = @"SELECT COUNT(*)
                             FROM BI_CATEGORIAS
                            WHERE CAT_NOME LIKE @Nome";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Nome", nome);

                int qtd = (int)cmd.ExecuteScalar();

                return qtd > 0;
            }

        }
        //Trocar pelo DTO certo
        public int CadastrarCategoria(SqlConnection con, SqlTransaction tra, Categoria categoria)
        {
            string sql = @"INSERT INTO BI_CATEGORIAS (CAT_NOME, CAT_DESCRICAO)
                           VALUES (@Nome, @Descricao)";

            using (SqlCommand cmd = new SqlCommand(sql, con, tra))
            {
                cmd.Parameters.AddWithValue("@Nome", categoria.Nome);
                cmd.Parameters.AddWithValue("@Descricao", categoria.Descricao);
                return cmd.ExecuteNonQuery();
            }
        }

        public List<Categoria> BuscarCategoriasSimples(SqlConnection con)
        {
            List<Categoria> list = new List<Categoria>();


            string sql = @"SELECT CAT_ID, CAT_NOME
                             FROM BI_CATEGORIAS";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string nome = dr.GetString(1);

                    list.Add(new Categoria(id, nome));
                }
            }

            return list;
        }
        //Table-Valued Parameter (TVP)
        public List<Categoria> BuscarCategoriaFiltro(SqlConnection con, List<int> idCategoria)
        {
            List<Categoria> list = new List<Categoria>();


            string sql = @"SELECT CAT_ID, CAT_NOME
                             FROM BI_CATEGORIAS
                            WHERE CAT_ID IN (SELECT Id FROM @Categorias)";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                DataTable tabela = new DataTable();
                tabela.Columns.Add("Id", typeof(int));

                foreach (var id in idCategoria)
                {
                    tabela.Rows.Add(id);
                }

                SqlParameter param = cmd.Parameters.AddWithValue("@categorias", tabela);
                param.SqlDbType = SqlDbType.Structured;
                param.TypeName = "dbo.TIPO_LISTA_CATEGORIA";

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        int id = dr.GetInt32(0);
                        string nome = dr.GetString(1);

                        list.Add(new Categoria(id, nome));
                    }
                }
            }
            return list;
        }
    }
}
