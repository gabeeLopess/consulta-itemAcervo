namespace FrmConsultaItemAcervo
{
    partial class FrmSelecionarSecao
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
            this.txtSecao = new System.Windows.Forms.TextBox();
            this.txtCodigoSecao = new System.Windows.Forms.TextBox();
            this.lblSecao = new System.Windows.Forms.Label();
            this.lblCodigoSecao = new System.Windows.Forms.Label();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSecao
            // 
            this.txtSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSecao.Location = new System.Drawing.Point(93, 34);
            this.txtSecao.Name = "txtSecao";
            this.txtSecao.ReadOnly = true;
            this.txtSecao.Size = new System.Drawing.Size(315, 20);
            this.txtSecao.TabIndex = 11;
            this.txtSecao.TextChanged += new System.EventHandler(this.txtSecao_TextChanged);
            // 
            // txtCodigoSecao
            // 
            this.txtCodigoSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigoSecao.Location = new System.Drawing.Point(93, 6);
            this.txtCodigoSecao.Name = "txtCodigoSecao";
            this.txtCodigoSecao.ReadOnly = true;
            this.txtCodigoSecao.Size = new System.Drawing.Size(212, 20);
            this.txtCodigoSecao.TabIndex = 10;
            this.txtCodigoSecao.TextChanged += new System.EventHandler(this.txtCodigoSecao_TextChanged);
            // 
            // lblSecao
            // 
            this.lblSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecao.AutoSize = true;
            this.lblSecao.Location = new System.Drawing.Point(14, 41);
            this.lblSecao.Name = "lblSecao";
            this.lblSecao.Size = new System.Drawing.Size(38, 13);
            this.lblSecao.TabIndex = 9;
            this.lblSecao.Text = "Seção";
            // 
            // lblCodigoSecao
            // 
            this.lblCodigoSecao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigoSecao.AutoSize = true;
            this.lblCodigoSecao.Location = new System.Drawing.Point(11, 13);
            this.lblCodigoSecao.Name = "lblCodigoSecao";
            this.lblCodigoSecao.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoSecao.TabIndex = 8;
            this.lblCodigoSecao.Text = "Código";
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
            this.colCodSecao,
            this.colSecao});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(14, 78);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.Size = new System.Drawing.Size(394, 292);
            this.gridLayout.TabIndex = 7;
            this.gridLayout.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLayout_CellMouseDoubleClick);
            // 
            // colCodSecao
            // 
            this.colCodSecao.HeaderText = "Id";
            this.colCodSecao.Name = "colCodSecao";
            this.colCodSecao.ReadOnly = true;
            // 
            // colSecao
            // 
            this.colSecao.HeaderText = "Seção";
            this.colSecao.Name = "colSecao";
            this.colSecao.ReadOnly = true;
            // 
            // SelecionarSecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 376);
            this.Controls.Add(this.txtSecao);
            this.Controls.Add(this.txtCodigoSecao);
            this.Controls.Add(this.lblSecao);
            this.Controls.Add(this.lblCodigoSecao);
            this.Controls.Add(this.gridLayout);
            this.Name = "SelecionarSecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Seção";
            this.Load += new System.EventHandler(this.SelecionarSecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSecao;
        private System.Windows.Forms.TextBox txtCodigoSecao;
        private System.Windows.Forms.Label lblSecao;
        private System.Windows.Forms.Label lblCodigoSecao;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecao;
    }
}