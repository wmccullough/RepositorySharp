using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.Repositories;

namespace Repository.Pattern.Redis {
    public class Repository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class, IObjectState
    {
        public Task<TEntity> FindAsync(params object[] keyValues) {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues) {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(params object[] keyValues) {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues) {
            throw new NotImplementedException();
        }

        public TEntity Find(params object[] keyValues) {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> SelectQuery(string query, params object[] parameters) {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity) {
            throw new NotImplementedException();
        }

        public void InsertRange(IEnumerable<TEntity> entities) {
            throw new NotImplementedException();
        }

        public void InsertOrUpdateGraph(TEntity entity) {
            throw new NotImplementedException();
        }

        public void InsertGraphRange(IEnumerable<TEntity> entities) {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity) {
            throw new NotImplementedException();
        }

        public void Delete(object id) {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity) {
            throw new NotImplementedException();
        }

        public IQueryFluent<TEntity> Query(IQueryObject<TEntity> queryObject) {
            throw new NotImplementedException();
        }

        public IQueryFluent<TEntity> Query(System.Linq.Expressions.Expression<Func<TEntity, bool>> query) {
            throw new NotImplementedException();
        }

        public IQueryFluent<TEntity> Query() {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Queryable() {
            throw new NotImplementedException();
        }

        public IRepository<T> GetRepository<T>() where T : class, IObjectState {
            throw new NotImplementedException();
        }
    }
}
