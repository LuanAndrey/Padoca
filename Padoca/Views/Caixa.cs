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
    public partial class Caixa : Form
    {
        Classes.Usuario usuario;
        public Caixa(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Verificar se o txb está vazio:
            if (txbNumeroComanda.Text != "")
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbNumeroComanda.Text);
                var r = ordem.BuscarFicha();
                dgvFicha.DataSource = r;
                // Atualizar o valor total:
                lblTotal.Text = "R$ " + r.Compute("SUM(Total_item)", "True").ToString();
            }
            else
            {
                MessageBox.Show("Digite o número da ficha!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbConfirmar.Checked;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbNumeroComanda.Text);
                if(ordem.EncerrarFicha() == true)
                {
                    MessageBox.Show("Ficha encarreda!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar:
                    txbNumeroComanda.Clear();
                    dgvFicha.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
