using System.Collections.Generic;


namespace SportsStore.Models
{
    interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
