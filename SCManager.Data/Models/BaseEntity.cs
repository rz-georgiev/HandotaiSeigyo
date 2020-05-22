﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCManager.Data.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public ApplicationUser CreatedByIdentityUser { get; set; }

        public ApplicationUser LastUpdatedByIdentityUser { get; set; }

        public bool IsActive { get; set; }
    }
}
