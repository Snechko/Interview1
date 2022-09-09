﻿using System.ComponentModel.DataAnnotations;

namespace AbleraAPI.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }   
        public string? Properties { get; set; }
    }
}
