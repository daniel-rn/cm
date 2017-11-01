using System;
using CORE.Entidades;

namespace CORUJA
{
    public partial class frmEstoqueAterrissagem : FormBase
    {
        public static int IdItem = 1;
        public frmEstoqueAterrissagem():base("Controle de Estoque")
        {
            InitializeComponent();
            controleGrid.AdicionaItemNaGridDelegate = AdicionaItemNaGrid;
            controleDeBotoesPadroes1.AoClicarNoBotaoEmitir = AoClicarNoBotaoEmitir;
            controleDeBotoesPadroes1.AoClicarNoBotaoSalvar = AoClicarNoBotaoSalvar;
            controleDeBotoesPadroes1.AoClicarNoBotaoFechar = AoClicarNoBotaoFechar;
        }

        private dynamic AoClicarNoBotaoFechar()
        {
            return this;
        }

        private dynamic AoClicarNoBotaoSalvar()
        {
            return "Clicou no Botao Salvar";
        }

        public object AoClicarNoBotaoEmitir()
        {
            return "Clicou no Botao Emitir";
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
