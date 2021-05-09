﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webowe_dummy.Models
{
    public class Physician
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Specialisation { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}