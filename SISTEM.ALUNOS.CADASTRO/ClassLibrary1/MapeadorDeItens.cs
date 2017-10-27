using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using FirebirdSql.Data.FirebirdClient;

namespace CORE
{
    public class MapeadorDeItens
    {
        public MapeadorDeItens()
        {
        }
        public static bool InserirItens(List<ItemDePedido> itensDePedidos)
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

        public static List<ItemDePedido> ObtenhaTodosItens()
        {
            var lista = new List<ItemDePedido>();

            var sql = ObtenhaSqlDeSelecao();
            Connection.Active(true);

            var cmd = new FbCommand(sql,Connection.FbCnn);

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    var unused = dr[0].ToString();
                    lista.Add(Mapeie(dr));
                }
            }

            return lista;
        }

        private static string ObtenhaSqlDeSelecao()
        {
            return "select * from TBPRODUTOS";
        }

        internal static ItemDePedido Mapeie(IDataRecord dr) => new ItemDePedido
        {
            Descricao = dr[1].ToString(),
            Preco = Convert.ToDouble(dr[2].ToString())
        };
    }
}
