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
    public partial class GerenciamentoComandas : Form
    {
        //Globais:
        Classes.Usuario usuario;
        public GerenciamentoComandas(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Mudar o título da janela:
            this.Text = "Gerenciamento Comandas - Logado como: " + 
                usuario.NomeCompleto.ToUpper();

            // Popular o DGV com os dados da tabela de produtos:
            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarTudo();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;
            var linha= dgvProdutos.Rows[linhaSelecionada];

            // Popular os txbs com os valores do dgv:
            txbCodProduto.Text = linha.Cells[0].Value.ToString();
            txbProdutoLanca.Text = linha.Cells[1].Value.ToString();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja lançar?", "Aviso!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComanda.Text);
                ordem.IdProduto = int.Parse(txbCodProduto.Text);
                ordem.Quantidade = int.Parse(txbQuantidadeLanca.Text);
                ordem.IdResponsavel = usuario.Id;
                // Efetuar o cadastro:
                if(ordem.NovoLancamento() == true)
                {
                    MessageBox.Show("Lançamento efetuado!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha no lançamento!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            grbLancamento.Enabled = true;
            grbInformacoes.Enabled = false;
        }
    }
}
