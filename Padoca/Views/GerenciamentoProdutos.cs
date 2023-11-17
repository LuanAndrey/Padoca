using Padoca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padoca.Views
{
    public partial class GerenciamentoProdutos : Form
    {
        // Objetos globais:
        Classes.Usuario usuario = new Classes.Usuario();
        int IdSelecionado = 0;
        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();
            Classes.Produto produto = new Classes.Produto();

            // Atribuir o usuário local no global:
            this.usuario = usuario;

            // Mudar a label de apresentação:
            lblUsuarioLogado.Text = "Olá, " + usuario.NomeCompleto;

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvProdutos.DataSource = produto.ListarTudo();
        }

        private void btnCadastrarCad_Click(object sender, EventArgs e)
        {
            // Instanciar o produto:
            Classes.Produto produto = new Classes.Produto();

            produto.Nome = txbNomeCad.Text;
            produto.Preco = double.Parse(txbPrecoCad.Text);
            produto.IdCategoria = int.Parse(txbCategoriaCad.Text);
            produto.IdRespCadastro = usuario.Id;

            if (produto.Cadastrar() == true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbPrecoCad.Clear();
                txbCategoriaCad.Clear();
                // Atualizar o dgv:
                dgvProdutos.DataSource = produto.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar produto!");
            }
        }
        private void btnEditarEdit_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            // Obter os valores do txbs:
            produto.Nome = txbNomeEdit.Text;
            produto.Preco = double.Parse(txbPrecoEdit.Text);
            produto.IdCategoria = int.Parse(txbCategoriaEdit.Text);
            produto.IdRespCadastro = usuario.Id;
            produto.Id = IdSelecionado;
            //  Editar:
            if (produto.Modificar() == true)
            {
                MessageBox.Show("Produto modificado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Atualizar o dgv:
                dgvProdutos.DataSource = produto.ListarTudo();
                // Limpar os campos de edição:
                txbNomeEdit.Clear();
                txbPrecoEdit.Clear();
                txbCategoriaEdit.Clear();
                lblApagar.Text = "Selecione um produto para apagar.";
                // Desabilitar os grbs:
                grbApagar.Enabled = false;
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar produto!", "Falha!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            // Armazenar os dados da linha selecionada em "linha" (tipo um vetor):
            var linha = dgvProdutos.Rows[linhaSelecionada];

            // Preencher os campos:
            txbNomeEdit.Text = linha.Cells[1].Value.ToString();
            txbPrecoEdit.Text = linha.Cells[2].Value.ToString();
            txbCategoriaEdit.Text = linha.Cells[3].Value.ToString();
            MessageBox.Show(linha.Cells[3].Value.ToString());

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            IdSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produtos = new Classes.Produto();
            produtos.Id = IdSelecionado;
            // Confirmar a exclusão:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (produtos.Apagar() == true)
                {
                    MessageBox.Show("Produto removido!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    dgvProdutos.DataSource = produtos.ListarTudo();
                    // Limpar os campos de edição:
                    txbNomeEdit.Clear();
                    txbPrecoEdit.Clear();
                    txbCategoriaEdit.Clear();
                    lblApagar.Text = "Selecione um produto para apagar.";
                    // Desabilitar os grbs:
                    grbApagar.Enabled = false;
                    grbEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover produto!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
