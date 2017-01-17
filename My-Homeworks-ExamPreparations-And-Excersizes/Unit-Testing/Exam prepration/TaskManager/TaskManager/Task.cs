﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Model
{
    public class Task
    {
        public Task(string descriptin, DateTime? deadline = null)
        {
            this.Description = descriptin;
            this.Deadline = deadline;
            this.isDone = false;
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime? Deadline { get; set; }

        public bool isDone { get; set; }

    }
}
