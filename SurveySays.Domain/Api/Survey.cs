using SurveySays.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Api
{
    public class Survey
    {
        private Guid currentQuestionId;
        private IList<Question> orderedQuestions;
        private IDictionary<Guid, SingleChoiceQuestion> singleChoiceQuestions;
        private IDictionary<Guid, MultiChoiceQuestion> multiChoiceQuestions;
        private IDictionary<Guid, MemoQuestion> memoQuestions;

        public Survey()
        {
            orderedQuestions = new List<Question>();
            singleChoiceQuestions = new Dictionary<Guid, SingleChoiceQuestion>();
            multiChoiceQuestions = new Dictionary<Guid, MultiChoiceQuestion>();
            memoQuestions = new Dictionary<Guid, MemoQuestion>();
        }

        internal void AddQuestion(SingleChoiceQuestion question)
        {
            orderedQuestions.Add(question);
            singleChoiceQuestions[question.Id] = question;
        }

        internal void AddQuestion(MultiChoiceQuestion question)
        {
            orderedQuestions.Add(question);
            multiChoiceQuestions[question.Id] = question;
        }

        internal void AddQuestion(MemoQuestion question)
        {
            orderedQuestions.Add(question);
            memoQuestions[question.Id] = question;
        }

        public void RecordSingleAnswer(Guid questionId, Guid choiceId)
        {
            var question = singleChoiceQuestions[questionId];
            question.SelectChoice(choiceId);
        }

        public void RecordMultiAnswer(Guid questionId, List<Guid> choiceIds)
        {
            var question = multiChoiceQuestions[questionId];
            foreach (var choiceId in choiceIds)
	        {
                question.SelectChoice(choiceId);
	        }
            
        }

        public void RecordMemoAnswer(Guid questionId, string memoText)
        {
            var question = memoQuestions[questionId];
            question.UpdateMemo(memoText);
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