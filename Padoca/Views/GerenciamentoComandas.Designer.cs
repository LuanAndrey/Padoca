namespace Padoca.Views
{
    partial class GerenciamentoComandas
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidadeLanca = new System.Windows.Forms.TextBox();
            this.lblQuantidadeLanca = new System.Windows.Forms.Label();
            this.txbProdutoLanca = new System.Windows.Forms.TextBox();
            this.lblProdutoLanca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(231, 48);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(330, 378);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnInformacoes);
            this.grbInformacoes.Controls.Add(this.txbCodProduto);
            this.grbInformacoes.Controls.Add(this.lblProduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacoes.Location = new System.Drawing.Point(12, 48);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(166, 169);
            this.grbInformacoes.TabIndex = 1;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacoes.Location = new System.Drawing.Point(38, 128);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(84, 33);
            this.btnInformacoes.TabIndex = 4;
            this.btnInformacoes.Text = "Continuar";
            this.btnInformacoes.UseVisualStyleBackColor = true;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(77, 92);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(83, 26);
            this.txbCodProduto.TabIndex = 3;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(9, 96);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(59, 18);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(77, 37);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(83, 26);
            this.txbComanda.TabIndex = 1;
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(6, 41);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(65, 18);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txbQuantidadeLanca);
            this.grbLancamento.Controls.Add(this.lblQuantidadeLanca);
            this.grbLancamento.Controls.Add(this.txbProdutoLanca);
            this.grbLancamento.Controls.Add(this.lblProdutoLanca);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLancamento.Location = new System.Drawing.Point(12, 257);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(166, 169);
            this.grbLancamento.TabIndex = 5;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // btnLancar
            // 
            this.btnLancar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.Location = new System.Drawing.Point(38, 128);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(84, 33);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidadeLanca
            // 
            this.txbQuantidadeLanca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidadeLanca.Location = new System.Drawing.Point(98, 92);
            this.txbQuantidadeLanca.Name = "txbQuantidadeLanca";
            this.txbQuantidadeLanca.Size = new System.Drawing.Size(62, 26);
            this.txbQuantidadeLanca.TabIndex = 3;
            // 
            // lblQuantidadeLanca
            // 
            this.lblQuantidadeLanca.AutoSize = true;
            this.lblQuantidadeLanca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLanca.Location = new System.Drawing.Point(9, 96);
            this.lblQuantidadeLanca.Name = "lblQuantidadeLanca";
            this.lblQuantidadeLanca.Size = new System.Drawing.Size(83, 18);
            this.lblQuantidadeLanca.TabIndex = 2;
            this.lblQuantidadeLanca.Text = "Quantidade:";
            // 
            // txbProdutoLanca
            // 
            this.txbProdutoLanca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutoLanca.Location = new System.Drawing.Point(71, 37);
            this.txbProdutoLanca.Name = "txbProdutoLanca";
            this.txbProdutoLanca.Size = new System.Drawing.Size(89, 26);
            this.txbProdutoLanca.TabIndex = 1;
            // 
            // lblProdutoLanca
            // 
            this.lblProdutoLanca.AutoSize = true;
            this.lblProdutoLanca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLanca.Location = new System.Drawing.Point(6, 41);
            this.lblProdutoLanca.Name = "lblProdutoLanca";
            this.lblProdutoLanca.Size = new System.Drawing.Size(59, 18);
            this.lblProdutoLanca.TabIndex = 0;
            this.lblProdutoLanca.Text = "Produto:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(176, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 19);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Gerenciamento de Comandas";
            // 
            // GerenciamentoComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 438);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "GerenciamentoComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoComandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidadeLanca;
        private System.Windows.Forms.Label lblQuantidadeLanca;
        private System.Windows.Forms.TextBox txbProdutoLanca;
        private System.Windows.Forms.Label lblProdutoLanca;
        private System.Windows.Forms.Label lblTitulo;
    }
}