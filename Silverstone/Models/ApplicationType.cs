﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Silverstone.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
