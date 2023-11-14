﻿using Padoca.Classes;
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
    public partial class GerenciamentoUsuarios : Form
    {
        // Atributos globais:
        int IdSelecionado = 0;
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();

            // Atribuir a tabela (resultado do SELECT) no DGV:
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void btnCadastarCad_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();

            // Obter os valores dos campos:
            usuario.NomeCompleto = txbNomeCad.Text;
            usuario.Email = txbEmailCad.Text;
            usuario.Senha = txbSenhaCad.Text;

            if(usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbEmailCad.Clear();
                txbSenhaCad.Clear();
                // Atualizar o dgv:
                dgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário!");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ativar os grbs:
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            // Obter a linha clicada:
            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            // Armazenar os dados da linha selecionada em "linha" (tipo um vetor):
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            // Preencher os campos:
            txbNomeEdit.Text = linha.Cells[1].Value.ToString();
            txbEmailEdit.Text = linha.Cells[2].Value.ToString();

            // Juntar o ID e o nome para exibir no apagar:
            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            // Salvar o id do selecionado na variavel global:
            IdSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = IdSelecionado;
            // Apagar:
            
        }
    }
}
