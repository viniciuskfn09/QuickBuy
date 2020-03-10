using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedidos : Entidade
    {
        public int id { get; set; }
        public DateTime DataPedido { get; set; }
        //UsuarioID- configurar o retorno da instancia do pedido para o usuario.
        public int UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }

        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoID { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }






        




        //Pedidos pode ter pelo menos um ou muitos pedidos.

        public ICollection<itemPedido>ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (!ItensPedido.Any())
                AdicionarCritica("Critica - Pedido nao pode ficar sem item de pedido");


            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar preenchido");
                   
        }
    }

    public class FormaPagamento
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
    }
}
