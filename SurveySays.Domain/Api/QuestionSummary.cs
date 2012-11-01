using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySays.Domain.Api
{
    public class QuestionSummary
    {
        public Guid Id { get; set; }
        public String QuestionText { get; set; }
    }
}
