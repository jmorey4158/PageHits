﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageHits.Classes
{
    public class Hit
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
    }

}