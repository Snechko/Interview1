﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbleraAPI.Models
{
    public class AddCarsRequest
    {
        public string? Name { get; set; }
        public string? Properties { get; set; }
    }
}
