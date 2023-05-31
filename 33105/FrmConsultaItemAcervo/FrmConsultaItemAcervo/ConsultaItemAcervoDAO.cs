using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultaItemAcervo
{
    public class ConsultaItemAcervoDAO
    {
        private SqlConnection Connection { get; }

        public ConsultaItemAcervoDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ConsultaItemAcervoModel> Buscas(ConsultaItemAcervoModel consulta)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {


                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome, nomeAutor, tipoItem, nomeColecao, nomeLocal, secao, stts");
                sql.AppendLine("FROM mvtBiibItemAcervo ");
                sql.AppendLine("WHERE 1 = 1");

                if (!string.IsNullOrEmpty(consulta.NomeItem))
                {
                    sql.AppendLine("AND nome LIKE '%{consulta.NomeItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.AutorItem))
                {
                    sql.AppendLine("AND nomeAutor LIKE '%{consulta.AutorItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.TipoItem))
                {
                    sql.AppendLine("AND tipoItem LIKE '%{consulta.TipoItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.ColecaoItem))
                {
                    sql.AppendLine("AND nomeColecao LIKE '%{consulta.ColecaoItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.LocalItem))
                {
                    sql.AppendLine("AND nomeLocal LIKE '%{consulta.LocalItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.SecaoItem))
                {
                    sql.AppendLine("AND secao LIKE '%{consulta.SecaoItem}%'");
                }
                if (!string.IsNullOrEmpty(consulta.StatusItem))
                {
                    sql.AppendLine("AND stts LIKE '%{consulta.StatusItem}%'");
                }

                command.CommandText = sql.ToString();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        buscas.Add(PopulateDrBusca(dr));
                    }
                }

                return buscas;
            }
        }

        public void pop
    }
}
   