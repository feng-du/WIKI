﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WIKI.WebApi.Models
{
    public class DocumentUpdateInputDto
    {
        [Required]
        [MaxLength(60)]
        public virtual string Title { get; set; }

        [Required]
        public virtual bool Sticky { get; set; }

        [Required]
        public virtual bool Important { get; set; }

        [MaxLength(200)]
        public virtual string Description { get; set; }

        public List<string> Tags { get; set; }
    }
}