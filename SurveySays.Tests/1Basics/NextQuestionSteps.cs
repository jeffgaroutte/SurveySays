using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SurveySays.Domain.Api;
using SurveySays.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SurveySays.Tests._1Basics
{
    [Binding]
    public class NextQuestionSteps
    {

        [Given(@"I have started taking a survey")]
        public void GivenIHaveStartedTakingASurvey()
        {
            SurveySays.Domain.Api.Survey survey = new SurveySays.Domain.Api.Survey();
            ScenarioContext.Current["Survey"] = survey;
            /*
            var config = new SetupSurvey();

            var questionOneId = Guid.NewGuid();
            var questionOneChoiceOne = Guid.NewGuid();
            var questionOneChoiceTwo = Guid.NewGuid();

            var survery = config
                .AddQuestion("here is question one text")
                    .WithId(questionOneId)
                    .AsMultiChoice()
                        .AddChoice("choice 1").WithId(questionOneChoiceOne).And
                        .AddChoice("choice 2").WithId(questionOneChoiceTwo)
                        .EndOfQuestion
                .AddQuestion("here is question two text")
                    .AsSingleChoice()
                        .AddChoice("Choice 1").And
                        .AddChoice("Choice 2").And
                        .AddChoice("Choice 3")
                        .AddPreRequisite(questionOneId).WithChoice(questionOneChoiceOne)
                        .AddPreRequisite(questionOneId).WithChoice(questionOneChoiceTwo)
                        .EndOfQuestion
                .AddQuestion("here is question three text")
                    .AsMultiChoice()
                        .AddChoice("Choice 1").And
                        .AddChoice("Choice 2").And
                        .AddChoice("Choice 3").AsReadOnly
                        .EndOfQuestion
                .AddQuestion("here is question four text")
                    .AsSingleChoice()
                        .AddChoice("Choice 1").And
                        .AddChoice("Choice 2").And
                        .AddChoice("Choice 3")
                            .AsReadOnly
                            .HavingValueOf("asdf")
                        .EndOfQuestion
                .Done();
            */


        }

        [Given(@"I answered the question ""(.*)"" with the answers ""(.*)"" as ""(.*)""")]
        public void GivenIAnsweredTheQuestionWithTheAnswersAs(string questionText, string answers, string myAnswer)
        {
            SurveySays.Domain.Api.Survey survey = ScenarioContext.Current["Survey"] as SurveySays.Domain.Api.Survey;

            SingleChoiceQuestion question = new SingleChoiceQuestion(questionText);
            PopulateAnswers(question, answers);
            survey.AddQuestion(question);
            Choice choice = question.Choices.SingleOrDefault(c => c.DisplayText.Equals(myAnswer));
            survey.RecordSingleAnswer(question.Id, choice.Id);
        }

        [Given(@"the survey has the question ""([^""]*)"" with the answers ""(.*)""")]
        public void GivenTheSurveyHasTheQuestionWithTheAnswers(string questionText, string answers)
        {
            SurveySays.Domain.Api.Survey survey = ScenarioContext.Current["Survey"] as SurveySays.Domain.Api.Survey;

            SingleChoiceQuestion question = new SingleChoiceQuestion(questionText);
            PopulateAnswers(question, answers);
            survey.AddQuestion(question);
        }

        [Given(@"the survey has the question ""([^""]*)""")]
        public void GivenTheSurveyHasTheQuestion(string questionText)
        {
            SurveySays.Domain.Api.Survey survey = ScenarioContext.Current["Survey"] as SurveySays.Domain.Api.Survey;

            MemoQuestion question = new MemoQuestion(questionText);
            survey.AddQuestion(question);
        }

        [When(@"I get the next question")]
        public void WhenIGetTheNextQuestion()
        {
            SurveySays.Domain.Api.Survey survey = ScenarioContext.Current["Survey"] as SurveySays.Domain.Api.Survey;

            QuestionSummary question = null;

            question = survey.GetNextQuestion();
            ScenarioContext.Current["NextQuestion"] = question;
        }

        [Then(@"the question should have the text ""(.*)""")]
        public void ThenTheQuestionShouldHaveTheText(string questionText)
        {
            QuestionSummary question = ScenarioContext.Current["NextQuestion"] as QuestionSummary;
            Assert.AreEqual(questionText, question.QuestionText);
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
