﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Secretaria : Usuario, IAdministrativel, IAutenticavel
    {
        public bool Autentica(string login, string senha)
        {
            throw new NotImplementedException();
        }

        public void criarUsuario(string login, string senha)
        {
            throw new NotImplementedException();
        }
    }
}