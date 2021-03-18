using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using ToDo.Models;

namespace ToDo.Pages
{
    public class MyTodos2Model : PageModel
    {
        private readonly ToDo.Data.ToDoContext _context;

        public MyTodos2Model(ToDo.Data.ToDoContext context)
        {
            _context = context;
        }

        public IList<WhatTodo> WhatTodo { get;set; }

        public async Task OnGetAsync()
        {
            WhatTodo = await _context.WhatTodo.ToListAsync();
        }
    }
}
