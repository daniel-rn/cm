using System;
using System.Collections.Generic;
using System.Data.Common;
using FirebirdSql.Data.FirebirdClient;

namespace CORE
{
    public class MapeadorDeItens
    {
        public MapeadorDeItens()
        {
        }
        public bool InserirItens(List<ItemDePedido> itensDePedidos)
        {
            try
            {
                var sql = ObtenhaSqlDeInsercao();

                using (var tx = Connection.ObtenhaFbTransaction()) 
                {
                    var cmd = new FbCommand(sql, Connection.FbCnn, tx);
                    cmd.Parameters.Add(new FbParameter{ParameterName = "@descricao"});
                    cmd.Parameters.Add(new FbParameter { ParameterName = "@preco" });

                    foreach (var itemDePedido in itensDePedidos)
                    {
                        cmd.Parameters["@descricao"].Value = itemDePedido.Descricao;
                        cmd.Parameters["@preco"].Value = itemDePedido.Preco;
                        cmd.ExecuteNonQuery();
                    }
                    tx.Commit();
                }
                return true;
            }
            catch (Exception)
            {
                Connection.Active(false);
                throw;
            }
        }

        private static string ObtenhaSqlDeInsercao()
        {
            return "insert into TBPRODUTOS(Descricao, Preco) values(@descricao,@preco)";
        }

        public void ObtenhaTodosItens()
        {
            var sql = "select * from TBPRODUTOS";
            Connection.Active(true);

            var cmd = new FbCommand
            {
                CommandText = sql, 
                Connection = Connection.FbCnn
            };

            var x = 0;

            using(var dr = cmd.ExecuteReader())
            {
                while (dr.NextResult())
                {
                    var des = dr.GetString('DESCRICAO');

                    new ItemDePedido
                    {
                        Descricao = dr.GetString("TBPROCODIGO")
                    };
                }
            }
        }
    }
}
