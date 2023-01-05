using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class MenuService : IMenuService
    {
        private ApplicationDbContext _context;

    public MenuService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateMenu(Menu menu)
        {
            await _context.Menus.AddAsync(menu);
            return await _context.SaveChangesAsync() > 0;
        }
    }
