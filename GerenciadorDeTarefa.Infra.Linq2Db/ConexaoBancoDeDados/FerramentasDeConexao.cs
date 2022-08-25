using LinqToDB;
using LinqToDB.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorDeTarefa.Infra.BancoDeDados.Linq2Db.ConexaoBancoDeDados
{
    public class FerramentasDeConexao : IConnectionStringSettings
    {
        public string? ConnectionString { get; set; }
        public string? Name { get; set; }
        public string? ProviderName { get; set; }
        public bool IsGlobal => false;
    }
    public class Feramentas : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();
        public string DefaultConfiguration => "SqlServer";
        public string DefaultDataProvider => "SqlServer";
        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new FerramentasDeConexao
                    {
                        Name = "DB_GerenciadorDeTarefa",
                        ProviderName = ProviderName.SqlServer,
                        ConnectionString = @"Data Source = DEV-WIN-2019; Initial Catalog = DB_GerenciadorDeTarefa; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False",
                    };
            }
        }
    }
}


