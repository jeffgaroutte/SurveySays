using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurveySays.Domain.Api;
using SurveySays.Domain.Models;
using TechTalk.SpecFlow;

namespace SurveySays.Tests._2Background
{
    [Binding]
    public class Backgroundsteps
    {

        [Given(@"the (.*) question is ""([^""]*)"" with the answers ""(.*)""")]
        public void GivenTheForthQuestionIsWithTheAnswers(string questionKey, string questionText, string answers)
        {
            SurveySays.Domain.Api.Survey survey = ScenarioContext.Current["Survey"] as SurveySays.Domain.Api.Survey;

            SingleChoiceQuestion question = new SingleChoiceQuestion(questionText);
            PopulateAnswers(question, answers);
            survey.AddQuestion(question);
            ScenarioContext.Current["question-" + questionKey] = question;
        }

        [Given(@"the (.*) question is ""([^""]*)""")]
        public void GivenTheFifthQuestionIsOpenEnded(string questionKey, string questionText)
        {
            SurveySays.Domain.Api.Survey survey = ScenarioContext.Current["Survey"] as SurveySays.Domain.Api.Survey;

            MemoQuestion question = new MemoQuestion(questionText);
            survey.AddQuestion(question);
            ScenarioContext.Current["question-" + questionKey] = question;
        }

        [Given(@"the (.*) question has the prequsite that the (.*) question was answered with ""(.*)""")]
        public void GivenTheThirdQuestionHasThePrequsiteThatTheSecondQuestionWasAnsweredWith(string questionKeyThathasThePrerequsite, string questionKeyOfTheRelatedQuestion, string requiredAnswer)
        {
            Question questionThatHasThePreReq = ScenarioContext.Current["question-" + questionKeyThathasThePrerequsite] as Question;
            Question questionThatIsThePreReq = ScenarioContext.Current["question-" + questionKeyOfTheRelatedQuestion] as Question;
            IPreRequsite preReq=null;
            if (questionThatIsThePreReq is MemoQuestion)
            {
                preReq = new MemoPreRequsite()
                {
                    Question = questionThatIsThePreReq as MemoQuestion
                };
            }
            else
            {
                ChoiceQuestion choiceQuestion=questionThatIsThePreReq as ChoiceQuestion;
                Choice choice = choiceQuestion.Choices.SingleOrDefault(c => c.DisplayText.Equals(requiredAnswer));
                preReq = new ChoicePreRequsite()
                {
                    Question = choiceQuestion,
                    RequiredChoice=choice
                };
            }

            questionThatHasThePreReq.AddPreRequisite(preReq);
        }
        

        [Given(@"I answered the (.*) question with ""(.*)""")]
        public void GivenIAnsweredTheFirstQuestionWith(string questionKey, string answer)
        {
            Question question = ScenarioContext.Current["question-" + questionKey] as Question;

            SurveySays.Domain.Api.Survey survey = ScenarioContext.Current["Survey"] as SurveySays.Domain.Api.Survey;

            if (question is MemoQuestion)
            {
                survey.RecordMemoAnswer(question.Id, answer);
            }
            if (question is ChoiceQuestion)
            {
                var q = question as ChoiceQuestion;
                Choice choice = q.Choices.SingleOrDefault(c => c.DisplayText.Equals(answer));
                if (choice == null)
                    Assert.Fail("The anwser \"" + answer + "\" was not found within the question \"" + q.QuestionText + "\"");
                if (q is SingleChoiceQuestion)
                {
                    survey.RecordSingleAnswer(q.Id, choice.Id);
                }
                else
                {
                    survey.RecordMultiAnswer(q.Id, new List<Guid> { choice.Id });
                }

            }
            
        }

        [Then(@"the question should be the (.*) question")]
        public void ThenTheQuestionShouldBeTheThirdQuestion(string questionKey)
        {
            Question question = ScenarioContext.Current["question-" + questionKey] as Question;
            QuestionSummary returnedQuestion = ScenarioContext.Current["NextQuestion"] as QuestionSummary;

            Assert.AreEqual(question.Id, returnedQuestion.Id, "We did not find the correct question.");
        }

        private void PopulateAnswers(ChoiceQuestion question, string answers)
        {
            foreach (var answer in answers.Split(','))
            {
                string cleanAnswer = answer.Trim();
                Choice choice = new Choice() { DisplayText = cleanAnswer, Value = cleanAnswer, Id = Guid.NewGuid() };
                question.AddChoice(choice);
            }
        }
    }
}
