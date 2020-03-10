namespace QuickBuy.Dominio.Entidades
{
    public class itemPedido : Entidade
    {
        public static bool Any { get; internal set; }
        public int ID { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoID == 0)
                AdicionarCritica("Nao foi identificado qual a referencia do produto");
            if (Quantidade = 0)
                AdicionarCritica("Quantidade nao foiinformada");
        }
    }
}
