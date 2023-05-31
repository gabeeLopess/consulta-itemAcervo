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
    public partial class FrmSelecionarLocal : Form
    {
        public string LocaisEnviados { get; private set; }
        public FrmSelecionarLocal()
        {
            InitializeComponent();
        }
        public string NomeLocal { get; private set; }
        private void Fechar()
        {
            NomeLocal = txtDescricaoLocal.Text;

            this.Close();
        }

        private void FrmSelecionarLocal_Load(object sender, EventArgs e)
        {
            CarregarLocaisgrid();
        }

        private void CarregarLocaisgrid()
        {
            gridLayout.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LocalDAO dao = new LocalDAO(connection);
                List<LocalModel> locais = dao.GetLocais();
                foreach (LocalModel local in locais)
                {

                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodigoLocal.Index].Value = local.CodLocal;
                    row.Cells[colDescricaoLocal.Index].Value = local.NomeLocal;

                }
            }
        }

        private void txtCodigoLocal_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtCodigoLocal.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string codLocal = row.Cells[colCodigoLocal.Index].Value.ToString().Trim();
                bool exibir = codLocal.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtDescricaoLocal_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtDescricaoLocal.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string descricaoLocal = row.Cells[colDescricaoLocal.Index].Value.ToString().Trim();
                bool exibir = descricaoLocal.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void gridLayout_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigoLocal.Text = gridLayout.Rows[e.RowIndex].Cells[colCodigoLocal.Index].Value + "";
                txtDescricaoLocal.Text = gridLayout.Rows[e.RowIndex].Cells[colDescricaoLocal.Index].Value + "";

                Fechar();

            }
        }
    }
}
