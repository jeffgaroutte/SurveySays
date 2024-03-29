﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SurveySays.Tests._4Outlines
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class GetTheNextQuestionInTheSurveyFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "4 Get the next question in the survey.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Get the next question in the survey", "In order to answer all of required the questions in the survey\r\nAs the person tak" +
                    "ing the survey\r\nI want to be given the next question in the survey based on the " +
                    "questions pre-requsites", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Get the next question in the survey")))
            {
                SurveySays.Tests._4Outlines.GetTheNextQuestionInTheSurveyFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
 #line 7
 testRunner.Given("I have started taking a survey", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Answer"});
            table1.AddRow(new string[] {
                        "red"});
            table1.AddRow(new string[] {
                        "blue"});
            table1.AddRow(new string[] {
                        "green"});
            table1.AddRow(new string[] {
                        "gray"});
            table1.AddRow(new string[] {
                        "bright neon pink"});
#line 8
 testRunner.And("the first question is \"what is your favorite color\" with the following answers", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Answer"});
            table2.AddRow(new string[] {
                        "Dog"});
            table2.AddRow(new string[] {
                        "Cat"});
            table2.AddRow(new string[] {
                        "Fish"});
            table2.AddRow(new string[] {
                        "Mouse"});
            table2.AddRow(new string[] {
                        "Bird"});
#line 15
 testRunner.And("the second question is \"what is your favorite animal\" with the following answers", ((string)(null)), table2, "And ");
#line 22
 testRunner.And("the third question is \"What... is the air-speed velocity of an unladen swallow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Answer"});
            table3.AddRow(new string[] {
                        "The lady of the lake threw a sword at me"});
            table3.AddRow(new string[] {
                        "I drew it from the stone"});
            table3.AddRow(new string[] {
                        "As an evil overlord; I took over the world"});
            table3.AddRow(new string[] {
                        "I am not a king"});
#line 23
 testRunner.And("the forth question is \"Well how\'d you become king then\" with the following answer" +
                    "s", ((string)(null)), table3, "And ");
#line 29
 testRunner.And("the fifth question is \"what is your name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        public virtual void Outline_GetTheNextQuestionWhenHasPre_Requsites(string description, string expectedQuestion, string answerThatSastifiesThePrerequsite, string answerToTheSecondQuestion, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "NextQuestion"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Outline - Get the next question when has pre-requsites", @__tags);
#line 32
this.ScenarioSetup(scenarioInfo);
#line 6
 this.FeatureBackground();
#line 33
 testRunner.Given("I answered the first question with \"green\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And(string.Format("I answered the second question with {0}", answerToTheSecondQuestion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And(string.Format("the third question has the prequsite that the second question was answered with {" +
                        "0}", answerThatSastifiesThePrerequsite), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("I get the next question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then(string.Format("the question should be the {0} question", expectedQuestion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Outline - Get the next question when has pre-requsites")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Get the next question in the survey")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("NextQuestion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "when the prequsite is not met")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "when the prequsite is not met")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:expected question", "forth")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:answer that sastifies the prerequsite", "\"Bird\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:answer to the second question", "\"Mouse\"")]
        public virtual void Outline_GetTheNextQuestionWhenHasPre_Requsites_WhenThePrequsiteIsNotMet()
        {
            this.Outline_GetTheNextQuestionWhenHasPre_Requsites("when the prequsite is not met", "forth", "\"Bird\"", "\"Mouse\"", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Outline - Get the next question when has pre-requsites")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Get the next question in the survey")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("NextQuestion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "when the prequsite is met")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:description", "when the prequsite is met")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:expected question", "third")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:answer that sastifies the prerequsite", "\"Bird\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:answer to the second question", "\"Bird\"")]
        public virtual void Outline_GetTheNextQuestionWhenHasPre_Requsites_WhenThePrequsiteIsMet()
        {
            this.Outline_GetTheNextQuestionWhenHasPre_Requsites("when the prequsite is met", "third", "\"Bird\"", "\"Bird\"", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
