﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.entities
{
    public class Access
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

    }
}
