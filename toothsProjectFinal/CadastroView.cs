﻿using DAO;
using DAO.Classes;
using DAO.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toothsProjectFinal
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            IConnection conexao = new Connection();
            conexao.Abrir();

            UsuarioDao usuarioDao = new UsuarioDao(conexao);

            int rbc = 0;
            if (radioButtonOdontologista.Checked)
            { 
                rbc = 2;
            }
            else if (radioButtonSecretaria.Checked)
            { 
                rbc = 3;
            }
            else if (radioButtonPaciente.Checked)
            { 
                rbc = 4;
            }
            else
            { 
                labelMensagem.Text = "Selecione modo de acesso";
                labelMensagem.ForeColor = Color.Red;
                return;
            }

            Usuario newUser = new Usuario(Convert.ToInt32(textBoxCodigo.Text = "1"),textBoxLogin.Text, textBoxSenha.Text, textBoxNome.Text, textBoxDocumento.Text, rbc,
                                            DateTime.Now, Acesso.Administrativel(), textBoxEndereco.Text, textBoxTelefone.Text,
                                            dateTimePickerNascimento.Value);
            if (newUser != null)
            {
                usuarioDao.Inserir(newUser);
                labelMensagem.Text = "Inserido com Sucesso !";
                labelMensagem.ForeColor = Color.Green;
            }
            else
            {
                labelMensagem.Text = "Não foi possível inserir!";
                labelMensagem.ForeColor = Color.Red;
            }

            conexao.Fechar();
        }

    }
}
