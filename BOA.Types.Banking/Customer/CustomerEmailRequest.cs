﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOA.Types.Banking.Customer
{
    public class CustomerEmailRequest : RequestBase
    {
        public CustomerEmailContract DataContract { get; set; }
    }
}