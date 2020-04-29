using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido:Entidade {
        public int Id { get; set; }
        public int Produtoid { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (Produtoid == 0)
                AdicionarCritica("Não foi possível identificar qual a referência do produto");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não informada");
        }
    }
}
