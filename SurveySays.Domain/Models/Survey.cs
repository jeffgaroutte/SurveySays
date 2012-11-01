using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Models
{
    internal class Survey
    {
        public string Title { get; set; }

        private Guid currentQuestionId;
        private IList<IQuestion> orderedQuestions;
        private IDictionary<Guid, SingleChoiceQuestion> singleChoiceQuestions;
        private IDictionary<Guid, MultiChoiceQuestion> multiChoiceQuestions;
        private IDictionary<Guid, MemoQuestion> memoQuestions;

        public void AddQuestion(SingleChoiceQuestion question)
        {
            orderedQuestions.Add(question);
            singleChoiceQuestions[question.Id] = question;
        }

        public void AddQuestion(MultiChoiceQuestion question)
        {
            orderedQuestions.Add(question);
            multiChoiceQuestions[question.Id] = question;
        }


        public void AddQuestion(MemoQuestion question)
        {
            orderedQuestions.Add(question);
            memoQuestions[question.Id] = question;
        }

        public void RecordSingleAnswer(Guid questionId, Guid choiceId)
        {
            var question = singleChoiceQuestions[questionId];
            question.SelectChoice(choiceId);
        }

        public void RecordMultiAnswer(Guid questionId, Guid choiceId)
        {
        }


        public void RecordMemoAnswer(Guid questionId, Guid choiceId)
        {

        }

        public dynamic CompileResponse()
        {
            var response = from question in orderedQuestions
                           select new
                           {
                               QuestionText = question.AnswerText,
                               Answer = question.AnswerText
                           };
            return response;

        }


    }
}