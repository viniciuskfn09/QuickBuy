using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedidos
    {
        public int id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioID { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }

        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoID { get; set; }
        public FormaPagamento FormaPagamento { get; set; }






        




        //Pedidos pode ter pelo menos um ou muitos pedidos.

        public ICollection<itemPedido>ItensPedido { get; set; }

    }

    public class FormaPagamento
    {
    }
}
