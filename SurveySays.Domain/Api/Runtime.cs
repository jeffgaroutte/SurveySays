using SurveySays.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySays.Domain.Api
{
    public class Runtime
    {
        private Survey _survey;

        public void RecordMemoQuestionAnswer(Guid questionId, string memoText)
        {

        }

        public void RecordMultiChoiceAnswer(Guid questionId, IEnumerable<Guid> choiceIds)
        {
        }

        
    }
}
