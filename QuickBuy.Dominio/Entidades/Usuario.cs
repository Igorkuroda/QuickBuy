using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario{
        public int Id { get; set; }
        public int Email { get; set; }
        public int Senha { get; set; }
        public int Nome { get; set; }
        public int SobreNome { get; set; }

         /// <summary>
        /// Um usuário pode ter um ou mais pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }
         
    }

    
}
