using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class AlunoDAL
    {
        public Object InsereAluno(Aluno aluno)
        {
            try
            {
                Connection.Active(true);
                string str = string.Format("insert into aluno(nome, telefone, email)" +
                    " values('{0}','{1}','{2}')", aluno._nome, aluno._telefone, aluno._email);
                FbCommand cmd = new FbCommand(str, Connection.FbCnn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                Connection.Active(false);
                throw erro;
            }

        }
        public Object SelectAluno(Aluno aluno)
        {
            try
            {
                Connection.Active(true);

                string str = string.Format("select * from aluno " +
                    "where nome = '{0}' and telefone = '{1}'", aluno._nome, aluno._telefone);

                FbCommand cmd = new FbCommand(str, Connection.FbCnn);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                Connection.Active(false);
                throw erro;
            }

        }
        public Aluno SelectAluno(string nome, string telefone)
        {
            try
            {
                Aluno alunoSelecionado = new Aluno();
                Connection.Active(true);

                string str = string.Format("select * from aluno " + "where nome = '{0}' and telefone = '{1}'", nome, telefone);

                FbCommand cmd = new FbCommand(str, Connection.FbCnn);

                FbDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    dataReader[0].ToString();
                    alunoSelecionado._nome = dataReader[1].ToString();
                    alunoSelecionado._telefone = dataReader[2].ToString();
                    alunoSelecionado._email = dataReader[3].ToString();
                }

                return alunoSelecionado;
            }
            catch (Exception erro)
            {
                Connection.Active(false);
                throw erro;
            }

        }

    }
}
