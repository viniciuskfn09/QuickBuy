using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return ID == (int)TipoFormaDePagamento.Boleto; }
        }
        public bool EhDeposito
        {
            get { return ID == (int)TipoFormaDePagamento.Deposito; }
        }

        public bool EhCartaoCredito
        {
            get { return ID == (int)TipoFormaDePagamento.CartaoCredito; }
        }
        public bool NaoDefinido
        {
            get { return ID == (int)TipoFormaDePagamento.NaoDefinido; }
        }

    }
}




