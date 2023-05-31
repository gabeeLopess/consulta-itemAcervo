namespace FrmConsultaItemAcervo
{
    partial class FrmSelecionarAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeAutor.Location = new System.Drawing.Point(93, 34);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.ReadOnly = true;
            this.txtNomeAutor.Size = new System.Drawing.Size(315, 20);
            this.txtNomeAutor.TabIndex = 11;
            this.txtNomeAutor.TextChanged += new System.EventHandler(this.txtNomeAutor2_TextChanged);
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(14, 41);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "Autor";
            this.lblAutor.Click += new System.EventHandler(this.txtAutor_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Click += new System.EventHandler(this.txtCodigo_Click);
            // 
            // gridLayout
            // 
            this.gridLayout.AllowUserToAddRows = false;
            this.gridLayout.AllowUserToDeleteRows = false;
            this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodAutor,
            this.colNomeAutor});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(14, 78);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.Size = new System.Drawing.Size(394, 292);
            this.gridLayout.TabIndex = 7;
            this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentClick);
            this.gridLayout.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellDoubleClick);
            this.gridLayout.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLayout_CellMouseDoubleClick);
            // 
            // colCodAutor
            // 
            this.colCodAutor.HeaderText = "Id";
            this.colCodAutor.Name = "colCodAutor";
            this.colCodAutor.ReadOnly = true;
            // 
            // colNomeAutor
            // 
            this.colNomeAutor.HeaderText = "Nome Autor";
            this.colNomeAutor.Name = "colNomeAutor";
            this.colNomeAutor.ReadOnly = true;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigoAutor.Location = new System.Drawing.Point(93, 6);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.ReadOnly = true;
            this.txtCodigoAutor.Size = new System.Drawing.Size(212, 20);
            this.txtCodigoAutor.TabIndex = 10;
            this.txtCodigoAutor.TextChanged += new System.EventHandler(this.txtCodigoAutor_TextChanged);
            // 
            // FrmSelecionarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 376);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.gridLayout);
            this.Name = "FrmSelecionarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Autor";
            this.Load += new System.EventHandler(this.FrmSelecionarAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAutor;
        private System.Windows.Forms.TextBox txtCodigoAutor;
    }
}