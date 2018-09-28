using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{

    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        public string NomePedido { get; set; }
        public string DataPedido { get; set; }
        public string TipoPedido { get; set; }
        public int UsuarioIdUsuario { get; set; }

        public virtual ICollection<Usuario> IdUsuario { get; set; }

    }
}