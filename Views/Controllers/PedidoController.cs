using Controllers.Base;
using Controllers.DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class PedidoController : IBaseController<Pedido>
    {

        Contexto cont = new Contexto();


        public void Adicionar(Pedido P)
        {
            cont.Pedidoset.Add(P);
            cont.SaveChanges();
        }

        public IList<Pedido> ListarPorPedido(string ped)
        {
            return cont.Pedidoset.Where(pedidos => pedidos.NomePedido == ped).ToList();
        }

        public IList<Pedido> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }

}