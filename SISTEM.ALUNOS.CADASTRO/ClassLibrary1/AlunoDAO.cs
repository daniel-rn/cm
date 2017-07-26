using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AlunoDAO
    {
        private FbConnection _conn;
        private FbCommand cmd;
        public Object InsereAluno(Aluno aluno)
        {
            
            cmd.Connection = _conn;
            cmd.CommandText = string.Format("INSERT INTO ALUNO (NOME, TELEFONE, EMAIL) VALUES({0},{1},{2})",aluno._nome,aluno._telefone,aluno._email);

            return cmd.ExecuteNonQuery();
        }


    }
}
