﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dot_net_core_practice_demo.Entities
{
    public record Item
    {
      public Guid Id { get; init; }
      public string Name { get; init; }
      public decimal Price { get; init; }
      public DateTimeOffset CreatedDate { get; init; }
            
            
            
    }
}
