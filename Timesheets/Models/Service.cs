﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    /// <summary> Информация о предостовляеммой услуге в рамках контракта </summary>
    public class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
