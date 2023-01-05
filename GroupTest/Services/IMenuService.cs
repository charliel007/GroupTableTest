using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IMenuService
    {   
        Task<bool> CreateMenu(Menu menu);
    
    }
