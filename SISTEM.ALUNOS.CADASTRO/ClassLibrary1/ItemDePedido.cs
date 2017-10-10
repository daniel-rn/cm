namespace CORE
{
    public class ItemDePedido : IItemDePedido
    {
        public ItemDePedido(string descricao, double preco)
        {
            Descricao = descricao;
            Preco = preco;
        }

        public string Descricao { get; set; }
        public double Preco { get; set; }
    }
}
