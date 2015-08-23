using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Pattern.DataContext;
using StackExchange.Redis;

namespace Repository.Pattern.Redis {
    public class DataContext : IDataContextAsync {

        /// <summary>
        /// Constructs a data context for a single redis server. As no port is provided, 
        /// the default port is specified (6379)
        /// </summary>
        /// <param name="host"></param>
        public DataContext(string host) : this(host, 6379)
        {
        }

        public DataContext(string host, int port)
        {
            _host = host;
            _port = port;

            _connectionMultiplexer = ConnectionMultiplexer.Connect(_connectionString);
        }

        private string _host;
        private int _port;
        private ConnectionMultiplexer _connectionMultiplexer;

        private string _connectionString
        {
            get { return string.Format("{0}:{1}", _host, _port); }
        }

        public Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync() {
            throw new NotImplementedException();
        }

        public int SaveChanges() {
            throw new NotImplementedException();
        }

        public void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, Infrastructure.IObjectState {
            throw new NotImplementedException();
        }

        public void SyncObjectsStatePostCommit() {
            throw new NotImplementedException();
        }

        public void Dispose() {
            throw new NotImplementedException();
        }
    }
}
