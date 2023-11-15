namespace Padoca.Views
{
    partial class GerenciamentoProdutos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.lblCategoriaEdit = new System.Windows.Forms.Label();
            this.lblPrecoEdit = new System.Windows.Forms.Label();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.txbCategoriaCad = new System.Windows.Forms.TextBox();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.txbPrecoEdit = new System.Windows.Forms.TextBox();
            this.txbCategoriaEdit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 39);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(564, 232);
            this.dgvProdutos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(207, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 18);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txbCategoriaCad);
            this.grbCadastro.Controls.Add(this.txbPrecoCad);
            this.grbCadastro.Controls.Add(this.txbNomeCad);
            this.grbCadastro.Controls.Add(this.lblCategoriaCad);
            this.grbCadastro.Controls.Add(this.lblPrecoCad);
            this.grbCadastro.Controls.Add(this.lblNomeCad);
            this.grbCadastro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(12, 296);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(243, 130);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastrar";
            // 
            // grbApagar
            // 
            this.grbApagar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(12, 458);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(564, 51);
            this.grbApagar.TabIndex = 4;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCad.Location = new System.Drawing.Point(27, 31);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(39, 15);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome:";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCad.Location = new System.Drawing.Point(27, 61);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(39, 15);
            this.lblPrecoCad.TabIndex = 1;
            this.lblPrecoCad.Text = "Preço:";
            // 
            // lblCategoriaCad
            // 
            this.lblCategoriaCad.AutoSize = true;
            this.lblCategoriaCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCad.Location = new System.Drawing.Point(6, 91);
            this.lblCategoriaCad.Name = "lblCategoriaCad";
            this.lblCategoriaCad.Size = new System.Drawing.Size(60, 15);
            this.lblCategoriaCad.TabIndex = 2;
            this.lblCategoriaCad.Text = "Categoria:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txbCategoriaEdit);
            this.grbEditar.Controls.Add(this.txbPrecoEdit);
            this.grbEditar.Controls.Add(this.txbNomeEdit);
            this.grbEditar.Controls.Add(this.lblCategoriaEdit);
            this.grbEditar.Controls.Add(this.lblPrecoEdit);
            this.grbEditar.Controls.Add(this.lblNomeEdit);
            this.grbEditar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(333, 296);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(243, 130);
            this.grbEditar.TabIndex = 3;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // lblCategoriaEdit
            // 
            this.lblCategoriaEdit.AutoSize = true;
            this.lblCategoriaEdit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaEdit.Location = new System.Drawing.Point(6, 91);
            this.lblCategoriaEdit.Name = "lblCategoriaEdit";
            this.lblCategoriaEdit.Size = new System.Drawing.Size(60, 15);
            this.lblCategoriaEdit.TabIndex = 2;
            this.lblCategoriaEdit.Text = "Categoria:";
            // 
            // lblPrecoEdit
            // 
            this.lblPrecoEdit.AutoSize = true;
            this.lblPrecoEdit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoEdit.Location = new System.Drawing.Point(27, 60);
            this.lblPrecoEdit.Name = "lblPrecoEdit";
            this.lblPrecoEdit.Size = new System.Drawing.Size(39, 15);
            this.lblPrecoEdit.TabIndex = 1;
            this.lblPrecoEdit.Text = "Preço:";
            // 
            // lblNomeEdit
            // 
            this.lblNomeEdit.AutoSize = true;
            this.lblNomeEdit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEdit.Location = new System.Drawing.Point(27, 31);
            this.lblNomeEdit.Name = "lblNomeEdit";
            this.lblNomeEdit.Size = new System.Drawing.Size(39, 15);
            this.lblNomeEdit.TabIndex = 0;
            this.lblNomeEdit.Text = "Nome:";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCad.Location = new System.Drawing.Point(72, 30);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(165, 20);
            this.txbNomeCad.TabIndex = 3;
            // 
            // txbPrecoCad
            // 
            this.txbPrecoCad.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoCad.Location = new System.Drawing.Point(72, 60);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(165, 20);
            this.txbPrecoCad.TabIndex = 4;
            // 
            // txbCategoriaCad
            // 
            this.txbCategoriaCad.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoriaCad.Location = new System.Drawing.Point(72, 90);
            this.txbCategoriaCad.Name = "txbCategoriaCad";
            this.txbCategoriaCad.Size = new System.Drawing.Size(165, 20);
            this.txbCategoriaCad.TabIndex = 5;
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEdit.Location = new System.Drawing.Point(72, 30);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(165, 20);
            this.txbNomeEdit.TabIndex = 6;
            // 
            // txbPrecoEdit
            // 
            this.txbPrecoEdit.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoEdit.Location = new System.Drawing.Point(72, 59);
            this.txbPrecoEdit.Name = "txbPrecoEdit";
            this.txbPrecoEdit.Size = new System.Drawing.Size(165, 20);
            this.txbPrecoEdit.TabIndex = 7;
            // 
            // txbCategoriaEdit
            // 
            this.txbCategoriaEdit.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoriaEdit.Location = new System.Drawing.Point(72, 90);
            this.txbCategoriaEdit.Name = "txbCategoriaEdit";
            this.txbCategoriaEdit.Size = new System.Drawing.Size(165, 20);
            this.txbCategoriaEdit.TabIndex = 8;
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 521);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "GerenciamentoProdutos";
            this.Text = "GerenciamentoProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblCategoriaCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Label lblCategoriaEdit;
        private System.Windows.Forms.Label lblPrecoEdit;
        private System.Windows.Forms.Label lblNomeEdit;
        private System.Windows.Forms.TextBox txbCategoriaCad;
        private System.Windows.Forms.TextBox txbPrecoCad;
        private System.Windows.Forms.TextBox txbCategoriaEdit;
        private System.Windows.Forms.TextBox txbPrecoEdit;
        private System.Windows.Forms.TextBox txbNomeEdit;
    }
}