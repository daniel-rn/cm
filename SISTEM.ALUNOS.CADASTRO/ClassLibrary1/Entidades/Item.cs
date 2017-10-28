namespace CORE.Entidades
{
    public class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeMinimaEmEstoque { get; set; }
    }
}
