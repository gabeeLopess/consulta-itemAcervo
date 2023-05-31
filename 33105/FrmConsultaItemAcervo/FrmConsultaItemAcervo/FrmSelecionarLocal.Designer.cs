namespace FrmConsultaItemAcervo
{
    partial class FrmSelecionarLocal
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
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodigoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricaoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricaoLocal = new System.Windows.Forms.TextBox();
            this.txtCodigoLocal = new System.Windows.Forms.TextBox();
            this.lblDescricaoLocal = new System.Windows.Forms.Label();
            this.lblCodigoLocal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
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
            this.colCodigoLocal,
            this.colDescricaoLocal});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(14, 76);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLayout.Size = new System.Drawing.Size(394, 293);
            this.gridLayout.TabIndex = 27;
            this.gridLayout.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLayout_CellMouseDoubleClick);
            // 
            // colCodigoLocal
            // 
            this.colCodigoLocal.HeaderText = "Id";
            this.colCodigoLocal.Name = "colCodigoLocal";
            this.colCodigoLocal.ReadOnly = true;
            // 
            // colDescricaoLocal
            // 
            this.colDescricaoLocal.HeaderText = "Descrição";
            this.colDescricaoLocal.Name = "colDescricaoLocal";
            this.colDescricaoLocal.ReadOnly = true;
            // 
            // txtDescricaoLocal
            // 
            this.txtDescricaoLocal.Location = new System.Drawing.Point(88, 36);
            this.txtDescricaoLocal.Name = "txtDescricaoLocal";
            this.txtDescricaoLocal.ReadOnly = true;
            this.txtDescricaoLocal.Size = new System.Drawing.Size(320, 20);
            this.txtDescricaoLocal.TabIndex = 26;
            this.txtDescricaoLocal.TextChanged += new System.EventHandler(this.txtDescricaoLocal_TextChanged);
            // 
            // txtCodigoLocal
            // 
            this.txtCodigoLocal.Location = new System.Drawing.Point(88, 7);
            this.txtCodigoLocal.Name = "txtCodigoLocal";
            this.txtCodigoLocal.Size = new System.Drawing.Size(215, 20);
            this.txtCodigoLocal.TabIndex = 25;
            this.txtCodigoLocal.TextChanged += new System.EventHandler(this.txtCodigoLocal_TextChanged);
            // 
            // lblDescricaoLocal
            // 
            this.lblDescricaoLocal.AutoSize = true;
            this.lblDescricaoLocal.Location = new System.Drawing.Point(11, 43);
            this.lblDescricaoLocal.Name = "lblDescricaoLocal";
            this.lblDescricaoLocal.Size = new System.Drawing.Size(67, 13);
            this.lblDescricaoLocal.TabIndex = 24;
            this.lblDescricaoLocal.Text = "Descricação";
            // 
            // lblCodigoLocal
            // 
            this.lblCodigoLocal.AutoSize = true;
            this.lblCodigoLocal.Location = new System.Drawing.Point(11, 14);
            this.lblCodigoLocal.Name = "lblCodigoLocal";
            this.lblCodigoLocal.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoLocal.TabIndex = 23;
            this.lblCodigoLocal.Text = "Código";
            // 
            // FrmSelecionarLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 376);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.txtDescricaoLocal);
            this.Controls.Add(this.txtCodigoLocal);
            this.Controls.Add(this.lblDescricaoLocal);
            this.Controls.Add(this.lblCodigoLocal);
            this.Name = "FrmSelecionarLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Local";
            this.Load += new System.EventHandler(this.FrmSelecionarLocal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricaoLocal;
        private System.Windows.Forms.TextBox txtDescricaoLocal;
        private System.Windows.Forms.TextBox txtCodigoLocal;
        private System.Windows.Forms.Label lblDescricaoLocal;
        private System.Windows.Forms.Label lblCodigoLocal;
    }
}