using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Data.Common;

namespace ClassLibrary1
{
    public static class Connection
    {
        //variáveis de conexão e acesso
        static FbConnection fbCnn;
        static FbCommandBuilder fbCmm = new FbCommandBuilder();

        //GET & SET
        public static FbConnection FbCnn
        {
            get { return fbCnn; }
        }
        public static FbCommandBuilder FbCmm
        {
            get { return fbCmm; }
        }
        //MÉTODOS
        public static Boolean Active(Boolean bActive)
        {
            if (bActive)
            {
                string _conn;
                _conn = "User=SYSDBA;Password=masterkey";
                _conn += ";Database = C:\\Users\\Escolar Manager\\Desktop\\NASCIMENTO\\BANCO\\CADASTRO.FDB"; //G:\\BANCOS\\CADASTRO.FDB";
                _conn += ";Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;";
                _conn += "Connection timeout=7;Pooling=True;Packet Size=8192;Server Type=0";
                fbCnn = new FbConnection(_conn);
                fbCnn.Open();
                return true;
            }else
            {
                fbCnn.Close();
                return false;
            }
        }

    }
}
