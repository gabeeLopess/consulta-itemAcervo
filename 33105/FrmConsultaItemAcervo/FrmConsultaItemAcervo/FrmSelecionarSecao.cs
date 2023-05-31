using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultaItemAcervo
{
    public partial class FrmSelecionarSecao : Form
    {
        public String SecaoEnviadas { get; private set; }
        public FrmSelecionarSecao()
        {
            InitializeComponent();
        }
        public string DescricaoSecao { get; private set; }
        private void Fechar()
        {
            DescricaoSecao = txtSecao.Text;

            this.Close();
        }

        private void SelecionarSecao_Load(object sender, EventArgs e)
        {
            CarregarSecaogrid();
        }

        private void CarregarSecaogrid()
        {
            gridLayout.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SecaoDao dao = new SecaoDao(connection);
                List<SecaoModel> secaos = dao.GetSecaos();
                foreach (SecaoModel secao in secaos)
                {

                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodSecao.Index].Value = secao.CodSecao;
                    row.Cells[colSecao.Index].Value = secao.DescricaoSecao;

                }
            }
        }
        private void txtCodigoSecao_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtCodigoSecao.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string codSecao = row.Cells[colCodSecao.Index].Value.ToString().Trim();
                bool exibir = codSecao.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtSecao_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtSecao.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string secao = row.Cells[colSecao.Index].Value.ToString().Trim();
                bool exibir = secao.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void gridLayout_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigoSecao.Text = gridLayout.Rows[e.RowIndex].Cells[colCodSecao.Index].Value + "";
                txtSecao.Text = gridLayout.Rows[e.RowIndex].Cells[colSecao.Index].Value + "";

                Fechar();

            }
        }
    }
}
