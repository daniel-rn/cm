using CORE.Entidades;

namespace CORUJA
{
    public partial class frmEstoqueAterrissagem : FormBase
    {
        public static int IdItem = 1;
        public frmEstoqueAterrissagem():base("Controle de Estoque")
        {
            InitializeComponent();
            controleGrid.InicializaGrid();
            controleGrid.AddColumn("Id", nameof(Item.Id), 160);
            controleGrid.AddColumn("Descricão", nameof(Item.Descricao), 160);
            controleGrid.AddColumn("Quantidade", nameof(Item.Quantidade), 136);
            controleGrid.AddColumn("Quantidade Minima", nameof(Item.QuantidadeMinimaEmEstoque), 136);

            controleGrid.AdicionaItemNaGridDelegate = AdicionaItemNaGrid;
        }

        public dynamic AdicionaItemNaGrid()
        {
            return new Item
            {
                Id = IdItem += 1,
                Descricao = "Peixe",
                Quantidade = 3,
                QuantidadeMinimaEmEstoque = 8
            };
        }
    }
}
