using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa02.Entities
{
    public class Pedido
    {
        private Guid _id;
        private DateTime _datadopedido;
        private decimal _valor;
        private Cliente _cliente;
        private Endereco _endereco;

        public Guid Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public DateTime Datadopedido
        {
            set { _datadopedido = value; }
            get { return _datadopedido; }
        }
        public decimal Valor
        {
            set { _valor = value; }
            get { return _valor; }
        }
        public Cliente Cliente
        {
            set { _cliente = value; }
            get { return _cliente; }
        }


        public Endereco Endereco
        {
            set { _endereco = value; }
            get { return _endereco; }
        }

    }  
}
