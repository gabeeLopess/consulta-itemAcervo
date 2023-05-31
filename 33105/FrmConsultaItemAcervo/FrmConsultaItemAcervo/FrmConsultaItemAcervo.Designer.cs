namespace FrmConsultaItemAcervo
{
    partial class FrmConsultaItemAcervo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaItemAcervo));
            this.lblCodigoItem = new System.Windows.Forms.Label();
            this.lblNomeItem = new System.Windows.Forms.Label();
            this.txtCodigoItem = new System.Windows.Forms.TextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipoItem = new System.Windows.Forms.Label();
            this.cmbTipoItem = new System.Windows.Forms.ComboBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtColecao = new System.Windows.Forms.TextBox();
            this.lblColecao = new System.Windows.Forms.Label();
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.lblSecao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.btnSelecionarLocal = new System.Windows.Forms.Button();
            this.btnSelecionarAutor = new System.Windows.Forms.Button();
            this.btnSelecionarSecao = new System.Windows.Forms.Button();
            this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoItem
            // 
            this.lblCodigoItem.AutoSize = true;
            this.lblCodigoItem.Location = new System.Drawing.Point(-3, 12);
            this.lblCodigoItem.Name = "lblCodigoItem";
            this.lblCodigoItem.Size = new System.Drawing.Size(63, 13);
            this.lblCodigoItem.TabIndex = 0;
            this.lblCodigoItem.Text = "Código Item";
            // 
            // lblNomeItem
            // 
            this.lblNomeItem.AutoSize = true;
            this.lblNomeItem.Location = new System.Drawing.Point(-3, 40);
            this.lblNomeItem.Name = "lblNomeItem";
            this.lblNomeItem.Size = new System.Drawing.Size(58, 13);
            this.lblNomeItem.TabIndex = 1;
            this.lblNomeItem.Text = "Nome Item";
            // 
            // txtCodigoItem
            // 
            this.txtCodigoItem.Location = new System.Drawing.Point(66, 11);
            this.txtCodigoItem.Name = "txtCodigoItem";
            this.txtCodigoItem.ReadOnly = true;
            this.txtCodigoItem.Size = new System.Drawing.Size(288, 20);
            this.txtCodigoItem.TabIndex = 3;
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(66, 38);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(288, 20);
            this.txtNomeItem.TabIndex = 4;
            this.txtNomeItem.TextChanged += new System.EventHandler(this.txtNomeItem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovaConsulta);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.btnSelecionarSecao);
            this.groupBox1.Controls.Add(this.btnSelecionarAutor);
            this.groupBox1.Controls.Add(this.btnSelecionarLocal);
            this.groupBox1.Controls.Add(this.txtNomeAutor);
            this.groupBox1.Controls.Add(this.lblAutor);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.txtSecao);
            this.groupBox1.Controls.Add(this.lblSecao);
            this.groupBox1.Controls.Add(this.txtColecao);
            this.groupBox1.Controls.Add(this.lblColecao);
            this.groupBox1.Controls.Add(this.txtLocal);
            this.groupBox1.Controls.Add(this.lblLocal);
            this.groupBox1.Controls.Add(this.cmbTipoItem);
            this.groupBox1.Controls.Add(this.lblTipoItem);
            this.groupBox1.Controls.Add(this.lblCodigoItem);
            this.groupBox1.Controls.Add(this.txtNomeItem);
            this.groupBox1.Controls.Add(this.txtCodigoItem);
            this.groupBox1.Controls.Add(this.lblNomeItem);
            this.groupBox1.Location = new System.Drawing.Point(2, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTipoItem
            // 
            this.lblTipoItem.AutoSize = true;
            this.lblTipoItem.Location = new System.Drawing.Point(359, 40);
            this.lblTipoItem.Name = "lblTipoItem";
            this.lblTipoItem.Size = new System.Drawing.Size(51, 13);
            this.lblTipoItem.TabIndex = 5;
            this.lblTipoItem.Text = "Tipo Item";
            // 
            // cmbTipoItem
            // 
            this.cmbTipoItem.FormattingEnabled = true;
            this.cmbTipoItem.Items.AddRange(new object[] {
            "Livro",
            "Revista",
            "Jornal",
            "DVD/CD",
            "Folheto",
            "Artigo"});
            this.cmbTipoItem.Location = new System.Drawing.Point(421, 37);
            this.cmbTipoItem.Name = "cmbTipoItem";
            this.cmbTipoItem.Size = new System.Drawing.Size(268, 21);
            this.cmbTipoItem.TabIndex = 6;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(66, 64);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(268, 20);
            this.txtLocal.TabIndex = 8;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(-3, 67);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 7;
            this.lblLocal.Text = "Local";
            // 
            // txtColecao
            // 
            this.txtColecao.Location = new System.Drawing.Point(66, 90);
            this.txtColecao.Name = "txtColecao";
            this.txtColecao.Size = new System.Drawing.Size(288, 20);
            this.txtColecao.TabIndex = 10;
            // 
            // lblColecao
            // 
            this.lblColecao.AutoSize = true;
            this.lblColecao.Location = new System.Drawing.Point(-3, 93);
            this.lblColecao.Name = "lblColecao";
            this.lblColecao.Size = new System.Drawing.Size(46, 13);
            this.lblColecao.TabIndex = 9;
            this.lblColecao.Text = "Coleção";
            // 
            // txtSecao
            // 
            this.txtSecao.Location = new System.Drawing.Point(421, 90);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.ReadOnly = true;
            this.txtSecao.Size = new System.Drawing.Size(268, 20);
            this.txtSecao.TabIndex = 12;
            // 
            // lblSecao
            // 
            this.lblSecao.AutoSize = true;
            this.lblSecao.Location = new System.Drawing.Point(358, 93);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(38, 13);
            this.lblSecao.TabIndex = 11;
            this.lblSecao.Text = "Seção";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(359, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // gridLayout
            // 
            this.gridLayout.AllowUserToAddRows = false;
            this.gridLayout.AllowUserToDeleteRows = false;
            this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItem,
            this.colLocal,
            this.colAutor,
            this.colColecao,
            this.colSecao,
            this.colStatus,
            this.colNomeItem,
            this.colTipoItem});
            this.gridLayout.Location = new System.Drawing.Point(2, 147);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.Size = new System.Drawing.Size(712, 275);
            this.gridLayout.TabIndex = 6;
            this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado",
            "Reservado"});
            this.cmbStatus.Location = new System.Drawing.Point(421, 10);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(268, 21);
            this.cmbStatus.TabIndex = 14;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(359, 67);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 19;
            this.lblAutor.Text = "Autor";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(421, 64);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.ReadOnly = true;
            this.txtNomeAutor.Size = new System.Drawing.Size(270, 20);
            this.txtNomeAutor.TabIndex = 20;
            // 
            // btnSelecionarLocal
            // 
            this.btnSelecionarLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarLocal.Image")));
            this.btnSelecionarLocal.Location = new System.Drawing.Point(329, 63);
            this.btnSelecionarLocal.Name = "btnSelecionarLocal";
            this.btnSelecionarLocal.Size = new System.Drawing.Size(25, 21);
            this.btnSelecionarLocal.TabIndex = 22;
            this.btnSelecionarLocal.UseVisualStyleBackColor = true;
            this.btnSelecionarLocal.Click += new System.EventHandler(this.btnSelecionarLocal_Click);
            // 
            // btnSelecionarAutor
            // 
            this.btnSelecionarAutor.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarAutor.Image")));
            this.btnSelecionarAutor.Location = new System.Drawing.Point(687, 63);
            this.btnSelecionarAutor.Name = "btnSelecionarAutor";
            this.btnSelecionarAutor.Size = new System.Drawing.Size(25, 21);
            this.btnSelecionarAutor.TabIndex = 23;
            this.btnSelecionarAutor.UseVisualStyleBackColor = true;
            this.btnSelecionarAutor.Click += new System.EventHandler(this.btnSelecionarAutor_Click);
            // 
            // btnSelecionarSecao
            // 
            this.btnSelecionarSecao.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarSecao.Image")));
            this.btnSelecionarSecao.Location = new System.Drawing.Point(687, 89);
            this.btnSelecionarSecao.Name = "btnSelecionarSecao";
            this.btnSelecionarSecao.Size = new System.Drawing.Size(25, 21);
            this.btnSelecionarSecao.TabIndex = 24;
            this.btnSelecionarSecao.UseVisualStyleBackColor = true;
            this.btnSelecionarSecao.Click += new System.EventHandler(this.btnSelecionarSecao_Click);
            // 
            // colCodItem
            // 
            this.colCodItem.HeaderText = "Id";
            this.colCodItem.Name = "colCodItem";
            this.colCodItem.ReadOnly = true;
            // 
            // colLocal
            // 
            this.colLocal.HeaderText = "Local";
            this.colLocal.Name = "colLocal";
            this.colLocal.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colColecao
            // 
            this.colColecao.HeaderText = "Coleção";
            this.colColecao.Name = "colColecao";
            this.colColecao.ReadOnly = true;
            // 
            // colSecao
            // 
            this.colSecao.HeaderText = "Seção";
            this.colSecao.Name = "colSecao";
            this.colSecao.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colNomeItem
            // 
            this.colNomeItem.HeaderText = "Nome Item";
            this.colNomeItem.Name = "colNomeItem";
            this.colNomeItem.ReadOnly = true;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo Item";
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(300, 124);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.Location = new System.Drawing.Point(381, 124);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(89, 23);
            this.btnNovaConsulta.TabIndex = 26;
            this.btnNovaConsulta.Text = "Nova Consulta";
            this.btnNovaConsulta.UseVisualStyleBackColor = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // FrmConsultaItemAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 423);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaItemAcervo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Item Acervo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoItem;
        private System.Windows.Forms.Label lblNomeItem;
        private System.Windows.Forms.TextBox txtCodigoItem;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.TextBox txtColecao;
        private System.Windows.Forms.Label lblColecao;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ComboBox cmbTipoItem;
        private System.Windows.Forms.Label lblTipoItem;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.Button btnSelecionarSecao;
        private System.Windows.Forms.Button btnSelecionarAutor;
        private System.Windows.Forms.Button btnSelecionarLocal;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.Button btnConsultar;
    }
}

