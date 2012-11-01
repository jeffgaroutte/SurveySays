using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Domain.Models
{
    internal class MemoQuestion : Question
    {

        private Guid id;
        private string questionText;
        private string memoText;

        internal MemoQuestion(string questionText)
            : base(questionText)
        {
            this.id = Guid.NewGuid();
            this.questionText = questionText;
        }

        internal void UpdateMemo(string memoText)
        {
            this.memoText = memoText;
        }

        internal override string AnswerText
        {
            get { return memoText; }
        }

        internal bool IsAnswered()
        {
            return !string.IsNullOrWhiteSpace(this.AnswerText);
        }
    }
}