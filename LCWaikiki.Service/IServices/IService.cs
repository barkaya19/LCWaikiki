namespace LCWaikiki.Service.IServices
{

    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

    }
}
