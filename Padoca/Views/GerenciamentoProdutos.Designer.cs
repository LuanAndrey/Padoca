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
            this.btnCadastrarCad = new System.Windows.Forms.Button();
            this.txbCategoriaCad = new System.Windows.Forms.TextBox();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblCategoriaCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditarEdit = new System.Windows.Forms.Button();
            this.txbCategoriaEdit = new System.Windows.Forms.TextBox();
            this.txbPrecoEdit = new System.Windows.Forms.TextBox();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.lblCategoriaEdit = new System.Windows.Forms.Label();
            this.lblPrecoEdit = new System.Windows.Forms.Label();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbApagar.SuspendLayout();
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
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(564, 232);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
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
            this.grbCadastro.Controls.Add(this.btnCadastrarCad);
            this.grbCadastro.Controls.Add(this.txbCategoriaCad);
            this.grbCadastro.Controls.Add(this.txbPrecoCad);
            this.grbCadastro.Controls.Add(this.txbNomeCad);
            this.grbCadastro.Controls.Add(this.lblCategoriaCad);
            this.grbCadastro.Controls.Add(this.lblPrecoCad);
            this.grbCadastro.Controls.Add(this.lblNomeCad);
            this.grbCadastro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastro.Location = new System.Drawing.Point(12, 296);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(243, 148);
            this.grbCadastro.TabIndex = 2;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastrar";
            // 
            // btnCadastrarCad
            // 
            this.btnCadastrarCad.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCadastrarCad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCad.Location = new System.Drawing.Point(9, 119);
            this.btnCadastrarCad.Name = "btnCadastrarCad";
            this.btnCadastrarCad.Size = new System.Drawing.Size(228, 23);
            this.btnCadastrarCad.TabIndex = 6;
            this.btnCadastrarCad.Text = "Cadastrar";
            this.btnCadastrarCad.UseVisualStyleBackColor = false;
            this.btnCadastrarCad.Click += new System.EventHandler(this.btnCadastrarCad_Click);
            // 
            // txbCategoriaCad
            // 
            this.txbCategoriaCad.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoriaCad.Location = new System.Drawing.Point(72, 90);
            this.txbCategoriaCad.Name = "txbCategoriaCad";
            this.txbCategoriaCad.Size = new System.Drawing.Size(165, 20);
            this.txbCategoriaCad.TabIndex = 5;
            // 
            // txbPrecoCad
            // 
            this.txbPrecoCad.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoCad.Location = new System.Drawing.Point(72, 60);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(165, 20);
            this.txbPrecoCad.TabIndex = 4;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCad.Location = new System.Drawing.Point(72, 30);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(165, 20);
            this.txbNomeCad.TabIndex = 3;
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
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(12, 463);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(564, 65);
            this.grbApagar.TabIndex = 4;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.LightCoral;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(470, 26);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(6, 30);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(181, 15);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione um produto para apagar";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditarEdit);
            this.grbEditar.Controls.Add(this.txbCategoriaEdit);
            this.grbEditar.Controls.Add(this.txbPrecoEdit);
            this.grbEditar.Controls.Add(this.txbNomeEdit);
            this.grbEditar.Controls.Add(this.lblCategoriaEdit);
            this.grbEditar.Controls.Add(this.lblPrecoEdit);
            this.grbEditar.Controls.Add(this.lblNomeEdit);
            this.grbEditar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(333, 296);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(243, 148);
            this.grbEditar.TabIndex = 3;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // btnEditarEdit
            // 
            this.btnEditarEdit.BackColor = System.Drawing.Color.Wheat;
            this.btnEditarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarEdit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEdit.Location = new System.Drawing.Point(9, 119);
            this.btnEditarEdit.Name = "btnEditarEdit";
            this.btnEditarEdit.Size = new System.Drawing.Size(228, 23);
            this.btnEditarEdit.TabIndex = 7;
            this.btnEditarEdit.Text = "Editar";
            this.btnEditarEdit.UseVisualStyleBackColor = false;
            this.btnEditarEdit.Click += new System.EventHandler(this.btnEditarEdit_Click);
            // 
            // txbCategoriaEdit
            // 
            this.txbCategoriaEdit.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoriaEdit.Location = new System.Drawing.Point(72, 90);
            this.txbCategoriaEdit.Name = "txbCategoriaEdit";
            this.txbCategoriaEdit.Size = new System.Drawing.Size(165, 20);
            this.txbCategoriaEdit.TabIndex = 8;
            // 
            // txbPrecoEdit
            // 
            this.txbPrecoEdit.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoEdit.Location = new System.Drawing.Point(72, 59);
            this.txbPrecoEdit.Name = "txbPrecoEdit";
            this.txbPrecoEdit.Size = new System.Drawing.Size(165, 20);
            this.txbPrecoEdit.TabIndex = 7;
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEdit.Location = new System.Drawing.Point(72, 30);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(165, 20);
            this.txbNomeEdit.TabIndex = 6;
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
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(12, 15);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioLogado.TabIndex = 5;
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 540);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "GerenciamentoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
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
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCadastrarCad;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.Button btnEditarEdit;
    }
}