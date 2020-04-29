using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario:Entidade{
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

         /// <summary>
        /// Um usuário pode ter um ou mais pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("[ERRO]: O Valor do CEP deve ser preenchido");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("[ERRO]: O Valor do CEP deve ser preenchido");
        }
    }

    
}
