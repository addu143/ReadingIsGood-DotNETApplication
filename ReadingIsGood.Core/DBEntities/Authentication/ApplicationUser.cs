﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingIsGood.Core.DBEntities.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public virtual Customer Customer { get; set; }
    }
}
