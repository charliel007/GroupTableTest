using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public interface IItemService
    {
        Task<bool> CreateItem(ItemCreate item);
    }
