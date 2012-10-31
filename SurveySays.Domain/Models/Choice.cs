using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class Choice
    {
        public Guid Id { get; set; }
        public bool Selected { get; set; }
        public string DisplayText { get; set; }
        public string Value { get; set; }
        public bool ReadOnly { get; set; }

    }
}