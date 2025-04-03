﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IdCard Card { get; set; }
    }
}
