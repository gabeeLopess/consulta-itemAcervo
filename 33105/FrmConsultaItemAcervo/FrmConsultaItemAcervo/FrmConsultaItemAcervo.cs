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
    public partial class FrmConsultaItemAcervo : Form
    {
        private SqlConnection Connection { get; }
        public FrmConsultaItemAcervo(SqlConnection connection)
        {
            Connection = connection;
        }
        public FrmConsultaItemAcervo()
        {
            InitializeComponent();
        }
        public void AbrirSelecionarAutor()
        {
            FrmSelecionarAutor autor = new FrmSelecionarAutor();
            autor.ShowDialog();
            txtNomeAutor.Text = autor.NomeAutor;
        }

        public void AbrirSelecionarLocal()
        {
            FrmSelecionarLocal local = new FrmSelecionarLocal();
            local.ShowDialog();
            txtLocal.Text = local.NomeLocal;
        }
        public void AbrirSelecionarSecao()
        {
            FrmSelecionarSecao secao = new FrmSelecionarSecao();
            secao.ShowDialog();
            txtSecao.Text = secao.DescricaoSecao;
        }

        private void btnSelecionarAutor_Click(object sender, EventArgs e)
        {
            AbrirSelecionarAutor();
        }
        private void btnSelecionarLocal_Click(object sender, EventArgs e)
        {
            AbrirSelecionarLocal();
        }
        private void btnSelecionarSecao_Click(object sender, EventArgs e)
        {
            AbrirSelecionarSecao();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

          
             
        }
          
       

        private void txtNomeItem_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeItem.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string filtro1 = row.Cells[colNomeItem.Index].Value.ToString().Trim();
                bool exibir = filtro1.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {

        }

      
    }
}
