﻿using System;

namespace WebAPI.Domain.Models
{   
    /// <summary>
    /// Represents fields in database table
    /// </summary>
    public partial class RelationCategory
    {
        public Guid RelationId { get; set; }
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Relation Relation { get; set; }
    }
}
