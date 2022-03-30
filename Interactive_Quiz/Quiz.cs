using System;
using System.Collections.Generic;

namespace Interactive_Quiz
{
    public class Quiz : Question
    {
        private List<Question> _questions;
        private int _currentQuestionIndex = 0;
        public string Title { get; set; }
        public int Score { get; private set; }
        public string getQuestion;
        public string getAnswer1;
        public string getAnswer2;
        public string getAnswer3;
        public string getAnswer4;
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
            _questions.Add(new Question());
            _questions[0].QuestionText = "Which is the biggest country in size";
            _questions[0].Answer1 = "USA";
            _questions[0].Answer2 = "CANADA";
            _questions[0].Answer3 = "RUSSIA";
            _questions[0].Answer4 = "CHINA";
            _questions[0].CorrectAnswer = "RUSSIA";

            //2nd question
            _questions.Add(new Question());
            _questions[1].QuestionText = "what is 2 + 3";
            _questions[1].Answer1 = "5";
            _questions[1].Answer2 = "3";
            _questions[1].Answer3 = "6";
            _questions[1].Answer4 = "2";
            _questions[1].CorrectAnswer = "5";

            //3rd question
            _questions.Add(new Question());
            _questions[2].QuestionText = "Book is to Reading as Fork is to ________ ";
            _questions[2].Answer1 = "drawing";
            _questions[2].Answer2 = "writing";
            _questions[2].Answer3 = "stirring";
            _questions[2].Answer4 = "eating";
            _questions[2].CorrectAnswer = "eating";


            //4th question
            _questions.Add(new Question());
            _questions[3].QuestionText = "8:4 as 10:?";
            _questions[3].Answer1 = "3";
            _questions[3].Answer2 = "5";
            _questions[3].Answer3 = "24";
            _questions[3].Answer4 = "7";
            _questions[3].CorrectAnswer = "5";


            //5th question
            _questions.Add(new Question());
            _questions[4].QuestionText = "c# is a programing _________";
            _questions[4].Answer1 = "game";
            _questions[4].Answer2 = "world";
            _questions[4].Answer3 = "language";
            _questions[4].Answer4 = "company";
            _questions[4].CorrectAnswer = "language";

        }

        private void GetQuestionWithoutAnswer() 
        {
            var question = new Question
            {
                QuestionText = _questions[_currentQuestionIndex].QuestionText,
                Answer1 = _questions[_currentQuestionIndex].Answer1,
                Answer2 = _questions[_currentQuestionIndex].Answer2,
                Answer3 = _questions[_currentQuestionIndex].Answer3,
                Answer4 = _questions[_currentQuestionIndex].Answer4,
            };


        }

        public void GetNextQuestion()
        {
            _currentQuestionIndex++;

            if (_currentQuestionIndex ! == _questions.Count)
            {
                GetQuestionWithoutAnswer();
            }
            else if (_currentQuestionIndex == _questions.Count)
            {
                Exception exception;
            }
                
            

        }

        public bool CheckUserAnswer(string answer)
        {
            answer = _questions[_currentQuestionIndex].CorrectAnswer;

        }

    }
}
