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
        private string _nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        private string _telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
            }
        }
        private string _email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        #endregion

        //metodos
        public FbDataReader Open(FbConnection _conn)
        {
            FbCommand cmd = new FbCommand();
            cmd.Connection = _conn;
            cmd.CommandText = "select * from aluno";
            return cmd.ExecuteReader();
        }
    }
}
