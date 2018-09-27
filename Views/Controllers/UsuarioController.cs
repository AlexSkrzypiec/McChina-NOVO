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
    public class UsuarioController : IBaseController<Usuario>
    {

        Contexto cont = new Contexto();

        public void Adicionar(Usuario P)
        {
            cont.Usuarioset.Add(P);
            cont.SaveChanges();

        }

        public IList<Usuario> ListarPorPedido(string ped)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}