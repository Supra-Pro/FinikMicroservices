﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePageRequests.Domain.Entities
{
    public class ResponseModel
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}