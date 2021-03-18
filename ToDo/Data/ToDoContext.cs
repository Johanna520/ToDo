using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext (DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo.Models.WhatTodo> WhatTodo { get; set; }

        public void Seed()
        {
            this.Database.EnsureCreated();
            if (this.WhatTodo.Any())
            {
                return;
            }

            WhatTodo.AddRange(new List<Models.WhatTodo>()
            {
                new Models.WhatTodo() { Deadline = "20210503", Start = "20210319", Task = "Clean car",      Done = false },
                new Models.WhatTodo() { Deadline = "20210412", Start = "20210401", Task = "Buy groceries",  Done = true },
                new Models.WhatTodo() { Deadline = "20210526", Start = "20210416", Task = "Mow the lawn",   Done = false },
                new Models.WhatTodo() { Deadline = "20210317", Start = "20210317", Task = "Make dinner",    Done = true }
            });
            this.SaveChanges();
        }
    }
}
