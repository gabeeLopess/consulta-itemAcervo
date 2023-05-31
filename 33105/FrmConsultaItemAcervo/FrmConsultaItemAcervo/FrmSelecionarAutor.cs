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
    public partial class FrmSelecionarAutor : Form
    {
        public String AutoresEnviados { get; private set; }

        public FrmSelecionarAutor()
        {
            InitializeComponent();
        }
        public string NomeAutor { get; private set; }
        public void Fechar()
        {
            NomeAutor = txtNomeAutor.Text;

            this.Close();
        }
        private void FrmSelecionarAutor_Load(object sender, EventArgs e)
        {
            CarregarAutoresgrid();
        }
        private void CarregarAutoresgrid()
        {
            gridLayout.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                AutorDAO dao = new AutorDAO(connection);
                List<AutorModel> autores = dao.GetAutores();
                foreach (AutorModel autor in autores)
                {

                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodAutor.Index].Value = autor.CodAutor;
                    row.Cells[colNomeAutor.Index].Value = autor.NomeAutor;

                }
            }
        }

        private void txtCodigoAutor_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeAutor.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string codigoAutor = row.Cells[colNomeAutor.Index].Value.ToString().Trim();
                bool exibir = codigoAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtNomeAutor2_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeAutor.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string nomeAutor = row.Cells[colNomeAutor.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }


        private void gridLayout_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigoAutor.Text = gridLayout.Rows[e.RowIndex].Cells[colCodAutor.Index].Value + "";
                txtNomeAutor.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeAutor.Index].Value + "";

                Fechar();

            }

        }

  

        private void txtAutor_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {

        }

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridLayout_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
    }
}
