﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public class Produto
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal preco { get; set; }

    }
}
