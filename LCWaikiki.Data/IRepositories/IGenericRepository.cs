namespace LCWaikiki.Data.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        
    }
}
