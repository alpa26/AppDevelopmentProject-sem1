using AppDevelopmentProject.Entities.Interfaces;

namespace AppDevelopmentProject.Services.Interfaces
{
    public interface IRepository
    {
        public Task<T?> CreateAsync<T>(T item) where T : class, IEntity;
        public Task<bool> ChangeAsync<T>(T item) where T : class, IEntity;
        public Task<List<T>> FindListAsync<T>() where T : class, IEntity;
        public Task<T?> FindByIdAsync<T>(Guid? id) where T : class, IEntity;
        public Task<bool> RemoveAsync<T>(Guid? id) where T : class, IEntity;
        public Task SaveChangesAsync();
    }
}
