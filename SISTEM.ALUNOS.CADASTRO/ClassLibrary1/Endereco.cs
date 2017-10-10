namespace CORE
{
    public class Endereco: IEndereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }

        public Endereco(string logradouro, int numero, string estado, string bairro, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Estado = estado;
            Bairro = bairro;
            Cep = cep;
        }

        public override string ToString() => $"Logradouro ={Logradouro} Numero ={Numero} Estado ={Estado} Bairro ={Bairro} Cep ={Cep};";
    }
}
