using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Aluno 
    {
        #region "Atributos"
        public string _nome;

        public string _telefone;

        public string _email;
        
        #endregion

        
        public FbDataReader Open(FbConnection _conn)
        {
            FbCommand cmd = new FbCommand();
            cmd.Connection = _conn;
            cmd.CommandText = "select * from aluno";
            return cmd.ExecuteReader();
        }
    }
}
