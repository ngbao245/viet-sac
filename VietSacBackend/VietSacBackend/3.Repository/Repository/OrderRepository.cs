using VietSacBackend._3.Repository.BaseRepository;
using VietSacBackend._3.Repository.Data;

namespace VietSacBackend._3.Repository.Repository
{
    public interface IOrderRepository : IGenericRepository<OrderEntity>
    {
        public bool CreateOrder(OrderEntity order, List<CartEntity> carts);
    }

    public class OrderRepository : GenericRepository<OrderEntity>, IOrderRepository
    {
        private readonly VietSacContext _context;
        public OrderRepository()
        {
            _context = new VietSacContext();
        }

        public bool CreateOrder(OrderEntity order, List<CartEntity> carts)
        {
            var myTransaction = _context.Database.BeginTransaction();
            try
            {
                _context.orderEntities.Add(order);
                foreach (var cart in carts)
                {
                    _context.cartEntities.Update(cart);
                }
                _context.SaveChanges();
                myTransaction.Commit();
                return true;
            }
            catch
            {
                myTransaction.Rollback();
                return false;
            }
        }
    }
}
