using Microsoft.Data.Sqlite;
using System.Data;

namespace DecouplingSample.Infra
{
    public class SQLiteDbSession : IDisposable
    {
        public IDbConnection DbConnection { get; set; }

        public SQLiteDbSession()
        {
            DbConnection = new SqliteConnection("Data Source=C:\\Users\\santo\\source\\repos\\DecouplingSample\\DecouplingSample\\database.db");
            DbConnection.Open();
        }
        public void Dispose()
        {
            DbConnection?.Dispose();
        }
    }
}
