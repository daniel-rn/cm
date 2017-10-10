namespace CORE
{
    public class Cliente: Usuario
    {
        public IEndereco Endereco { get; }

        public Cliente(IEndereco endereco, string nome, int id)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return $"{Nome} Endereco {Endereco}";
        }
    }
}
