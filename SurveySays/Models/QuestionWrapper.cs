using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SurveySays.Models
{
    public class QuestionWrapper
    {

        private Func<IEnumerable<string>> answerResolver;
        public string QuestionText { get; private set; }

        public IEnumerable<string> ResolveAnswerValues()
        {
            return answerResolver.Invoke();
        }

        private QuestionWrapper(IQuestion question)
        {
            this.QuestionText = question.QuestionText;
        }

        public QuestionWrapper(MemoAnswerQuestion memoAnswerQuestion) : this((IQuestion)memoAnswerQuestion)
        {
            answerResolver = delegate()
            {
                return new[] { memoAnswerQuestion.Answer };
            };
        }

        public QuestionWrapper(SingleAnswerQuestion choiceQuestion) : this((IQuestion)choiceQuestion)
        {
            answerResolver = delegate()
            {
                return new[] { choiceQuestion.Answer.Value };
            };
        }

        public QuestionWrapper(MultiAnswerQuestion multiAnswerQuestion) : this((IQuestion)multiAnswerQuestion)
        {
            answerResolver = delegate()
            {
                var answers = multiAnswerQuestion.Answers;
                var answerValues = answers.Select(x => x.Value);
                return answerValues;
            };
        }

    }
}
