using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ToDo.Data;



namespace ToDo.Pages
{
    public class MyTodosModel : PageModel
    {
        public List<Models.WhatTodo> WhatTodos { get; set; }

        [BindProperty]
        public Models.WhatTodo newWhatTodo { get; set; }

        private readonly ILogger<ErrorModel> _logger;
        private readonly TodoDbContext _context;
                
        public MyTodosModel(ILogger<ErrorModel> logger,
            TodoDbContext context)
            
        {
            _context = context;
            _logger = logger;

            WhatTodos = _context.WhatTodos.ToList();
        }
        //här vill vi ha en referns till en todo lista
        public void OnGet()
        {
            _logger.LogInformation("Nu fick vi ett GET repost");
        }

        public void OnPost( string Deadline, string Start, string Task, bool Done)
        {
            _logger.LogInformation("Nu fick vi en POST repost");

            WhatTodos.Add(newWhatTodo);
            _context.WhatTodos.Add(newWhatTodo);
            _context.SaveChanges();
        }


    }
}
