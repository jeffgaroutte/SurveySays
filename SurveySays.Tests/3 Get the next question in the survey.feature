Feature: Get the next question in the survey
	In order to answer all of required the questions in the survey
	As the person taking the survey
	I want to be given the next question in the survey based on the questions pre-requsites 

	Background: 
	Given I have started taking a survey
	And the first question is "what is your favorite color" with the following answers
	| Answer           |
	| red              |
	| blue             |
	| green            |
	| gray             |
	| bright neon pink |
	And the second question is "what is your favorite animal" with the following answers 
	| Answer |
	| Dog    |
	| Cat    |
	| Fish   |
	| Mouse  |
	| Bird   |
	And the third question is "What... is the air-speed velocity of an unladen swallow"
	And the forth question is "Well how'd you become king then?" with the answers 
	| Answer                                     |
	| The lady of the lake threw a sword at me   |
	| I drew it from the stone                   |
	| As an evil overlord; I took over the world |
	| Mouse                                      |
	| I am not a king                            |
	And the fifth question is "what is your name"

@NextQuestion
Scenario: Get the next question when it does not have pre-requsites 
	Given I answered the first question with "red"
	When I get the next question
	Then the question should be the second question

@NextQuestion
Scenario: Get the next question when it does not have pre-requsites and I have answered a few questions
	Given I answered the first question with "blue"
	And I answered the  second question with "Mouse"	
	When I get the the next question
	Then the question should be the third question

@NextQuestion
Scenario: Get the next question when it does have pre-requsites that I have not met
	Given I answered the first question with "green"
	And I answered the second question with "Mouse"	
	And the third question has the prequsite that the second question was answered with "bird"
	When I get the the next question
	Then the question should be the forth question

@NextQuestion
Scenario: Get the next question when it does have pre-requsites that I have met
	Given I answered the first question with "gray"
	And I answered the second question with "bird"	
	And the third question has the prequsite that the second question was answered with "bird"
	When I get the the next question
	Then the question should be the third question

@NextQuestion
Scenario: Get the next question when I have answered all the questions (in progess)
	Given I answered the first question with "blue"
	And I answered the  second question with "Mouse"	
	When I get the the next question
	Then the question should be the third question