﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class OfficePhone
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public OfficePhone(string number)
        {
            Number = number;
        }
        public OfficePhone(int id, string number)
        {
            Id = id;
            Number = number;
        }

    }
}
