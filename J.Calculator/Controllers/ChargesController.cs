using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using J.Calculator.Data;
using J.Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace J.Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargesController : ControllerBase
    {
        private readonly CalculatorDbContext _context;

        public ChargesController( CalculatorDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Charge>> GetTodoItem(long id)
        {
            var todoItem = await _context.Charges.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }
    }
}