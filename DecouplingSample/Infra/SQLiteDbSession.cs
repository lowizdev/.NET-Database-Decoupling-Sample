using Microsoft.Data.Sqlite;
using System.Data;

namespace DecouplingSample.Infra
{
    public class SQLiteDbSession : IDisposable
    {
        public IDbConnection DbConnection { get; set; }

        public SQLiteDbSession()
        {
            DbConnection = new SqliteConnection("#TODO: PUT YOUR PATH HERE OR LOAD FROM FILE");
            DbConnection.Open();
        }
        public void Dispose()
        {
            DbConnection?.Dispose();
        }
    }
}
