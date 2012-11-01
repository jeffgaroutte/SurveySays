using SurveySays.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveySays.Domain.Api
{
    public class Survey
    {
        internal Guid CurrentQuestionId;
        internal IList<Question> OrderedQuestions;
        internal IDictionary<Guid, SingleChoiceQuestion> SingleChoiceQuestions;
        internal IDictionary<Guid, MultiChoiceQuestion> MultiChoiceQuestions;
        internal IDictionary<Guid, MemoQuestion> MemoQuestions;

        public Survey()
        {
            OrderedQuestions = new List<Question>();
            SingleChoiceQuestions = new Dictionary<Guid, SingleChoiceQuestion>();
            MultiChoiceQuestions = new Dictionary<Guid, MultiChoiceQuestion>();
            MemoQuestions = new Dictionary<Guid, MemoQuestion>();
        }

        public QuestionSummary GetNextQuestion()
        {
            Question question = OrderedQuestions.FirstOrDefault(q => !q.IsAnswered() && q.PreReqisitesHaveAllBeenMet());
            QuestionSummary summary = null;
            
            if(question !=null)
            {
                summary = new QuestionSummary()
                {
                    Id = question.Id,
                    QuestionText = question.QuestionText
                };
            }

            return summary;
        }

        internal void AddQuestion(SingleChoiceQuestion question)
        {
            OrderedQuestions.Add(question);
            SingleChoiceQuestions[question.Id] = question;
        }

        internal void AddQuestion(MultiChoiceQuestion question)
        {
            OrderedQuestions.Add(question);
            MultiChoiceQuestions[question.Id] = question;
        }

        internal void AddQuestion(MemoQuestion question)
        {
            OrderedQuestions.Add(question);
            MemoQuestions[question.Id] = question;
        }

        public void RecordSingleAnswer(Guid questionId, Guid choiceId)
        {
            var question = SingleChoiceQuestions[questionId];
            question.SelectChoice(choiceId);
        }

        public void RecordMultiAnswer(Guid questionId, List<Guid> choiceIds)
        {
            var question = MultiChoiceQuestions[questionId];
            foreach (var choiceId in choiceIds)
	        {
                question.SelectChoice(choiceId);
	        }
        }

        public void RecordMemoAnswer(Guid questionId, string memoText)
        {
            var question = MemoQuestions[questionId];
            question.UpdateMemo(memoText);
        }

        public dynamic CompileResponse()
        {
            var response = from question in OrderedQuestions
                           select new
                           {
                               QuestionText = question.AnswerText,
                               Answer = question.AnswerText
                           };
            return response;

        }


    }
}