﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskApi.Models
{
    public class TaskDBContext: DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options)
            : base (options)
        {
        }
        public DbSet<Task> Task { get; set; } = null!;
    }
}
