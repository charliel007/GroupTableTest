using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class ItemService : IItemService
{
    private readonly ApplicationDbContext _context;

    public ItemService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateItem(ItemCreate item)
    {
        var entity = new Item()
        {
            Name = item.Name,
            Cost = item.Cost,
            Description = item.Description,
            MenuId = item.MenuId,
        };
        await _context.Items.AddAsync(entity);
        return await _context.SaveChangesAsync() > 0;
    }
}
