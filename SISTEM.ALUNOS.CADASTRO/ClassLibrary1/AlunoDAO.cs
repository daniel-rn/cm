using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class AlunoDAO
    {
        public Object InsereAluno(Aluno aluno)
        {
            try
            {
                Connection.Active(true);
                string str = string.Format("insert into aluno(nome, telefone, email) values('{0}','{1}','{2}')", aluno._nome, aluno._telefone, aluno._email);
                FbCommand cmd = new FbCommand(str, Connection.FbCnn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                Connection.Active(false);
                throw erro;
            }
            
        }


    }
}
