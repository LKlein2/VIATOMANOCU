﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private int id;
        private string login;
        private string senha;
        private string nome;
        private string documento;
        private int tipoAcesso;
        // 1 - Administrador.
        // 2 - Odontologista.
        // 3 - Secretaria.
        // 4 - Paciente.
        private DateTime dataCadastro;
        private IAdministrativel criador;
        private string endereco;
        private string contato;
        private DateTime dataNascimento;

        public Usuario() { }

        public Usuario(string login, string senha, string nome)
        {
            this.Login = login;
            this.Senha = senha;
            this.Nome = nome;
        }

        public Usuario(string login, string senha, string nome, string documento, int tipoAcesso)
        {
            this.Login = login;
            this.Senha = senha;
            this.Nome = nome;
            this.Documento = documento;
            this.TipoAcesso = tipoAcesso;
        }

        public Usuario(int id, string login, string senha, string nome, string documento, int tipoAcesso, 
                        DateTime dataCadastro, IAdministrativel criador, string endereco, string contato,
                        DateTime dataNascimento)
        {
            this.ID = id;
            this.Login = login;
            this.Senha = senha;
            this.Nome = nome;
            this.Documento = documento;
            this.TipoAcesso = tipoAcesso;
            this.DataCadastro = dataCadastro;
            this.Criador = criador;
            this.Endereco = endereco;
            this.Contato = contato;
            this.dataNascimento = dataNascimento;
        }

        public int ID { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Documento { get => documento; set => documento = value; }
        public int TipoAcesso { get => tipoAcesso; set => tipoAcesso = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public IAdministrativel Criador { get => criador; set => criador = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Contato { get => contato; set => contato = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    }
}
