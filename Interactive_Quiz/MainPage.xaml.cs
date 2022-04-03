using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Interactive_Quiz
{
    public partial class MainPage : ContentPage
    {
        public Quiz quiz;
        //public Question question = new Question();
        
        public MainPage()
        {


            InitializeComponent();
            quiz = new Quiz();
            Title.Text = quiz.Title;
            LoadQuestionsUI();
           



        }

        public void LoadQuestionsUI()
        {
            Question question = quiz.GetNextQuestion();
            QuestionText.Text = question.QuestionText;
            A1Butt.Text = question.Answer1;
            A2Butt.Text = question.Answer2;
            A3Butt.Text = question.Answer3;
            A4Butt.Text = question.Answer4;


        }

        

        void A1Butt_Clicked(System.Object sender, System.EventArgs e)
        {
            
            Button button = sender as Button;
            if (quiz.CheckUserAnswer(button.Text))
            {
                button.BackgroundColor = Color.Green;
            }
            else
                button.BackgroundColor = Color.Red;
            NextButt.IsEnabled = true;
            A1Butt.IsEnabled = false;
            A2Butt.IsEnabled = false;
            A3Butt.IsEnabled = false;
            A4Butt.IsEnabled = false;

        }

        void NextButt_Clicked(System.Object sender, System.EventArgs e)
        {
            LoadQuestionsUI();

            NextButt.IsEnabled = false;
            A1Butt.BackgroundColor = Color.LightGray;
            A2Butt.BackgroundColor = Color.LightGray;
            A3Butt.BackgroundColor = Color.LightGray;
            A4Butt.BackgroundColor = Color.LightGray;

            A1Butt.IsEnabled = true;
            A2Butt.IsEnabled = true;
            A3Butt.IsEnabled = true;
            A4Butt.IsEnabled = true;


        }

        void QuitButt_Clicked(System.Object sender, System.EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
