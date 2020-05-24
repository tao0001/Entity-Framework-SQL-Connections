﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC001.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public bool Customs_Formalities { get; set; }
        public string BankCard { get; set; }
        public DateTime DateValidicity { get; set; }
        public int CVV { get; set; }

    }
}
