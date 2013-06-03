﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todolist.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public String  Text { get; set; }
        public DateTime? DueDate { get; set; }
        public int Priority { get; set; }   
    }
}