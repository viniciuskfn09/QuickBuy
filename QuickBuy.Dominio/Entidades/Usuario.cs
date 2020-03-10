using System.Collections;

namespace QuickBuy.Dominio.Entidades
{
   public class Usuario: Entidade
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string SobreNome { get; set; }

        //um usuario pode ter um ou muitos pedidos

            //Virtual - Permitir que o EF faça a sobreposição da collection para alimenta-la em tempo de execução 
            //para um PEDIDO que possa existir em um determinado USUARIO na base.
        public virtual System.Collections.Generic.ICollection<Pedidos> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(email))
                AdicionarCritica("Senha nao foi informado");
            if (string.IsNullOrEmpty(senha))
                AdicionarCritica("Senha nao foi informado");
        }
    }
}
