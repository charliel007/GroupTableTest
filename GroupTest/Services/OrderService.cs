using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

    public OrderService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Order> CreateOrder(OrderCreate orderCreate)
        {
            var order = new Order();

            foreach (var id in orderCreate.ItemIds)
            {
                var item = _context.Items.SingleOrDefault(i => i.Id == id);
                if(item == null)
                return null;

                order.Items.Add(item);
            }
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            // transform order object to order detail object
            return order;
        }
    }
