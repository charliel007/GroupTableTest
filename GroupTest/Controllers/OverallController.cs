using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GroupTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OverallController : ControllerBase
    {
        private IMenuService _mServerice;
        private IOrderService _oServerice;
        private IItemService _iItemServerice;

        public OverallController(IMenuService mServerice, IOrderService oServerice, IItemService iItemServerice)
        {
            _mServerice = mServerice;
            _oServerice = oServerice;
            _iItemServerice = iItemServerice;
        }

        [HttpPost("MenuCreate")]
        public async Task<IActionResult> MenuCreate(Menu menu)
        {
            if(await _mServerice.CreateMenu(menu))
            return Ok();
            else
            return StatusCode(500,"Internal Server Error");
        }

        [HttpPost("ItemCreate")]
        public async Task<IActionResult> ItemCreate(ItemCreate item)
        {
            if(await _iItemServerice.CreateItem(item))
            return Ok();
            else
            return StatusCode(500,"Internal Server Error");
        }

        [HttpPost("OrderCreate")]
        public async Task<IActionResult> OrderCreate(OrderCreate orderCreate)
        {
            
            return Ok(await _oServerice.CreateOrder(orderCreate));
            
        }

    }
}