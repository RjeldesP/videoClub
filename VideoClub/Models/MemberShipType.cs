﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoClub.Models
{
    public class MemberShipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SingFree { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}