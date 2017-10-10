using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CORE
{
    public static class MetodosDeExtensao
    {
        public static List<ItemDePedido> ObtenhaTodos(this BindingSource bs) => bs.List.Cast<object>().Cast<ItemDePedido>().ToList();
    }
}
