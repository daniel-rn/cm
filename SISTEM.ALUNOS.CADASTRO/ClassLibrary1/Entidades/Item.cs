using CORE.Interfaces;

namespace CORE.Entidades
{
    public class Item:IItem
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeMinimaEmEstoque { get; set; }
    }
}
