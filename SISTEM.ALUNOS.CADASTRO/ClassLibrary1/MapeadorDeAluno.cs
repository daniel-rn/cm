using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using FirebirdSql.Data.FirebirdClient;

namespace CORE
{
    public class MapeadorDeAluno
    {
        public static bool InsereAluno(Aluno aluno)
        {
            try
            {
                using (var transaction = Connection.ObtenhaFbTransaction())
                {
                    var cmd = Connection.ObtehaComando(ObtenhaSqlDeInsercaoDeAluno(aluno));
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                return true;
            }
            catch (Exception)
            {
                Connection.Active(false);
                throw;
            }

        }

        private static string ObtenhaSqlDeInsercaoDeAluno(Aluno aluno)
        {
            return "insert into aluno(nome, telefone, email)" +
                                      $" values('{aluno.Nome}','{aluno.Telefone}','{aluno.Email}')";
        }

        public object ObtenhaAluno(Aluno aluno)
        {
            try
            {
                Connection.Active(true);

                var str = "select * from aluno " + $"where nome = '{aluno.Nome}' and telefone = '{aluno.Telefone}'";

                var cmd = new FbCommand(str, Connection.FbCnn);

                return cmd.ExecuteReader();
            }
            catch (Exception)
            {
                Connection.Active(false);
                throw;
            }

        }
        public Aluno ObtenhaAluno(string nome, string telefone)
        {
            try
            {
                var alunoSelecionado = new Aluno();

                var cmd = Connection.ObtehaComando(ObtenhaSqlDeConsultaDeAluno(nome,telefone));

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var unused = dataReader[0].ToString();
                        alunoSelecionado = MapeieAluno(dataReader);
                    }
                }

                return alunoSelecionado;
            }
            catch (Exception)
            {
                Connection.Active(false);
                throw;
            }

        }
        public static IEnumerable<dynamic> ObtenhaTodosOsAlunos()
        {
            try
            {
                var listaDeAlunos = new List<dynamic>();

                var cmd = Connection.ObtehaComando(ObtenhaSqlDeConsultaDeTodosOsAlunos());

                using (var dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        listaDeAlunos.Add(MapeieAluno(dataReader));
                    }
                }

                return listaDeAlunos;
            }
            catch (Exception)
            {
                Connection.Active(false);
                throw;
            }

        }

        private static string ObtenhaSqlDeConsultaDeTodosOsAlunos() => "select * from aluno";

        private static string ObtenhaSqlDeConsultaDeAluno(string nome, string telefone)
        {
            return "select * from aluno " + $"where nome = '{nome}' and telefone = '{telefone}'";
        }

        private static Aluno MapeieAluno(IDataRecord dataReader) => new Aluno
        {
            Id = Convert.ToInt16(dataReader[0].ToString()),
            Nome = dataReader[1].ToString(),
            Telefone = dataReader[2].ToString(),
            Email = dataReader[3].ToString()
        };
    }
}
