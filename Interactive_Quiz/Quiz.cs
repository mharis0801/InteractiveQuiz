using System;
using System.Collections.Generic;

namespace Interactive_Quiz
{
    public class Quiz : Question
    {
        private List<Question> _questions;
        private int _currentQuestionIndex;
        public string Title { get; set; }
        public int Score { get; private set; }


        public Quiz()
        {
            _questions = new List<Question>();
        }

        private void LoadQuestions()
        {

        }

        private GetQuestionWithoutAnswer() : base()
        {

        }

        public GetNextQuestion():base()
        {

        }

        public bool CheckUserAnswer(string answer)
        {
            return true;
        }

    }
}
