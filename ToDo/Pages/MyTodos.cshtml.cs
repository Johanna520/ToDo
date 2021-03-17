using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;




namespace ToDo.Pages
{
    public class MyTodosModel : PageModel
    {
        private readonly ILogger<ErrorModel> _logger;

        public List<Models.WhatTodo> WhatTodos;
       
        public MyTodosModel(ILogger<ErrorModel> logger)
        {
            _logger = logger; 

            WhatTodos = new List<Models.WhatTodo>()
            {
                new Models.WhatTodo() { Deadline = "20210503", Start = "20210319", Task = "Clean car",      Done = false },
                new Models.WhatTodo() { Deadline = "20210412", Start = "20210401", Task = "Buy groceries",  Done = true },
                new Models.WhatTodo() { Deadline = "20210526", Start = "20210416", Task = "Mow the lawn",   Done = false },
                new Models.WhatTodo() { Deadline = "20210317", Start = "20210317", Task = "Make dinner",    Done = true }
            };
        }
        //här vill vi ha en referns till en todo lista
        public void OnGet()
        {
            _logger.LogInformation("Nu fick vi ett GET repost");
        }

        public void OnPost()
        {
            _logger.LogInformation("Nu fick vi en POST repost");
            var Deadline = Request.Form["Deadline"];
            var Start = Request.Form["Start"];
            var Task = Request.Form["Task"];
            var Done = Request.Form["Done"];
            WhatTodos.Add(new Models.WhatTodo(){ Deadline = Deadline, Start = Start, Task = Task, Done = Done.ToString() == "on" }) ;
        }


    }
}
