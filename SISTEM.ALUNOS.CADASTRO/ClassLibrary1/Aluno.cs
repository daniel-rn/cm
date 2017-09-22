using FirebirdSql.Data.FirebirdClient;

namespace Biblioteca
{
    public class Aluno 
    {
        #region "Atributos"
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }
        #endregion

        public FbDataReader Open(FbConnection _conn)
        {
            var cmd = new FbCommand
            {
                Connection = _conn,
                CommandText = "select * from aluno"
            };
            return cmd.ExecuteReader();
        }
    }
}
