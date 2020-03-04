using System.Collections;

namespace QuickBuy.Dominio.Entidades
{
   public class Usuario
    {
        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string SobreNome { get; set; }

        //um usuario pode ter um ou muitos pedidos


        public System.Collections.Generic.ICollection<Pedidos> Pedidos { get; set; }



    }
}
