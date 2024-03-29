﻿Feature: Get the next question in the survey
	In order to answer all of required the questions in the survey
	As the person taking the survey
	I want to be given the next question in the survey based on the questions pre-requsites 

	Background: 
	Given I have started taking a survey
	And the first question is "what is your favorite color" with the answers "red, blue, green, gray"
	And the second question is "what is your favorite animal" with the answers "Dog, Cat, Fish, Mouse, Bird"
	And the third question is "What... is the air-speed velocity of an unladen swallow"
	And the forth question is "Well how'd you become king then?" with the answers "The lady of the lake threw a sword at me, I drew it from the stone, As an evil overlord I took over the world, I am not a king"
	And the fifth question is "what is your name"

@NextQuestion
Scenario: Background - Get the next question when it does not have pre-requsites 
	Given I answered the first question with "red"
	When I get the next question
	Then the question should be the second question

@NextQuestion
Scenario: Background - Get the next question when it does not have pre-requsites and I have answered a few questions
	Given I answered the first question with "blue"
	And I answered the second question with "Mouse"	
	When I get the next question
	Then the question should be the third question

@NextQuestion
Scenario: Background - Get the next question when it does have pre-requsites that I have not met
	Given I answered the first question with "green"
	And I answered the second question with "Mouse"	
	And the third question has the prequsite that the second question was answered with "Bird"
	When I get the next question
	Then the question should be the forth question

@NextQuestion
Scenario: Background - Get the next question when it does have pre-requsites that I have met
	Given I answered the first question with "gray"
	And I answered the second question with "Bird"	
	And the third question has the prequsite that the second question was answered with "Bird"
	When I get the next question
	Then the question should be the third question