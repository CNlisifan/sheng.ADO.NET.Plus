﻿using Linkup.DataRelationalMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheng.ADO.NET.Plus
{
    class UserEntity
    {
        [Key]
        public Guid Id
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }
    }
}
