﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lektion22.Models.Entities.Abstract
{
    public interface IEntity
    {
        Guid ID { get; set; }
    }
}
