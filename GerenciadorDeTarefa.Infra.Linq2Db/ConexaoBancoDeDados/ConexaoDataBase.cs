using GerenciadorDeTarefa.Domain.BlocoDeNotas;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeTarefa.Infra.BancoDeDados.Linq2Db.ConexaoBancoDeDados
{
    public class ConexaoDataBase : DbContext
    {

        public class ObterConexaoSqlserver
        {
            public static string strConn = @"Data Source=INVENT039\B1;Initial Catalog=DB_GerenciadorDeTarefa;Integrated Security=True";
        }

        public class ObterConexaoLinq
        {

            private static string connectionString;
            public static void ConexaoLinqToDB()
            {
                var db = new LinqToDB.Data.DataConnection(
                 LinqToDB.ProviderName.SqlServer2012, @"Data Source=INVENT039\B1;Initial Catalog=DB_GerenciadorDeTarefa;Integrated Security=True");

                var builder = new LinqToDBConnectionOptionsBuilder();
                builder.UseSqlServer(connectionString);

                var DataConn = new DataConnection(builder.Build());
            }
        }

        public class AppDataConn : DataConnection
        {
            public ITable<Anotacao> Anotacoes
            {
                get
                {
                    return this.GetTable<Anotacao>();
                }
            }
            public AppDataConn(LinqToDBConnectionOptions<AppDataConn> options) : base(options)
            {

            }
        }

    }

}
