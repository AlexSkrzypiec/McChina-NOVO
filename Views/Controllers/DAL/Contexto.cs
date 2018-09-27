using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("McChinaDBNovo3")

        {
        }
        public virtual DbSet<Pedido> Pedidoset { get; set; }
        public virtual DbSet<Produtos> Produtosset { get; set; }
        public virtual DbSet<Usuario> Usuarioset { get; set; }

    }
}
