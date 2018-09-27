using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Base
{
    public interface IBaseController<T> where T : class
    {

        void Adicionar(T P);
        IList<T> ListarTodos();
        IList<T> ListarPorPedido(string Ped);
    }
}
