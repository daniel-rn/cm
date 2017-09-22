using FirebirdSql.Data.FirebirdClient;

namespace Biblioteca
{
    public static class Connection
    {
        public static FbConnection FbCnn { get; private set; }

        public static FbCommandBuilder FbCmm { get; } = new FbCommandBuilder();

        public static bool Active(bool bActive)
        {
            if (bActive)
            {
                FbCnn = new FbConnection(ConfiguracoesBanco());
                FbCnn.Open();
                return true;
            }
            FbCnn.Close();
            return false;
        }

        private static string ConfiguracoesBanco()
        {
            var configuracoesBanco = "User=SYSDBA;Password=masterkey";
            configuracoesBanco += ";Database = G:\\BANCOS\\CADASTRO.FDB";
            //configuracoesBanco += ";Database = C:\\Users\\Escolar Manager\\Desktop\\NASCIMENTO\\BANCO\\CADASTRO.FDB";
            configuracoesBanco += ";Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=0;";
            configuracoesBanco += "Connection timeout=7;Pooling=True;Packet Size=8192;Server Type=0";
            return configuracoesBanco;
        }
    }
}
