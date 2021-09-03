using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace todozulu.Functions.Entities
{
    class TodoEntity : TableEntity 
    {

        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public bool Result { get; set; }


    }
}
