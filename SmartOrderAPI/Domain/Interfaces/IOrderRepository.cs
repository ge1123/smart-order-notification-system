using SmartOrderAPI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartOrderAPI.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order?> GetByIdAsync(int id);
        Task<IEnumerable<Order>> GetAllAsync();
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task DeleteAsync(int id);
    }
}
