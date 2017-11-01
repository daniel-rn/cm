using CORE.Interfaces;

namespace CORE.Entidades
{
    public class Item : IItem
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeMinimaEmEstoque { get; set; }

        public override string ToString()
        {
            return Descricao;
        }

        public override bool Equals(object obj) => (obj as Item)?.Id == Id;

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

}
