﻿using System;
using System.Collections.Generic;
using System.Text;

namespace todozulu.Common.Models
{
    class Todo
    {
        public DateTime CreatedTime { get; set; }
        public string  TaskDescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
