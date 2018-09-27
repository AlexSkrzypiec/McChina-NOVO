using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
