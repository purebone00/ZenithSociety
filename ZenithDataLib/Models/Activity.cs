﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Activity Title")]
        public string ActivityDescription { get; set; }

        public DateTime CreationDate { get; set; }

        public List<Event> Events { get; set; }
    }
}
