using System;
using System.Collections.Generic;

namespace Interactive_Quiz
{
    public class Quiz : Question
    {
        private List<Question> _questions;
        private int _currentQuestionIndex = -1;
        public string Title { get; set; }
        public int Score { get; private set; }

        public bool isFirstTime;



        public Quiz()
        {

            Title = "Interactive Quiz";
            LoadQuestions();



        }

        private void LoadQuestions()
        {
            _questions = new List<Question>();

            //1st question
            _questions.Add(new Question
            {
                QuestionText = "Which is the biggest country in size",
                Answer1 = "USA",
                Answer2 = "CANADA",
                Answer3 = "RUSSIA",
                Answer4 = "CHINA",
                CorrectAnswer = "RUSSIA"
            });


            //2nd question
            _questions.Add(new Question
            {
                QuestionText = "what is 2 + 3",
                Answer1 = "5",
                Answer2 = "3",
                Answer3 = "6",
                Answer4 = "2",
                CorrectAnswer = "5",

            });


            //3rd question
            _questions.Add(new Question
            {
                QuestionText = "Book is to Reading as Fork is to ________ ",
                Answer1 = "drawing",
                Answer2 = "writing",
                Answer3 = "stirring",
                Answer4 = "eating",
                CorrectAnswer = "eating",
            });



            //4th question
            _questions.Add(new Question
            {
                QuestionText = "8:4 as 10:?",
                Answer1 = "3",
                Answer2 = "5",
                Answer3 = "24",
                Answer4 = "7",
                CorrectAnswer = "5",
            });


            //5th question
            _questions.Add(new Question
            {
                QuestionText = "c# is a programing _________",
                Answer1 = "game",
                Answer2 = "world",
                Answer3 = "language",
                Answer4 = "company",
                CorrectAnswer = "language",
            });
        }

        private Question GetQuestionWithoutAnswer()
        {
            return _questions[_currentQuestionIndex];
        }

        public Question GetNextQuestion()
        {
            
            _currentQuestionIndex++;

            try
            {
                if (_currentQuestionIndex == _questions.Count)
                {
                    throw new Exception($"Quiz ended!! Score is {Score} out of {_questions.Count}");
                }
            }
            catch(Exception ex)
            {
                return new Question()
                {
                    QuestionText = ex.Message 
                };
            }
            return GetQuestionWithoutAnswer();







        }

        public bool CheckUserAnswer(string answer)
        {
            if (answer == _questions[_currentQuestionIndex].CorrectAnswer)
            {
                Score++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
