using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa02.Entities
{
    public class Cliente
    {
        private Guid _id;
        private string _nome;
        private string _cpf;
        private string _email;
        private string _telefone;

        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public String Nome
        {
            set { _nome = value; }
            get { return _nome; }
        }
        public string Cpf
        {
            set { _cpf = value; }
            get { return _cpf; }
        }
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
          public string Telefone
        {
            set { _telefone = value; }
            get { return _telefone; }
        }

    }
}
