using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class Survey
    {
        public string Title { get; set; }
        public IList<QuestionWrapper> Questions { get; set; }

        public dynamic CompileResponse()
        {
            var response = from question in Questions
                           select new
                           {
                               QuestionText = question.QuestionText,
                               Answer = String.Join(", ", question.ResolveAnswerValues())
                           };
            return response;

        }


    }
}