using VietSacBackend._3.Repository.BaseRepository;
using VietSacBackend._3.Repository.Data;

namespace VietSacBackend._3.Repository.Repository
{
    public interface IOrderRepository : IGenericRepository<OrderEntity>
    {
    }

    public class OrderRepository : GenericRepository<OrderEntity>, IOrderRepository
    {
    }
}
