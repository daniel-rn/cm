using System;
using FirebirdSql.Data.FirebirdClient;

namespace CORE
{
    public class AlunoDAL
    {
        public object InsereAluno(Aluno aluno)
        {
            try
            {
                Connection.Active(true);
                var str = "insert into aluno(nome, telefone, email)" +
                          $" values('{aluno.Nome}','{aluno.Telefone}','{aluno.Email}')";
                var cmd = new FbCommand(str, Connection.FbCnn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Connection.Active(false);
                throw;
            }

        }
        public object SelectAluno(Aluno aluno)
        {
            try
            {
                Connection.Active(true);

                var str = "select * from aluno " + $"where nome = '{aluno.Nome}' and telefone = '{aluno.Telefone}'";

                var cmd = new FbCommand(str, Connection.FbCnn);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Connection.Active(false);
                throw;
            }

        }
        public Aluno SelectAluno(string nome, string telefone)
        {
            try
            {
                var alunoSelecionado = new Aluno();
                Connection.Active(true);

                var str = "select * from aluno " + $"where nome = '{nome}' and telefone = '{telefone}'";

                var cmd = new FbCommand(str, Connection.FbCnn);

                var dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    var unused = dataReader[0].ToString();
                    alunoSelecionado.Nome = dataReader[1].ToString();
                    alunoSelecionado.Telefone = dataReader[2].ToString();
                    alunoSelecionado.Email = dataReader[3].ToString();
                }

                return alunoSelecionado;
            }
            catch (Exception)
            {
                Connection.Active(false);
                throw;
            }

        }

    }
}
